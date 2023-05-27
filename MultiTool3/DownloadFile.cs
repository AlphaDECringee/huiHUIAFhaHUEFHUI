using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Linq;
using System.Threading;
using System.ComponentModel;
using System.Drawing;

namespace MultiTool3
{
    public partial class DownloadFile : Form
    {
        private string URL;
        public DownloadFile(string name, string url, string oFile)
        {
            InitializeComponent();
            URL = url;
            string curDir = Directory.GetCurrentDirectory();
            Directory.SetCurrentDirectory(curDir);
            string defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
            string jsonPath = "config.json";
            if (!System.IO.File.Exists(jsonPath))
            {
                JObject configObject = new JObject();
                configObject["DefaultPath"] = defaultPath;
                System.IO.File.WriteAllText(jsonPath, configObject.ToString());
            }
            JObject loadedConfigObject = JObject.Parse(System.IO.File.ReadAllText(jsonPath));
            string INIdwnPath = (string)loadedConfigObject["DefaultPath"];
            LBL_DwnName.Text = name;
            TBX_FileName.Text = oFile;
            TBX_DownloadPfad.Text = INIdwnPath;
        }

        private void BTN_SavePath_Click(object sender, EventArgs e)
        {
            string inputPath = TBX_DownloadPfad.Text;
            string jsonPath = "config.json";
            JObject configObject = new JObject();
            configObject["DefaultPath"] = inputPath;
            System.IO.File.WriteAllText(jsonPath, configObject.ToString());
        }

        private void BTN_StartDwn_Click(object sender, EventArgs e)
        {
            string path = TBX_DownloadPfad.Text;
            string filename = TBX_FileName.Text;
            if (System.IO.File.Exists(filename)) { System.IO.File.Delete(filename); }
            if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
            Thread thread = new Thread(() => {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri(URL), path + @"/" + filename);
            });
            thread.Start();
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                double receivedMB = e.BytesReceived / (1024.0 * 1024.0);
                double totalMB = e.TotalBytesToReceive / (1024.0 * 1024.0);
                LBL_DownloadStatus.Text = $"Heruntergeladen: {receivedMB:F2} MB von {totalMB:F2} MB";
                PRB_DownloadStatus.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                LBL_DownloadStatus.Text = "Download abgeschlossen. Warte auf Aufgabe...";
            });
        }
    }
}
