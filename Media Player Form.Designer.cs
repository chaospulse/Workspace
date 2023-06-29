namespace Phone_Book
{
    partial class Media_Player_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Media_Player_Form));
            this.bLoadFile = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.bPause = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bLoadFile
            // 
            this.bLoadFile.Location = new System.Drawing.Point(165, 3);
            this.bLoadFile.Name = "bLoadFile";
            this.bLoadFile.Size = new System.Drawing.Size(75, 38);
            this.bLoadFile.TabIndex = 1;
            this.bLoadFile.Text = "Load File";
            this.bLoadFile.UseVisualStyleBackColor = true;
            this.bLoadFile.Click += new System.EventHandler(this.bLoadFile_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(3, 3);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 38);
            this.bStart.TabIndex = 2;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bPause
            // 
            this.bPause.Location = new System.Drawing.Point(84, 4);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(75, 38);
            this.bPause.TabIndex = 3;
            this.bPause.Text = "Pause";
            this.bPause.UseVisualStyleBackColor = true;
            this.bPause.Click += new System.EventHandler(this.bPause_Click);
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(246, 3);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(75, 38);
            this.bReset.TabIndex = 4;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(815, 498);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bLoadFile);
            this.panel1.Controls.Add(this.bPause);
            this.panel1.Controls.Add(this.bReset);
            this.panel1.Controls.Add(this.bStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 451);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 47);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(735, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(654, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "Fullscreen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Media_Player_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 498);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Media_Player_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media_Player_Form";
            this.Load += new System.EventHandler(this.Media_Player_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button bLoadFile;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bPause;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}