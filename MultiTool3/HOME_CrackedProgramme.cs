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

        private void BTN_IDM_Click(object sender, EventArgs e)
        {
            string oFile = "InternetDownloadManager.zip";
            string fourKVD = "Internet Download Manager";
            string url = "https://github.com/AlphaDECringee/softwarerepository/releases/download/idm/InternetDownloadManager.zip";
            DownloadFile dwnDiag = new DownloadFile(fourKVD, url, oFile);
            dwnDiag.ShowDialog();
        }

        private void BTN_iObitASCP_Click(object sender, EventArgs e)
        {
            string oFile = "Advanced_SystemCare_Pro_15.2.0.201.zip";
            string fourKVD = "iObit Advanced SystemCare Pro 15.2.0.201";
            string url = "https://github.com/AlphaDECringee/softwarerepository/releases/download/ASCP/Advanced_SystemCare_Pro_15.2.0.201.zip";
            DownloadFile dwnDiag = new DownloadFile(fourKVD, url, oFile);
            dwnDiag.ShowDialog();
        }

        private void BTN_iObitDBP_Click(object sender, EventArgs e)
        {
            string oFile = "IObit_Driver_Booster_Pro_9.2.0.178.zip";
            string fourKVD = "iObit Driver Booster Pro 15.2.0.201";
            string url = "https://github.com/AlphaDECringee/softwarerepository/releases/download/DBP/IObit_Driver_Booster_Pro_9.2.0.178.zip";
            DownloadFile dwnDiag = new DownloadFile(fourKVD, url, oFile);
            dwnDiag.ShowDialog();
        }

        private void BTN_iObitMFP_Click(object sender, EventArgs e)
        {
            string oFile = "IObit_Malware_Fighter_Pro_9.1.0.553.zip";
            string fourKVD = "iObit Malware Fighter Pro 9.1.0.553";
            string url = "https://github.com/AlphaDECringee/softwarerepository/releases/download/MFP/IObit_Malware_Fighter_Pro_9.1.0.553.zip";
            DownloadFile dwnDiag = new DownloadFile(fourKVD, url, oFile);
            dwnDiag.ShowDialog();
        }

        private void BTN_iObitSDP_Click(object sender, EventArgs e)
        {
            string oFile = "IObit_Smart_Defrag_Pro_8.0.0.136.zip";
            string fourKVD = "iObit Smart Defrag Pro 8.0.0.136";
            string url = "https://github.com/AlphaDECringee/softwarerepository/releases/download/SDP/IObit_Smart_Defrag_Pro_8.0.0.136.zip";
            DownloadFile dwnDiag = new DownloadFile(fourKVD, url, oFile);
            dwnDiag.ShowDialog();
        }

        private void BTN_iObitUP_Click(object sender, EventArgs e)
        {
            string oFile = "IObit_Uninstaller_Pro_11.3.0.4_Multilingual.zip";
            string fourKVD = "iObit Uninstaller Pro 11.3.0.4";
            string url = "https://github.com/AlphaDECringee/softwarerepository/releases/download/UP/IObit_Uninstaller_Pro_11.3.0.4_Multilingual.zip";
            DownloadFile dwnDiag = new DownloadFile(fourKVD, url, oFile);
            dwnDiag.ShowDialog();
        }

        private void BTN_WinRAR_Click(object sender, EventArgs e)
        {
            string oFile = "WinRAR_rarreg.key.zip";
            string fourKVD = "WinRAR";
            string url = "https://github.com/AlphaDECringee/softwarerepository/releases/download/WRARRARREG/WinRAR_rarreg.key.zip";
            DownloadFile dwnDiag = new DownloadFile(fourKVD, url, oFile);
            dwnDiag.ShowDialog();
        }
    }
}
