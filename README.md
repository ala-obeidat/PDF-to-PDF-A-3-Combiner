# PDF to PDF/A-3 Combiner

This Windows Forms application allows you to combine a PDF file with an XML file and embed an ICC profile to create a PDF/A-3 compliant document. The application uses the iText7 library along with BouncyCastle for cryptographic operations.

## Features

- Select a PDF file to be combined.
- Select an XML file to be embedded within the PDF.
- Select an ICC profile to ensure PDF/A-3 compliance.
- Combine the selected files and generate a PDF/A-3 compliant document with metadata.

## Requirements

- .NET Framework
- Visual Studio
- iText7 Libraries
- BouncyCastle Libraries

## Installation

1. **Clone the repository**:
    ```sh
    git clone https://github.com/ala-obeidat/PDF-to-PDF-A-3-Combiner.git
    ```

2. **Open the solution in Visual Studio**.

3. **Install the required NuGet packages**:
    - `iText7`
    - `itext7.bouncy-castle-adapter`
    - `BouncyCastle.NetCore`

    You can install these packages using the NuGet Package Manager or the Package Manager Console:
    ```sh
    Install-Package iText7
    Install-Package itext7.pdfa
    Install-Package itext7.bouncy-castle-adapter
    Install-Package BouncyCastle.NetCore
    ```

## Usage

1. **Run the application**:
    - Open the solution in Visual Studio.
    - Press `F5` or click on `Start` to run the application.

2. **Select the PDF file**:
    - Click the `Select PDF` button.
    - Browse and select the PDF file you want to combine.

3. **Select the XML file**:
    - Click the `Select XML` button.
    - Browse and select the XML file you want to embed.

4. **Select the ICC Profile**:
    - Click the `Select ICC` button.
    - Browse and select the ICC profile file. You can download the sRGB IEC61966-2.1 ICC profile from [Adobe ICC Profiles for Windows](https://www.adobe.com/support/downloads/iccprofiles/iccprofiles_win.html) or [Color.org](https://www.color.org/chardata/rgb/srgb.xalter).

5. **Start the Combination Process**:
    - Click the `Start Combine` button.
    - The application will generate a PDF/A-3 compliant document with the embedded XML file and selected ICC profile.

6. **Check the Output**:
    - The output PDF will be saved in the same directory as the selected PDF file with the suffix `-a-3.pdf`.

## Example

After running the application and selecting the necessary files, the output message will confirm the successful creation of the combined PDF/A-3 file:

