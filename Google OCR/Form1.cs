using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing;
using Google.Cloud.Vision.V1;
using Xceed.Words.NET;

namespace Google_OCR
{
    public partial class Form1 : Form
    {
        public List<string> filePaths = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertFiles_Click(object sender, EventArgs e)
        {
            string authPath = Directory.GetFiles(Directory.GetCurrentDirectory(), "ascendant-cache-354608-a385b3695e72.json")[0];
            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", authPath);
            foreach (string file in filePaths)
            {
                string[] fileNameArray = file.Split('\\');
                string currentDirectory = fileNameArray[fileNameArray.Length - 2];
                string currentFile = fileNameArray[fileNameArray.Length - 1];
                using (Bitmap bitmap = (Bitmap)System.Drawing.Image.FromFile(file))
                {
                    using(Bitmap newBitmap = new Bitmap(bitmap))
                    {
                        newBitmap.SetResolution(4000, 4000);
                        newBitmap.Save(currentFile + "4000.jpg", ImageFormat.Png);
                    }
                }

                var currentImage = Google.Cloud.Vision.V1.Image.FromFile(file);
                var client = ImageAnnotatorClient.Create();
                var response = client.DetectDocumentTextAsync(currentImage);

                //string saveFilePath = Directory.GetDirectories(Directory.GetCurrentDirectory(), "Converted Files")[0] + "\\" +  currentDirectory + "\\" + currentFile.Split('.')[0] + ".docx";
                //File.C(saveFilePath).Close();
                //using (StreamWriter writer = new StreamWriter(saveFilePath))
                //{
                //    writer.Write(response);
                //    writer.Close();
                //}

                string savePathFolder = Path.Combine(Directory.GetDirectories(Directory.GetCurrentDirectory(), "Converted Files")[0], currentDirectory);
                if (!Directory.Exists(savePathFolder))
                {
                    Directory.CreateDirectory(savePathFolder);
                
                } 

                string saveFilePath = Path.Combine(savePathFolder, currentFile.Split('.')[0] + ".docx");
                var newDoc = DocX.Create(saveFilePath);
                newDoc.InsertParagraph(response.Result.Text);
                newDoc.Save();
                
                MessageBox.Show("Success");

            }
        }

        private void BrowseFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files|*.bmp;*.jpg;*.jpeg;*.gif;*.png;*.tif|All files|*.*";
            openFileDialog.Multiselect = true;
            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePaths = openFileDialog.FileNames.ToList();
            }
        }
    }
}
