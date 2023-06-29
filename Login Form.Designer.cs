namespace Phone_Book
{
    partial class Login_Form
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
            this.UserNameComboBox = new System.Windows.Forms.ComboBox();
            this.phoneBookTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Phone_Book.Dataset.DataSet1();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.phone_Book_TableAdapter = new Phone_Book.Dataset.DataSet1TableAdapters.Phone_Book_TableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bRegistrate = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Phone_Book.Dataset.DataSet1TableAdapters.TableAdapterManager();
            this.first_NameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameComboBox
            // 
            this.UserNameComboBox.DataSource = this.phoneBookTableBindingSource;
            this.UserNameComboBox.DisplayMember = "First Name";
            this.UserNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserNameComboBox.FormattingEnabled = true;
            this.UserNameComboBox.Location = new System.Drawing.Point(85, 135);
            this.UserNameComboBox.Name = "UserNameComboBox";
            this.UserNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.UserNameComboBox.TabIndex = 0;
            this.UserNameComboBox.ValueMember = "ID";
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
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(85, 165);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(121, 20);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(104, 191);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(102, 17);
            this.ShowPasswordCheckBox.TabIndex = 4;
            this.ShowPasswordCheckBox.Text = "Show Password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(15, 229);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(75, 37);
            this.bLogin.TabIndex = 5;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(186, 229);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 37);
            this.bExit.TabIndex = 6;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // phone_Book_TableAdapter
            // 
            this.phone_Book_TableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.phoneBookTableBindingSource, "Сustomer_Image", true));
            this.pictureBox1.Location = new System.Drawing.Point(85, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 112);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // bRegistrate
            // 
            this.bRegistrate.Location = new System.Drawing.Point(100, 229);
            this.bRegistrate.Name = "bRegistrate";
            this.bRegistrate.Size = new System.Drawing.Size(75, 37);
            this.bRegistrate.TabIndex = 8;
            this.bRegistrate.Text = "New User";
            this.bRegistrate.UseVisualStyleBackColor = true;
            this.bRegistrate.Click += new System.EventHandler(this.bRegistrate_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Phone_Book_TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Phone_Book.Dataset.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // first_NameLabel1
            // 
            this.first_NameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookTableBindingSource, "First Name", true));
            this.first_NameLabel1.Location = new System.Drawing.Point(12, 317);
            this.first_NameLabel1.Name = "first_NameLabel1";
            this.first_NameLabel1.Size = new System.Drawing.Size(100, 23);
            this.first_NameLabel1.TabIndex = 10;
            this.first_NameLabel1.Text = "label3";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 280);
            this.ControlBox = false;
            this.Controls.Add(this.first_NameLabel1);
            this.Controls.Add(this.bRegistrate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.BindingSource phoneBookTableBindingSource;
        private Dataset.DataSet1 dataSet1;
        private Dataset.DataSet1TableAdapters.Phone_Book_TableAdapter phone_Book_TableAdapter;
        private System.Windows.Forms.Button bRegistrate;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox UserNameComboBox;
        private Dataset.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label first_NameLabel1;
    }
}