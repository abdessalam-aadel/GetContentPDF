using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace GetContentPDF
{
    public partial class FrmMain : Form
    {
        string[] PDFfiles;
        int fileCount = 0;
        string selected_path;

        public FrmMain() => InitializeComponent();
        public static int SearchDirectoryTree(string path, out string[] PDFfiles)
        {
            PDFfiles = Directory.GetFiles(path, "*.pdf", SearchOption.AllDirectories);
            return PDFfiles.Length;
        }
        static string ExtractTextFromPage(PdfDocument pdfDoc, int pageNumber)
        {
            var page = pdfDoc.GetPage(pageNumber);
            var strategy = new SimpleTextExtractionStrategy();
            var text = PdfTextExtractor.GetTextFromPage(page, strategy);
            return text;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FD = new FolderBrowserDialog();
            if (selected_path != null)
                FD.SelectedPath = selected_path;

            if (FD.ShowDialog() == DialogResult.OK)
            {
                selected_path = FD.SelectedPath;
                txtBoxPath.Text = FD.SelectedPath;
                fileCount = SearchDirectoryTree(FD.SelectedPath, out PDFfiles);
                // Check the Empty Folder
                lblCountPDF.Text = fileCount == 0 ? "Your Folder is Empty" : fileCount + " files.";
                // Clear the Alert message and success message
                lblDone.Text = "";
                lblAlert.Text = "";
                picDone.Visible = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Clear the Alert message and success message
            lblDone.Text = "";
            lblAlert.Text = "";
            picDone.Visible = false;

            // Check if the user has been selected a folder
            if (PDFfiles == null)
            {
                lblAlert.Text = "Please select your folder or drag your PDF file and try again!";
                return;
            }

            // Check the Empty Folder
            if (fileCount == 0)
            {
                lblAlert.Text = "Your Folder is Empty";
                return;
            }

            Cursor = Cursors.WaitCursor;

            try
            {
                // Define the CSV file path
                //string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                //string csvFilePath = desktopPath + @"\PDF_files.csv";
                string csvFilePath = selected_path + @"\PDF_files.csv";

                using (StreamWriter writer = new StreamWriter(csvFilePath, true)) // 'true' for append mode
                {
                    foreach (string filePath in PDFfiles)
                    {
                        string fileName = Path.GetFileNameWithoutExtension(filePath);
                        // Text to search for
                        string searchText = "CONTENANCE";
                        // Open the PDF document
                        using (PdfReader reader = new PdfReader(filePath))
                        using (PdfDocument pdfDoc = new PdfDocument(reader))
                        {
                            int pageCount = pdfDoc.GetNumberOfPages();
                            for (int i = 1; i <= pageCount; i++)
                            {
                                string pageText = ExtractTextFromPage(pdfDoc, i);
                                // Check if the search text is in the extracted text
                                if (pageText.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                                {
                                    //Start Regex
                                    string pattern = txtBoxPat.Text;
                                    Match match = Regex.Match(pageText, pattern);
                                    if (match.Success)
                                    {
                                        // Write the file path and Contenance to the CSV file
                                        writer.WriteLine(fileName + " CC : " + match.Value);
                                    }
                                }
                                else
                                    writer.WriteLine(fileName + " does not contain : " + searchText);
                            }
                        }

                    }
                }// writer.Dispose() is automatically called here
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Cursor = Cursors.Default;
                PDFfiles = null;
                txtBoxPath.Text = "Select your folder ...";
                lblCountPDF.Text = "...";
                return;
            }

            lblDone.Text = "Done";
            picDone.Visible = true;
            Cursor = Cursors.Default;
            PDFfiles = null;
            txtBoxPath.Text = "Select your folder ...";
            lblCountPDF.Text = "...";
        }

        private void GitLink_Click(object sender, EventArgs e)
        {
            // Go to Github repository
            string url = "https://github.com/abdessalam-aadel/GetContentPDF";

            // Open the URL in the default web browser
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Ensures the URL is opened in the default web browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
