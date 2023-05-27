using System;
using System.Windows.Forms;

namespace MultiTool3
{
    public partial class HOME_CrackedProgramme : UserControl
    {
        public HOME_CrackedProgramme()
        {
            InitializeComponent();
        }
        
        private void BTN_4KVD_Click(object sender, EventArgs e)
        {
            string oFile = "4KVideoDownloader.zip";
            string fourKVD = "4K Video Downloader";
            string url = "https://github.com/AlphaDECringee/softwarerepository/releases/download/software/4KVideoDownloader.zip";
            DownloadFile dwnDiag = new DownloadFile(fourKVD, url, oFile);
            dwnDiag.ShowDialog();
        }

        private void BTN_Filmora9_Click(object sender, EventArgs e)
        {
            string oFile = "Filmora.zip";
            string fourKVD = "Filmora 9";
            string url = "https://github.com/AlphaDECringee/softwarerepository/releases/download/filmora/Filmora.zip";
            DownloadFile dwnDiag = new DownloadFile(fourKVD, url, oFile);
            dwnDiag.ShowDialog();
        }
    }
}
