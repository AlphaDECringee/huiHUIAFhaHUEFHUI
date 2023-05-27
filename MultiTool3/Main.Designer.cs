namespace MultiTool3
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.LBL_MainMain = new System.Windows.Forms.Label();
            this.BTN_Schnellzugriff = new System.Windows.Forms.Button();
            this.BTN_SysInfSonstiges = new System.Windows.Forms.Button();
            this.LBL_MainDesc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBL_MainStatus = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_MainMain
            // 
            this.LBL_MainMain.AutoSize = true;
            this.LBL_MainMain.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_MainMain.Location = new System.Drawing.Point(25, 19);
            this.LBL_MainMain.Name = "LBL_MainMain";
            this.LBL_MainMain.Size = new System.Drawing.Size(111, 45);
            this.LBL_MainMain.TabIndex = 0;
            this.LBL_MainMain.Text = "Home";
            // 
            // BTN_Schnellzugriff
            // 
            this.BTN_Schnellzugriff.Location = new System.Drawing.Point(668, 28);
            this.BTN_Schnellzugriff.Name = "BTN_Schnellzugriff";
            this.BTN_Schnellzugriff.Size = new System.Drawing.Size(128, 45);
            this.BTN_Schnellzugriff.TabIndex = 1;
            this.BTN_Schnellzugriff.Text = "Home";
            this.BTN_Schnellzugriff.UseVisualStyleBackColor = true;
            this.BTN_Schnellzugriff.Click += new System.EventHandler(this.BTN_Schnellzugriff_Click);
            // 
            // BTN_SysInfSonstiges
            // 
            this.BTN_SysInfSonstiges.Location = new System.Drawing.Point(798, 28);
            this.BTN_SysInfSonstiges.Name = "BTN_SysInfSonstiges";
            this.BTN_SysInfSonstiges.Size = new System.Drawing.Size(128, 45);
            this.BTN_SysInfSonstiges.TabIndex = 2;
            this.BTN_SysInfSonstiges.Text = "SysInf und Sonstiges";
            this.BTN_SysInfSonstiges.UseVisualStyleBackColor = true;
            this.BTN_SysInfSonstiges.Click += new System.EventHandler(this.BTN_SysInfSonstiges_Click);
            // 
            // LBL_MainDesc
            // 
            this.LBL_MainDesc.AutoSize = true;
            this.LBL_MainDesc.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_MainDesc.Location = new System.Drawing.Point(29, 67);
            this.LBL_MainDesc.Name = "LBL_MainDesc";
            this.LBL_MainDesc.Size = new System.Drawing.Size(187, 21);
            this.LBL_MainDesc.TabIndex = 4;
            this.LBL_MainDesc.Text = "Wähle eine Kategorie aus:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.LBL_MainStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 478);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 22);
            this.panel1.TabIndex = 5;
            // 
            // LBL_MainStatus
            // 
            this.LBL_MainStatus.AutoSize = true;
            this.LBL_MainStatus.Location = new System.Drawing.Point(3, 5);
            this.LBL_MainStatus.Name = "LBL_MainStatus";
            this.LBL_MainStatus.Size = new System.Drawing.Size(34, 13);
            this.LBL_MainStatus.TabIndex = 6;
            this.LBL_MainStatus.Text = "Bereit";
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(12, 102);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(926, 361);
            this.panelContainer.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LBL_MainDesc);
            this.Controls.Add(this.BTN_SysInfSonstiges);
            this.Controls.Add(this.BTN_Schnellzugriff);
            this.Controls.Add(this.LBL_MainMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_MainMain;
        private System.Windows.Forms.Button BTN_Schnellzugriff;
        private System.Windows.Forms.Button BTN_SysInfSonstiges;
        private System.Windows.Forms.Label LBL_MainDesc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_MainStatus;
        private System.Windows.Forms.Panel panelContainer;
    }
}