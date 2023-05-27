using System;
using System.Drawing;
using System.Windows.Forms;

namespace MultiTool3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            wb_label.Parent = pictureBox1;
            wb_label.BackColor = Color.Transparent;
            wb2_label.Parent = pictureBox1;
            wb2_label.BackColor = Color.Transparent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 7;
            if(panel2.Width >= 700)
            {
                timer1.Stop();
                Main main = new Main();
                main.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void wb_label_Click(object sender, EventArgs e)
        {

        }
    }
}
