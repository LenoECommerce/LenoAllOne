using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.Office.Interop.Excel;
using Org.BouncyCastle.Asn1.Ocsp;
using SautinSoft.Document.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EigenbelegToolAlpha
{
    public partial class GoogleDrive : Form
    {
        static string[] Scopes = { DriveService.Scope.Drive };
        static string ApplicationName = "DriveAccessLeno";
        public static string currentLink = "";
        public GoogleDrive(string path, string fileFormat)
        {
            InitializeComponent();
            UserCredential credential;
            credential = GetCredentials();

            // Create Drive API service.
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            if (fileFormat == "mp4")
            {
                UploadBasicImage(path, service);
            }
            else if (fileFormat == "pdf")
            {
                UploadBasicPDF(path, service);
            }
            else if (fileFormat == "sql")
            {
                UploadBasicSQL(path, service);
            }
        }

        public static void GetFile ()
        {
            UserCredential credential;
            credential = GetCredentials();
            // Create Drive API service.
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }

        public static void UploadBasicImage(string path, DriveService service)
        {
            //Objektfile von Google Drive
            var fileMetadata = new Google.Apis.Drive.v3.Data.File();
            fileMetadata.Name = Path.GetFileName(path);
            fileMetadata.MimeType = "video/mp4";
            FilesResource.CreateMediaUpload request;
            using (var stream = new FileStream(path, FileMode.Open))
            {
                request = service.Files.Create(fileMetadata, stream, "video/mp4");
                request.Fields = "permissionIds, id, webViewLink";
                request.Upload();
            }
            Permission perm = new Permission();
            perm.Role = "reader";
            perm.Type = "anyone";

            var file = request.ResponseBody;
            var permissionId = file.PermissionIds;
            service.Permissions.Create(perm, file.Id).Execute();

            currentLink =  file.WebViewLink;
            //Console.WriteLine("File ID: " + file.Id +" "+ file.WebViewLink);
        }
        public static void UploadBasicPDF(string path, DriveService service)
        {
           
            var fileMetadata = new Google.Apis.Drive.v3.Data.File();
            fileMetadata.Name = Path.GetFileName(path);
            fileMetadata.MimeType = "application/pdf";
            FilesResource.CreateMediaUpload request;
            using (var stream = new FileStream(path, FileMode.Open))
            {
                request = service.Files.Create(fileMetadata, stream, "application/pdf");
                request.Fields = "permissionIds, id, webViewLink";
                request.Upload();
            }
            Permission perm = new Permission();
            perm.Role = "reader";
            perm.Type = "anyone";

            var file = request.ResponseBody;
            var permissionId = file.PermissionIds;
            service.Permissions.Create(perm, file.Id).Execute();

            currentLink = file.WebViewLink;
        }

        public static void UploadBasicSQL(string path, DriveService service)
        {

            var fileMetadata = new Google.Apis.Drive.v3.Data.File();
            fileMetadata.Name = Path.GetFileName(path);
            fileMetadata.MimeType = "text/plain";
            FilesResource.CreateMediaUpload request;
            using (var stream = new FileStream(path, FileMode.Open))
            {
                request = service.Files.Create(fileMetadata, stream, "text/plain");
                request.Fields = "permissionIds, id, webViewLink";
                request.Upload();
            }
            Permission perm = new Permission();
            perm.Role = "reader";
            perm.Type = "anyone";

            var file = request.ResponseBody;
            var permissionId = file.PermissionIds;
            service.Permissions.Create(perm, file.Id).Execute();

            currentLink = file.WebViewLink;
        }

        private static UserCredential GetCredentials()
        {
            UserCredential credential;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\credentials.json";
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);

            }
            return credential;
        }





        private void GoogleDrive_Load(object sender, EventArgs e)
        {

        }
    }
}
