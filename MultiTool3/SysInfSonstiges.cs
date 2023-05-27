using System;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiTool3
{
    public partial class SysInfSonstiges : UserControl
    {
        public SysInfSonstiges()
        {
            InitializeComponent();
            GetInformations();
        }

        private async void GetInformations()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
            ManagementObjectCollection collection = searcher.Get();
            foreach (ManagementObject obj in collection)
            {
                string osName = obj["Caption"].ToString();
                LBL_OSName.Text = osName;
            }
            //
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher("SELECT Version FROM Win32_OperatingSystem");
            ManagementObjectCollection collection2 = searcher2.Get();
            foreach (ManagementObject obj in collection2)
            {
                string osVersion = obj["Version"].ToString();
                LBL_OSVersion.Text = osVersion;
            }
            //
            string sysName = Environment.MachineName;
            LBL_SysName.Text = sysName;
            //
            ManagementObjectSearcher searcher3 = new ManagementObjectSearcher("SELECT Manufacturer FROM Win32_BaseBoard");
            ManagementObjectCollection collection3 = searcher3.Get();
            foreach (ManagementObject obj in collection3)
            {
                string mbMarke = obj["Manufacturer"].ToString();
                LBL_MBManufactor.Text = mbMarke;
            }
            //
            string systemType = Environment.Is64BitOperatingSystem ? "x64-basierter PC" : "x86-basierter PC";
            LBL_SysType.Text = systemType;
            //
            ManagementObjectSearcher searcher4 = new ManagementObjectSearcher("SELECT Product FROM Win32_BaseBoard");
            ManagementObjectCollection collection4 = searcher4.Get();
            foreach (ManagementObject obj in collection4)
            {
                string baseBoardProduct = obj["Product"].ToString();
                LBL_MBProdukt.Text = baseBoardProduct;
            }
            //
            string username = Environment.UserName;
            string domain = Environment.UserDomainName;
            string formattedUsername = domain + "\\" + username;
            LBL_Username.Text = formattedUsername;
            //
            string processorInfo = await Task.Run(() => GetProcessorInfo());
            LBL_Processor.Text = processorInfo;
            //
            ManagementObjectSearcher searcher5 = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            ManagementObjectCollection collection5 = searcher5.Get();
            ulong totalMemoryBytes = 0;
            foreach (ManagementObject obj in collection5)
            {
                ulong capacityBytes = Convert.ToUInt64(obj["Capacity"]);
                totalMemoryBytes += capacityBytes;
            }
            ulong totalMemoryGigabytes = totalMemoryBytes / 1024 / 1024 / 1024;
            LBL_RAM.Text = totalMemoryGigabytes + " GB";
            //
            TimeZoneInfo timeZone = TimeZoneInfo.Local;
            string timeZoneName = timeZone.DisplayName;
            LBL_Zeitzone.Text = timeZoneName;
        }

        private string GetProcessorInfo()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            ManagementObjectCollection collection = searcher.Get();
            foreach (ManagementObject obj in collection)
            {
                string processorName = obj["Name"].ToString();
                string processorMaxClockSpeed = obj["MaxClockSpeed"].ToString();
                string processorCores = obj["NumberOfCores"].ToString();
                string processorThreads = obj["NumberOfLogicalProcessors"].ToString();

                string processorInfo = string.Format("{0}, {1} MHz, {2} Kern(e), {3} logische(r) Prozessor(en)",
                    processorName, processorMaxClockSpeed, processorCores, processorThreads);
                return processorInfo;
            }
            return "";
        }
    }
}
