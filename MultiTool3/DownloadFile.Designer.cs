namespace MultiTool3
{
    partial class DownloadFile
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
            this.BTN_StartDwn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBX_DownloadPfad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_DwnName = new System.Windows.Forms.Label();
            this.BTN_SavePath = new System.Windows.Forms.Button();
            this.TBX_FileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PRB_DownloadStatus = new System.Windows.Forms.ProgressBar();
            this.LBL_DownloadStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_StartDwn
            // 
            this.BTN_StartDwn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_StartDwn.Location = new System.Drawing.Point(0, 181);
            this.BTN_StartDwn.Name = "BTN_StartDwn";
            this.BTN_StartDwn.Size = new System.Drawing.Size(452, 30);
            this.BTN_StartDwn.TabIndex = 0;
            this.BTN_StartDwn.Text = "Datei herunterladen";
            this.BTN_StartDwn.UseVisualStyleBackColor = true;
            this.BTN_StartDwn.Click += new System.EventHandler(this.BTN_StartDwn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bitte überprüfe alle Einstellungen auf richtigkeit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Download Pfad:";
            // 
            // TBX_DownloadPfad
            // 
            this.TBX_DownloadPfad.Location = new System.Drawing.Point(97, 99);
            this.TBX_DownloadPfad.Name = "TBX_DownloadPfad";
            this.TBX_DownloadPfad.Size = new System.Drawing.Size(266, 20);
            this.TBX_DownloadPfad.TabIndex = 3;
            this.TBX_DownloadPfad.Text = "Fehler beim abrufen des Pfades.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // LBL_DwnName
            // 
            this.LBL_DwnName.AutoSize = true;
            this.LBL_DwnName.Location = new System.Drawing.Point(96, 80);
            this.LBL_DwnName.Name = "LBL_DwnName";
            this.LBL_DwnName.Size = new System.Drawing.Size(166, 13);
            this.LBL_DwnName.TabIndex = 5;
            this.LBL_DwnName.Text = "Fehler beim Abrufen des Namens.";
            // 
            // BTN_SavePath
            // 
            this.BTN_SavePath.Location = new System.Drawing.Point(369, 98);
            this.BTN_SavePath.Name = "BTN_SavePath";
            this.BTN_SavePath.Size = new System.Drawing.Size(75, 21);
            this.BTN_SavePath.TabIndex = 6;
            this.BTN_SavePath.Text = "Speichern";
            this.BTN_SavePath.UseVisualStyleBackColor = true;
            this.BTN_SavePath.Click += new System.EventHandler(this.BTN_SavePath_Click);
            // 
            // TBX_FileName
            // 
            this.TBX_FileName.Location = new System.Drawing.Point(97, 125);
            this.TBX_FileName.Name = "TBX_FileName";
            this.TBX_FileName.Size = new System.Drawing.Size(266, 20);
            this.TBX_FileName.TabIndex = 7;
            this.TBX_FileName.Text = "Fehler beim abrufen des Dateinamens.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dateiname:";
            // 
            // PRB_DownloadStatus
            // 
            this.PRB_DownloadStatus.BackColor = System.Drawing.Color.White;
            this.PRB_DownloadStatus.Location = new System.Drawing.Point(0, 0);
            this.PRB_DownloadStatus.Name = "PRB_DownloadStatus";
            this.PRB_DownloadStatus.Size = new System.Drawing.Size(452, 20);
            this.PRB_DownloadStatus.TabIndex = 9;
            // 
            // LBL_DownloadStatus
            // 
            this.LBL_DownloadStatus.AutoSize = true;
            this.LBL_DownloadStatus.BackColor = System.Drawing.Color.White;
            this.LBL_DownloadStatus.Location = new System.Drawing.Point(0, 21);
            this.LBL_DownloadStatus.Name = "LBL_DownloadStatus";
            this.LBL_DownloadStatus.Size = new System.Drawing.Size(106, 13);
            this.LBL_DownloadStatus.TabIndex = 10;
            this.LBL_DownloadStatus.Text = "Warte auf Aufgabe...";
            // 
            // DownloadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 211);
            this.Controls.Add(this.LBL_DownloadStatus);
            this.Controls.Add(this.PRB_DownloadStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBX_FileName);
            this.Controls.Add(this.BTN_SavePath);
            this.Controls.Add(this.LBL_DwnName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBX_DownloadPfad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_StartDwn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DownloadFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datei herunterladen...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_StartDwn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBX_DownloadPfad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_DwnName;
        private System.Windows.Forms.Button BTN_SavePath;
        private System.Windows.Forms.TextBox TBX_FileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar PRB_DownloadStatus;
        private System.Windows.Forms.Label LBL_DownloadStatus;
    }
}