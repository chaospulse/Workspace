namespace Phone_Book
{
    partial class Registration_Form
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label indexLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label commentLabel;
            System.Windows.Forms.Label date_Of_BirthLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration_Form));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bNewData = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bSaveChanges = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bNewData2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bSave2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.phone_Book_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Phone_Book.Dataset.DataSet1();
            this.RepeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.bBrowse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.indexTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.date_Of_BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.phone_Book_TableAdapter = new Phone_Book.Dataset.DataSet1TableAdapters.Phone_Book_TableAdapter();
            this.tableAdapterManager = new Phone_Book.Dataset.DataSet1TableAdapters.TableAdapterManager();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            indexLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            date_Of_BirthLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBoxInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phone_Book_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(39, 24);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 18;
            first_NameLabel.Text = "First Name:";
            first_NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(39, 49);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 20;
            last_NameLabel.Text = "Last Name:";
            last_NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(39, 127);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(61, 13);
            telephoneLabel.TabIndex = 22;
            telephoneLabel.Text = "Telephone:";
            telephoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(65, 153);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 24;
            emailLabel.Text = "Email:";
            emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // indexLabel
            // 
            indexLabel.AutoSize = true;
            indexLabel.Location = new System.Drawing.Point(64, 180);
            indexLabel.Name = "indexLabel";
            indexLabel.Size = new System.Drawing.Size(36, 13);
            indexLabel.TabIndex = 26;
            indexLabel.Text = "Index:";
            indexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(51, 308);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 28;
            addressLabel.Text = "Address:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(45, 231);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(54, 13);
            commentLabel.TabIndex = 30;
            commentLabel.Text = "Comment:";
            commentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // date_Of_BirthLabel
            // 
            date_Of_BirthLabel.AutoSize = true;
            date_Of_BirthLabel.Location = new System.Drawing.Point(29, 205);
            date_Of_BirthLabel.Name = "date_Of_BirthLabel";
            date_Of_BirthLabel.Size = new System.Drawing.Size(71, 13);
            date_Of_BirthLabel.TabIndex = 32;
            date_Of_BirthLabel.Text = "Date Of Birth:";
            date_Of_BirthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(44, 75);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 34;
            passwordLabel.Text = "Password:";
            passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 101);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 13);
            label1.TabIndex = 37;
            label1.Text = "Repeat Password:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.bNewData,
            this.toolStripSeparator2,
            this.bSaveChanges,
            this.toolStripSeparator5,
            this.bNewData2,
            this.toolStripSeparator1,
            this.bSave2,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(497, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 47);
            // 
            // bNewData
            // 
            this.bNewData.Image = ((System.Drawing.Image)(resources.GetObject("bNewData.Image")));
            this.bNewData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bNewData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bNewData.Name = "bNewData";
            this.bNewData.Size = new System.Drawing.Size(94, 44);
            this.bNewData.Text = "New Data";
            this.bNewData.Click += new System.EventHandler(this.bNewData_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // bSaveChanges
            // 
            this.bSaveChanges.Enabled = false;
            this.bSaveChanges.Image = ((System.Drawing.Image)(resources.GetObject("bSaveChanges.Image")));
            this.bSaveChanges.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bSaveChanges.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bSaveChanges.Name = "bSaveChanges";
            this.bSaveChanges.Size = new System.Drawing.Size(116, 44);
            this.bSaveChanges.Text = "Save Changes";
            this.bSaveChanges.Click += new System.EventHandler(this.bSaveChanges_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 47);
            // 
            // bNewData2
            // 
            this.bNewData2.Image = global::Phone_Book.Properties.Resources.register_20_321;
            this.bNewData2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bNewData2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bNewData2.Name = "bNewData2";
            this.bNewData2.Size = new System.Drawing.Size(111, 44);
            this.bNewData2.Text = "New Data (2)";
            this.bNewData2.Click += new System.EventHandler(this.bNewData2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // bSave2
            // 
            this.bSave2.Enabled = false;
            this.bSave2.Image = ((System.Drawing.Image)(resources.GetObject("bSave2.Image")));
            this.bSave2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bSave2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bSave2.Name = "bSave2";
            this.bSave2.Size = new System.Drawing.Size(133, 44);
            this.bSave2.Text = "Save Changes (2)";
            this.bSave2.Click += new System.EventHandler(this.bSave2_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 47);
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.Controls.Add(label1);
            this.groupBoxInformation.Controls.Add(this.RepeatPasswordTextBox);
            this.groupBoxInformation.Controls.Add(passwordLabel);
            this.groupBoxInformation.Controls.Add(this.passwordTextBox);
            this.groupBoxInformation.Controls.Add(this.bBrowse);
            this.groupBoxInformation.Controls.Add(this.pictureBox1);
            this.groupBoxInformation.Controls.Add(first_NameLabel);
            this.groupBoxInformation.Controls.Add(this.first_NameTextBox);
            this.groupBoxInformation.Controls.Add(last_NameLabel);
            this.groupBoxInformation.Controls.Add(this.last_NameTextBox);
            this.groupBoxInformation.Controls.Add(telephoneLabel);
            this.groupBoxInformation.Controls.Add(this.telephoneTextBox);
            this.groupBoxInformation.Controls.Add(emailLabel);
            this.groupBoxInformation.Controls.Add(this.emailTextBox);
            this.groupBoxInformation.Controls.Add(indexLabel);
            this.groupBoxInformation.Controls.Add(this.indexTextBox);
            this.groupBoxInformation.Controls.Add(addressLabel);
            this.groupBoxInformation.Controls.Add(this.addressTextBox);
            this.groupBoxInformation.Controls.Add(commentLabel);
            this.groupBoxInformation.Controls.Add(this.commentTextBox);
            this.groupBoxInformation.Controls.Add(date_Of_BirthLabel);
            this.groupBoxInformation.Controls.Add(this.date_Of_BirthDateTimePicker);
            this.groupBoxInformation.Enabled = false;
            this.groupBoxInformation.Location = new System.Drawing.Point(12, 50);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(529, 591);
            this.groupBoxInformation.TabIndex = 1;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "Information";
            // 
            // phone_Book_TableBindingSource
            // 
            this.phone_Book_TableBindingSource.DataMember = "Phone_Book_Table";
            this.phone_Book_TableBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RepeatPasswordTextBox
            // 
            this.RepeatPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_Book_TableBindingSource, "Password", true));
            this.RepeatPasswordTextBox.Location = new System.Drawing.Point(106, 98);
            this.RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            this.RepeatPasswordTextBox.Size = new System.Drawing.Size(274, 20);
            this.RepeatPasswordTextBox.TabIndex = 36;
            this.RepeatPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_Book_TableBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(106, 72);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(274, 20);
            this.passwordTextBox.TabIndex = 35;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // bBrowse
            // 
            this.bBrowse.Location = new System.Drawing.Point(106, 502);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(193, 23);
            this.bBrowse.TabIndex = 34;
            this.bBrowse.Text = "Select Image";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(106, 331);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 165);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_Book_TableBindingSource, "First Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(106, 21);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(274, 20);
            this.first_NameTextBox.TabIndex = 19;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_Book_TableBindingSource, "Last Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(106, 46);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(274, 20);
            this.last_NameTextBox.TabIndex = 21;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_Book_TableBindingSource, "Telephone", true));
            this.telephoneTextBox.Location = new System.Drawing.Point(106, 124);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(274, 20);
            this.telephoneTextBox.TabIndex = 23;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_Book_TableBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(106, 150);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(274, 20);
            this.emailTextBox.TabIndex = 25;
            // 
            // indexTextBox
            // 
            this.indexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_Book_TableBindingSource, "Index", true));
            this.indexTextBox.Location = new System.Drawing.Point(106, 176);
            this.indexTextBox.Name = "indexTextBox";
            this.indexTextBox.Size = new System.Drawing.Size(274, 20);
            this.indexTextBox.TabIndex = 27;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_Book_TableBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(106, 305);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(274, 20);
            this.addressTextBox.TabIndex = 29;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_Book_TableBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(106, 228);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(274, 71);
            this.commentTextBox.TabIndex = 31;
            // 
            // date_Of_BirthDateTimePicker
            // 
            this.date_Of_BirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.phone_Book_TableBindingSource, "Date_Of_Birth", true));
            this.date_Of_BirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Of_BirthDateTimePicker.Location = new System.Drawing.Point(106, 202);
            this.date_Of_BirthDateTimePicker.Name = "date_Of_BirthDateTimePicker";
            this.date_Of_BirthDateTimePicker.Size = new System.Drawing.Size(274, 20);
            this.date_Of_BirthDateTimePicker.TabIndex = 33;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // phone_Book_TableAdapter
            // 
            this.phone_Book_TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Phone_Book_TableAdapter = this.phone_Book_TableAdapter;
            this.tableAdapterManager.UpdateOrder = Phone_Book.Dataset.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 585);
            this.Controls.Add(this.groupBoxInformation);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "Registration_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.Registration_Form_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phone_Book_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton bNewData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bSaveChanges;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Dataset.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource phone_Book_TableBindingSource;
        private Dataset.DataSet1TableAdapters.Phone_Book_TableAdapter phone_Book_TableAdapter;
        private Dataset.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox indexTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.DateTimePicker date_Of_BirthDateTimePicker;
        private System.Windows.Forms.ToolStripButton bNewData2;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox RepeatPasswordTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton bSave2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}