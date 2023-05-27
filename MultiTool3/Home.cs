using System;
using System.Windows.Forms;

namespace MultiTool3
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer2.Controls.Clear();
            panelContainer2.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void BTN_CrackedProgramme_Click(object sender, EventArgs e)
        {
            HOME_CrackedProgramme uc = new HOME_CrackedProgramme();
            addUserControl(uc);
        }
    }
}
