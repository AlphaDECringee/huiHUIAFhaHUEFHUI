namespace MultiTool3
{
    partial class HOME_CrackedProgramme
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_4KVD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Filmora9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_4KVD
            // 
            this.BTN_4KVD.Location = new System.Drawing.Point(113, 0);
            this.BTN_4KVD.Name = "BTN_4KVD";
            this.BTN_4KVD.Size = new System.Drawing.Size(75, 23);
            this.BTN_4KVD.TabIndex = 0;
            this.BTN_4KVD.Text = "Download";
            this.BTN_4KVD.UseVisualStyleBackColor = true;
            this.BTN_4KVD.Click += new System.EventHandler(this.BTN_4KVD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "4K Video Downloader";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filmora 9";
            // 
            // BTN_Filmora9
            // 
            this.BTN_Filmora9.Location = new System.Drawing.Point(113, 23);
            this.BTN_Filmora9.Name = "BTN_Filmora9";
            this.BTN_Filmora9.Size = new System.Drawing.Size(75, 23);
            this.BTN_Filmora9.TabIndex = 3;
            this.BTN_Filmora9.Text = "Download";
            this.BTN_Filmora9.UseVisualStyleBackColor = true;
            this.BTN_Filmora9.Click += new System.EventHandler(this.BTN_Filmora9_Click);
            // 
            // HOME_CrackedProgramme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_Filmora9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_4KVD);
            this.Name = "HOME_CrackedProgramme";
            this.Size = new System.Drawing.Size(688, 314);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_4KVD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Filmora9;
    }
}
