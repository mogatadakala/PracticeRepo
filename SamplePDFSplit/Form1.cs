using System.Reflection.PortableExecutable;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;

namespace SamplePDFSplit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsplit_Click(object sender, EventArgs e)
        {
            try
            {
                //validating the input parameteres
                if (txtfilebrowse.Text == "")
                {
                    MessageBox.Show("Please select the input file for splitting");

                }
                if (txtsplitinterval.Text == "")
                {
                    MessageBox.Show("Please Enter the No of pages to be splitted");
                }
                if (txtfolderbrowse.Text == "")
                {
                    MessageBox.Show("Please select the Outout folder for storing the split file");
                }
                if (txtfilebrowse.Text != "" && txtfolderbrowse.Text != "" && txttotalnoofpages.Text != "")
                {
                    string pdfInputFilePath = txtfilebrowse.Text;
                    string outputPath = txtfolderbrowse.Text;
                    PdfReader pdfReader = new PdfReader(pdfInputFilePath);
                    int interval = Convert.ToInt32(txtsplitinterval.Text);
                    int pageNameSuffix = 0;
                    PdfReader reader = new PdfReader(pdfInputFilePath);
                    FileInfo file = new FileInfo(pdfInputFilePath);
                    string pdfFileName = file.Name.Substring(0, file.Name.LastIndexOf(".")) + "-";
                    for (int pageNumber = 1; pageNumber <= reader.NumberOfPages; pageNumber += interval)
                    {
                        pageNameSuffix++;
                        string newPdfFileName = string.Format(pdfFileName + "{0}", pageNameSuffix);
                        SplitAndSaveInterval(pdfInputFilePath, outputPath, pageNumber, interval, newPdfFileName);
                    }
                }
                else
                {
                    MessageBox.Show("Some Mandatory fields are missing");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception message :" + ex.Message);
            }

        }
        private void SplitAndSaveInterval(string pdfInputFilePath, string outputPath, int startPage, int interval, string pdfFileName)
        {
            try
            {
                //code to split and save the pdf file
                using (PdfReader reader = new PdfReader(pdfInputFilePath))
                {
                    Document document = new Document();
                    PdfCopy copy = new PdfCopy(document, new FileStream(outputPath + "\\" + pdfFileName + ".pdf", FileMode.Create));
                    document.Open();

                    for (int pagenumber = startPage; pagenumber < (startPage + interval); pagenumber++)
                    {
                        if (reader.NumberOfPages >= pagenumber)
                        {
                            copy.AddPage(copy.GetImportedPage(reader, pagenumber));
                        }
                        else
                        {
                            break;
                        }

                    }
                    document.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception message :" + ex.Message);
            }

        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            try
            {
                //Browsing the input file
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    InitialDirectory = @"D:\",
                    Title = "Browse pdf Files",

                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "pdf",
                    Filter = "pdf files (*.pdf)|*.pdf",
                    FilterIndex = 2,
                    RestoreDirectory = true,

                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtfilebrowse.Text = openFileDialog1.FileName;
                    string pdfFilePath = txtfilebrowse.Text;
                    PdfReader pdfReader = new PdfReader(pdfFilePath);
                    txttotalnoofpages.Text = Convert.ToString(pdfReader.NumberOfPages);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception message :" + ex.Message);
            }

        }

        private void btnbrowsefolder_Click(object sender, EventArgs e)
        {
            try
            {
                //browsing the output folder
                FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                folderDlg.ShowNewFolderButton = true;
                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtfolderbrowse.Text = folderDlg.SelectedPath;
                    Environment.SpecialFolder root = folderDlg.RootFolder;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception message :" + ex.Message);
            }

        }
    }
}