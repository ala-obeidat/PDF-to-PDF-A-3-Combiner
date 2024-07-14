using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Filespec;
using iText.Pdfa;

namespace PDFToPDF_A3Combiner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSelectPDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Select PDF File"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPDFPath.Text = openFileDialog.FileName;
            }
        }

        private void BtnSelectXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "XML files (*.xml)|*.xml",
                Title = "Select XML File"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtXMLPath.Text = openFileDialog.FileName;
            }
        }

        private void BtnSelectICC_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "ICC files (*.icc)|*.icc",
                Title = "Select ICC Profile"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtICCPath.Text = openFileDialog.FileName;
            }
        }

        private void BtnStartCombine_Click(object sender, EventArgs e)
        {
            string pdfPath = txtPDFPath.Text;
            string xmlPath = txtXMLPath.Text;
            string iccPath = txtICCPath.Text;

            if (string.IsNullOrWhiteSpace(pdfPath) || string.IsNullOrWhiteSpace(xmlPath) || string.IsNullOrWhiteSpace(iccPath))
            {
                MessageBox.Show("Please select PDF, XML, and ICC files.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string outputPath = Path.Combine(Path.GetDirectoryName(pdfPath), Path.GetFileNameWithoutExtension(pdfPath) + "-a-3.pdf");
                string pdfTitle = Path.GetFileNameWithoutExtension(pdfPath);

                using (var writer = new PdfWriter(outputPath))
                {
                    var pdfDoc = new PdfADocument(writer, PdfAConformanceLevel.PDF_A_3B, CreateOutputIntent(writer, iccPath));
                    pdfDoc.SetTagged();

                    // Copy pages from the original PDF
                    using (var srcDoc = new PdfDocument(new PdfReader(pdfPath)))
                    {
                        srcDoc.CopyPagesTo(1, srcDoc.GetNumberOfPages(), pdfDoc);
                    }

                    // Embed the XML file
                    var fileBytes = File.ReadAllBytes(xmlPath);
                    var fileSpec = PdfFileSpec.CreateEmbeddedFileSpec(pdfDoc, fileBytes, "XML File", Path.GetFileName(xmlPath), new PdfName("application/xml"), null, new PdfName("Data"));
                    pdfDoc.AddFileAttachment(Path.GetFileName(xmlPath), fileSpec);

                    // Add metadata for PDF/A-3 compliance
                    pdfDoc.GetDocumentInfo().SetTitle(pdfTitle);
                    pdfDoc.GetDocumentInfo().SetAuthor("Ala Obeidat");
                    pdfDoc.GetDocumentInfo().SetSubject("PDF/A-3 with Embedded XML");

                    pdfDoc.Close();
                }

                MessageBox.Show($"Files have been combined and saved as:\n{outputPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private PdfOutputIntent CreateOutputIntent(PdfWriter writer, string iccPath)
        {
            return new PdfOutputIntent("Custom", "", "http://www.color.org", "sRGB IEC61966-2.1", new MemoryStream(File.ReadAllBytes(iccPath)));
        }
    }
}
