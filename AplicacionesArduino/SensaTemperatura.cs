using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Ports ;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace AplicacionesArduino
{
    public partial class SensaTemperatura : Form
    {

        #region Configuración de Google Drive
        static string[] Scopes = { DriveService.Scope.Drive };
        static string ApplicationName = "Drive API .NET Quickstart";
        #endregion        

        SerialPort mipuerto;
        int tiempo = 0;
        public SensaTemperatura(SerialPort puerto)
        {
            InitializeComponent();
            mipuerto = puerto;
        }

        private void TmTemperatura_Tick(object sender, EventArgs e)
        {
            byte temperatura = (byte)mipuerto.ReadByte();
            chtTemperatura.Series["SerieTemperatura"].Points.AddXY(tiempo, temperatura);
        }

        private void IniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmTemperatura.Start();
        }

        private void DetenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmTemperatura.Stop();
        }

        private void GuardarEnGoogleDriveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Google();
        }

        private void Google()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
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
                MessageBox.Show("Credential file saved to: " + credPath);
            }

            // Create Drive API service.
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            /*
            // Define parameters of request.
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.PageSize = 10;
            listRequest.Fields = "nextPageToken, files(id, name)";
            */
            Google.Apis.Drive.v3.Data.File metaDatos = new Google.Apis.Drive.v3.Data.File()
            {
                Name = "FolderDesdeQuickApp",
                MimeType="application/vnd.google-apps.folder"
            };
            FilesResource.CreateRequest request = service.Files.Create(metaDatos);
            request.Fields = "id";
            request.Execute();

            


            /*
            // List files.
            IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute()
                .Files;
            Console.WriteLine("Files:");
            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {
                    lstArchivos.Items.Add(file.Name+" "+ file.Id);
                }
            }
            else
            {
                MessageBox.Show("No hay archivos");
            }
            */
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Document objDoc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.pdf)|*.pdf";
            if( saveFileDialog.ShowDialog() == DialogResult.OK  )
            {
                PdfWriter objPDF = PdfWriter.GetInstance(objDoc, new FileStream(saveFileDialog.FileName, FileMode.Append));
                objDoc.Open();
                var imagenGraficar = new MemoryStream();
                chtTemperatura.SaveImage(imagenGraficar, ChartImageFormat.Png);
                iTextSharp.text.Image GrafImagen = iTextSharp.text.Image.GetInstance(imagenGraficar.GetBuffer());
                objDoc.Add(GrafImagen);
                objDoc.Close();

            }
            

        }
    }

}
