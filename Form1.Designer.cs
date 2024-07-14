namespace PDFToPDF_A3Combiner
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnSelectPDF;
        private System.Windows.Forms.Button btnSelectXML;
        private System.Windows.Forms.Button btnSelectICC;
        private System.Windows.Forms.Button btnStartCombine;
        private System.Windows.Forms.TextBox txtPDFPath;
        private System.Windows.Forms.TextBox txtXMLPath;
        private System.Windows.Forms.TextBox txtICCPath;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnSelectPDF = new System.Windows.Forms.Button();
            this.btnSelectXML = new System.Windows.Forms.Button();
            this.btnSelectICC = new System.Windows.Forms.Button();
            this.btnStartCombine = new System.Windows.Forms.Button();
            this.txtPDFPath = new System.Windows.Forms.TextBox();
            this.txtXMLPath = new System.Windows.Forms.TextBox();
            this.txtICCPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // 
            // btnSelectPDF
            // 
            this.btnSelectPDF.Location = new System.Drawing.Point(12, 12);
            this.btnSelectPDF.Name = "btnSelectPDF";
            this.btnSelectPDF.Size = new System.Drawing.Size(100, 23);
            this.btnSelectPDF.TabIndex = 0;
            this.btnSelectPDF.Text = "Select PDF";
            this.btnSelectPDF.UseVisualStyleBackColor = true;
            this.btnSelectPDF.Click += new System.EventHandler(this.BtnSelectPDF_Click);
            // 
            // btnSelectXML
            // 
            this.btnSelectXML.Location = new System.Drawing.Point(12, 41);
            this.btnSelectXML.Name = "btnSelectXML";
            this.btnSelectXML.Size = new System.Drawing.Size(100, 23);
            this.btnSelectXML.TabIndex = 1;
            this.btnSelectXML.Text = "Select XML";
            this.btnSelectXML.UseVisualStyleBackColor = true;
            this.btnSelectXML.Click += new System.EventHandler(this.BtnSelectXML_Click);
            // 
            // btnSelectICC
            // 
            this.btnSelectICC.Location = new System.Drawing.Point(12, 70);
            this.btnSelectICC.Name = "btnSelectICC";
            this.btnSelectICC.Size = new System.Drawing.Size(100, 23);
            this.btnSelectICC.TabIndex = 2;
            this.btnSelectICC.Text = "Select ICC";
            this.btnSelectICC.UseVisualStyleBackColor = true;
            this.btnSelectICC.Click += new System.EventHandler(this.BtnSelectICC_Click);
            // 
            // btnStartCombine
            // 
            this.btnStartCombine.Location = new System.Drawing.Point(12, 99);
            this.btnStartCombine.Name = "btnStartCombine";
            this.btnStartCombine.Size = new System.Drawing.Size(100, 23);
            this.btnStartCombine.TabIndex = 3;
            this.btnStartCombine.Text = "Start Combine";
            this.btnStartCombine.UseVisualStyleBackColor = true;
            this.btnStartCombine.Click += new System.EventHandler(this.BtnStartCombine_Click);
            // 
            // txtPDFPath
            // 
            this.txtPDFPath.Location = new System.Drawing.Point(118, 14);
            this.txtPDFPath.Name = "txtPDFPath";
            this.txtPDFPath.ReadOnly = true;
            this.txtPDFPath.Size = new System.Drawing.Size(350, 20);
            this.txtPDFPath.TabIndex = 4;
            // 
            // txtXMLPath
            // 
            this.txtXMLPath.Location = new System.Drawing.Point(118, 43);
            this.txtXMLPath.Name = "txtXMLPath";
            this.txtXMLPath.ReadOnly = true;
            this.txtXMLPath.Size = new System.Drawing.Size(350, 20);
            this.txtXMLPath.TabIndex = 5;
            // 
            // txtICCPath
            // 
            this.txtICCPath.Location = new System.Drawing.Point(118, 72);
            this.txtICCPath.Name = "txtICCPath";
            this.txtICCPath.ReadOnly = true;
            this.txtICCPath.Size = new System.Drawing.Size(350, 20);
            this.txtICCPath.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 135);
            this.Controls.Add(this.txtICCPath);
            this.Controls.Add(this.txtXMLPath);
            this.Controls.Add(this.txtPDFPath);
            this.Controls.Add(this.btnStartCombine);
            this.Controls.Add(this.btnSelectICC);
            this.Controls.Add(this.btnSelectXML);
            this.Controls.Add(this.btnSelectPDF);
            this.Name = "Form1";
            this.Text = "PDF to PDF/A-3 Combiner";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
