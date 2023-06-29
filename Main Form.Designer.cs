namespace Phone_Book
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.process1 = new System.Diagnostics.Process();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.phoneBookTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Phone_Book.Dataset.DataSet1();
            this.phone_Book_TableAdapter = new Phone_Book.Dataset.DataSet1TableAdapters.Phone_Book_TableAdapter();
            this.b_Logout = new System.Windows.Forms.Button();
            this.bSettings = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bMedia = new System.Windows.Forms.Button();
            this.bCalculator = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.bUsers = new System.Windows.Forms.Button();
            this.bCalendar = new System.Windows.Forms.Button();
            this.bRegisterData = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.b_Logout);
            this.panel1.Controls.Add(this.bSettings);
            this.panel1.Controls.Add(this.bExit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bMedia);
            this.panel1.Controls.Add(this.bCalculator);
            this.panel1.Controls.Add(this.bSearch);
            this.panel1.Controls.Add(this.bUsers);
            this.panel1.Controls.Add(this.bCalendar);
            this.panel1.Controls.Add(this.bRegisterData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 78);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelUserName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(91, 78);
            this.panel2.TabIndex = 9;
            // 
            // labelUserName
            // 
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookTableBindingSource, "First Name", true));
            this.labelUserName.Location = new System.Drawing.Point(3, 56);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(85, 12);
            this.labelUserName.TabIndex = 4;
            this.labelUserName.Text = "User Name";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneBookTableBindingSource
            // 
            this.phoneBookTableBindingSource.DataMember = "Phone_Book_Table";
            this.phoneBookTableBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phone_Book_TableAdapter
            // 
            this.phone_Book_TableAdapter.ClearBeforeFill = true;
            // 
            // b_Logout
            // 
            this.b_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Logout.BackColor = System.Drawing.Color.LemonChiffon;
            this.b_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Logout.Image = global::Phone_Book.Properties.Resources.logout__1_;
            this.b_Logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.b_Logout.Location = new System.Drawing.Point(921, 9);
            this.b_Logout.Name = "b_Logout";
            this.b_Logout.Size = new System.Drawing.Size(92, 59);
            this.b_Logout.TabIndex = 12;
            this.b_Logout.Text = "Logout";
            this.b_Logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_Logout.UseVisualStyleBackColor = false;
            this.b_Logout.Click += new System.EventHandler(this.b_Logout_Click);
            // 
            // bSettings
            // 
            this.bSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSettings.BackColor = System.Drawing.Color.LemonChiffon;
            this.bSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSettings.Image = global::Phone_Book.Properties.Resources.settings_122_32;
            this.bSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bSettings.Location = new System.Drawing.Point(1019, 9);
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(92, 59);
            this.bSettings.TabIndex = 11;
            this.bSettings.Text = "Settings";
            this.bSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bSettings.UseVisualStyleBackColor = false;
            // 
            // bExit
            // 
            this.bExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bExit.BackColor = System.Drawing.Color.LemonChiffon;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExit.Image = global::Phone_Book.Properties.Resources.exit_22_32;
            this.bExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bExit.Location = new System.Drawing.Point(1117, 9);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(92, 59);
            this.bExit.TabIndex = 10;
            this.bExit.Text = "Exit";
            this.bExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(15, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // bMedia
            // 
            this.bMedia.BackColor = System.Drawing.Color.LemonChiffon;
            this.bMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bMedia.Image = global::Phone_Book.Properties.Resources.media_color_1_player_321;
            this.bMedia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bMedia.Location = new System.Drawing.Point(587, 10);
            this.bMedia.Name = "bMedia";
            this.bMedia.Size = new System.Drawing.Size(92, 59);
            this.bMedia.TabIndex = 8;
            this.bMedia.Text = "Media";
            this.bMedia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bMedia.UseVisualStyleBackColor = false;
            this.bMedia.Click += new System.EventHandler(this.bMediaPlayer_Click);
            // 
            // bCalculator
            // 
            this.bCalculator.BackColor = System.Drawing.Color.LemonChiffon;
            this.bCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCalculator.Image = global::Phone_Book.Properties.Resources.calculator_141_32;
            this.bCalculator.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bCalculator.Location = new System.Drawing.Point(489, 10);
            this.bCalculator.Name = "bCalculator";
            this.bCalculator.Size = new System.Drawing.Size(92, 59);
            this.bCalculator.TabIndex = 7;
            this.bCalculator.Text = "Calculator";
            this.bCalculator.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bCalculator.UseVisualStyleBackColor = false;
            // 
            // bSearch
            // 
            this.bSearch.BackColor = System.Drawing.Color.LemonChiffon;
            this.bSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSearch.Image = global::Phone_Book.Properties.Resources.search_699_32;
            this.bSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bSearch.Location = new System.Drawing.Point(195, 9);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(92, 59);
            this.bSearch.TabIndex = 4;
            this.bSearch.Text = "Search";
            this.bSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bSearch.UseVisualStyleBackColor = false;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // bUsers
            // 
            this.bUsers.BackColor = System.Drawing.Color.LemonChiffon;
            this.bUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bUsers.Image = global::Phone_Book.Properties.Resources.imgonline_com_ua_Resize_WlHGMn3yiOix;
            this.bUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bUsers.Location = new System.Drawing.Point(293, 10);
            this.bUsers.Name = "bUsers";
            this.bUsers.Size = new System.Drawing.Size(92, 59);
            this.bUsers.TabIndex = 5;
            this.bUsers.Text = "Users";
            this.bUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bUsers.UseVisualStyleBackColor = false;
            this.bUsers.Click += new System.EventHandler(this.bUsers_Click);
            // 
            // bCalendar
            // 
            this.bCalendar.BackColor = System.Drawing.Color.LemonChiffon;
            this.bCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCalendar.Image = global::Phone_Book.Properties.Resources.calendar_341_32;
            this.bCalendar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bCalendar.Location = new System.Drawing.Point(391, 10);
            this.bCalendar.Name = "bCalendar";
            this.bCalendar.Size = new System.Drawing.Size(92, 59);
            this.bCalendar.TabIndex = 6;
            this.bCalendar.Text = "Calendar";
            this.bCalendar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bCalendar.UseVisualStyleBackColor = false;
            this.bCalendar.Click += new System.EventHandler(this.bCalendar_Click);
            // 
            // bRegisterData
            // 
            this.bRegisterData.BackColor = System.Drawing.Color.LemonChiffon;
            this.bRegisterData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRegisterData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bRegisterData.Image = global::Phone_Book.Properties.Resources.register_20_32;
            this.bRegisterData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bRegisterData.Location = new System.Drawing.Point(97, 9);
            this.bRegisterData.Name = "bRegisterData";
            this.bRegisterData.Size = new System.Drawing.Size(92, 59);
            this.bRegisterData.TabIndex = 3;
            this.bRegisterData.Text = "New User";
            this.bRegisterData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bRegisterData.UseVisualStyleBackColor = false;
            this.bRegisterData.Click += new System.EventHandler(this.bRegisterData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1217, 598);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bRegisterData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bMedia;
        private System.Windows.Forms.Button bCalculator;
        private System.Windows.Forms.Button bCalendar;
        private System.Windows.Forms.Button bUsers;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bSettings;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.BindingSource phoneBookTableBindingSource;
        private Dataset.DataSet1 dataSet1;
        private Dataset.DataSet1TableAdapters.Phone_Book_TableAdapter phone_Book_TableAdapter;
        private System.Windows.Forms.Button b_Logout;
    }
}

