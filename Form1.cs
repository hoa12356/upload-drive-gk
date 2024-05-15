using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UploadFiles
{
    public partial class Form1 : Form
    {
        private const string PathToServiceAccountKeyFile = @"E:\Hoc\2023-2024\HK2 2023-2024\LT MANG\UploadGoogleDrive\ambient-climate-396313-dd651a7eb936.json";
        private const string ServiceAccountEmail = "upload-file@ambient-climate-396313.iam.gserviceaccount.com";
        private const string ParentDirectoryId = "1zQxmUsoUCnDA1Dv7NuYI0JsSME1WFXks";
        private readonly List<string> _listFiles = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void selectFiles_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    _listFiles.Add(fileName);
                    filesSelected.Text += "- " + fileName + Environment.NewLine;
                }
            }
        }

        private async void upload_Click(object sender, EventArgs e)
        {
            try
            {
                // Read the service account key file
                GoogleCredential credential;
                using (var stream = new FileStream(PathToServiceAccountKeyFile, FileMode.Open, FileAccess.Read))
                {
                    credential = GoogleCredential.FromStream(stream)
                        .CreateScoped(DriveService.ScopeConstants.Drive);
                }

                // Create Drive service
                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential
                });

                foreach (string filePath in _listFiles)
                {
                    await UploadFileAsync(filePath, service);
                }

                // Clear list and display success message
                _listFiles.Clear();
                filesSelected.Text = string.Empty;
                MessageBox.Show("Files have been uploaded successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task UploadFileAsync(string filePath, DriveService service)
        {
            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = Path.GetFileName(filePath),
                Parents = new List<string> { ParentDirectoryId }
            };

            // Determine the content type based on the file extension
            string contentType = GetContentType(filePath);

            using var fsSource = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            var request = service.Files.Create(fileMetadata, fsSource, contentType);
            request.Fields = "*";
            var results = await request.UploadAsync(CancellationToken.None);

            if (results.Status == Google.Apis.Upload.UploadStatus.Failed)
            {
                throw new Exception($"Error uploading file '{filePath}': {results.Exception.Message}");
            }
        }

        private string GetContentType(string filePath)
        {
            // Get the file extension
            string extension = Path.GetExtension(filePath).ToLower();

            // Map the file extension to the corresponding content type
            switch (extension)
            {
                case ".png":
                    return "image/png";
                case ".txt":
                    return "text/plain";
                // Add more cases for other file types if needed
                default:
                    return "application/octet-stream"; // Default content type
            }
        }
    }
}
