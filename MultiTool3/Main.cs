using System;
using System.Windows.Forms;

namespace MultiTool3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            Text = "MultiTool3 - BETA";

            Home uc = new Home();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void BTN_Schnellzugriff_Click(object sender, EventArgs e)
        {
            Home uc = new Home();
            addUserControl(uc);
            LBL_MainDesc.Text = "Wähle eine Kategorie aus:";
            LBL_MainMain.Text = "Home";
        }

        private void BTN_SysInfSonstiges_Click(object sender, EventArgs e)
        {
            SysInfSonstiges uc = new SysInfSonstiges();
            addUserControl(uc);
            LBL_MainDesc.Text = "Systeminformationen und Tools";
            LBL_MainMain.Text = "SysInf und Sonstiges";
        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            
        }
    }
}
