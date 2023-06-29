namespace Phone_Book
{
    partial class Advanced_Search
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
            this.label1 = new System.Windows.Forms.Label();
            this.StringPanel = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelAND = new System.Windows.Forms.Label();
            this.GroupBoxAdvancedSearch = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.phone_Book_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Phone_Book.Dataset.DataSet1();
            this.bSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBoxChooseSearch = new System.Windows.Forms.ComboBox();
            this.DatePanel = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phone_Book_TableAdapter = new Phone_Book.Dataset.DataSet1TableAdapters.Phone_Book_TableAdapter();
            this.phone_Book_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.tableAdapterManager = new Phone_Book.Dataset.DataSet1TableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StringPanel.SuspendLayout();
            this.GroupBoxAdvancedSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_Book_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.DatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phone_Book_TableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StringPanel
            // 
            this.StringPanel.Controls.Add(this.textBox2);
            this.StringPanel.Controls.Add(this.comboBox2);
            this.StringPanel.Controls.Add(this.textBox1);
            this.StringPanel.Controls.Add(this.labelAND);
            this.StringPanel.Location = new System.Drawing.Point(87, 57);
            this.StringPanel.Name = "StringPanel";
            this.StringPanel.Size = new System.Drawing.Size(388, 41);
            this.StringPanel.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(259, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Starts With",
            "Ends With",
            "Every Where",
            "Between",
            "Not Equal"});
            this.comboBox2.Location = new System.Drawing.Point(0, 9);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(92, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 3;
            // 
            // labelAND
            // 
            this.labelAND.Location = new System.Drawing.Point(223, 9);
            this.labelAND.Name = "labelAND";
            this.labelAND.Size = new System.Drawing.Size(30, 20);
            this.labelAND.TabIndex = 5;
            this.labelAND.Text = "AND";
            this.labelAND.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAND.Visible = false;
            // 
            // GroupBoxAdvancedSearch
            // 
            this.GroupBoxAdvancedSearch.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBoxAdvancedSearch.Controls.Add(this.bSearch);
            this.GroupBoxAdvancedSearch.Controls.Add(this.label4);
            this.GroupBoxAdvancedSearch.Controls.Add(this.ComboBoxChooseSearch);
            this.GroupBoxAdvancedSearch.Controls.Add(this.label1);
            this.GroupBoxAdvancedSearch.Controls.Add(this.DatePanel);
            this.GroupBoxAdvancedSearch.Controls.Add(this.StringPanel);
            this.GroupBoxAdvancedSearch.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxAdvancedSearch.Name = "GroupBoxAdvancedSearch";
            this.GroupBoxAdvancedSearch.Size = new System.Drawing.Size(487, 115);
            this.GroupBoxAdvancedSearch.TabIndex = 0;
            this.GroupBoxAdvancedSearch.TabStop = false;
            this.GroupBoxAdvancedSearch.Text = "Advanced Search";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(505, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 115);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Photo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.phone_Book_TableBindingSource, "Сustomer_Image", true));
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 90);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(214, 30);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 4;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Search Type:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComboBoxChooseSearch
            // 
            this.ComboBoxChooseSearch.FormattingEnabled = true;
            this.ComboBoxChooseSearch.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Date Of Birth"});
            this.ComboBoxChooseSearch.Location = new System.Drawing.Point(87, 30);
            this.ComboBoxChooseSearch.Name = "ComboBoxChooseSearch";
            this.ComboBoxChooseSearch.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxChooseSearch.TabIndex = 0;
            this.ComboBoxChooseSearch.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChooseSearch_SelectedIndexChanged);
            // 
            // DatePanel
            // 
            this.DatePanel.Controls.Add(this.dateTimePicker2);
            this.DatePanel.Controls.Add(this.dateTimePicker1);
            this.DatePanel.Controls.Add(this.label3);
            this.DatePanel.Controls.Add(this.label2);
            this.DatePanel.Location = new System.Drawing.Point(87, 56);
            this.DatePanel.Name = "DatePanel";
            this.DatePanel.Size = new System.Drawing.Size(388, 42);
            this.DatePanel.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(183, 10);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(41, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(151, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "To:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "From:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // phone_Book_TableAdapter
            // 
            this.phone_Book_TableAdapter.ClearBeforeFill = true;
            // 
            // phone_Book_TableDataGridView
            // 
            this.phone_Book_TableDataGridView.AllowUserToAddRows = false;
            this.phone_Book_TableDataGridView.AllowUserToDeleteRows = false;
            this.phone_Book_TableDataGridView.AutoGenerateColumns = false;
            this.phone_Book_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phone_Book_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.phone_Book_TableDataGridView.DataSource = this.phone_Book_TableBindingSource;
            this.phone_Book_TableDataGridView.Location = new System.Drawing.Point(12, 133);
            this.phone_Book_TableDataGridView.Name = "phone_Book_TableDataGridView";
            this.phone_Book_TableDataGridView.ReadOnly = true;
            this.phone_Book_TableDataGridView.Size = new System.Drawing.Size(601, 205);
            this.phone_Book_TableDataGridView.TabIndex = 1;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Phone_Book_TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Phone_Book.Dataset.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "First Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Last Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telephone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telephone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Index";
            this.dataGridViewTextBoxColumn6.HeaderText = "Index";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn7.HeaderText = "Address";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn8.HeaderText = "Comment";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Date_Of_Birth";
            this.dataGridViewTextBoxColumn9.HeaderText = "Date_Of_Birth";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // Advanced_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 350);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBoxAdvancedSearch);
            this.Controls.Add(this.phone_Book_TableDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Advanced_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Advanced_Search_Load);
            this.StringPanel.ResumeLayout(false);
            this.StringPanel.PerformLayout();
            this.GroupBoxAdvancedSearch.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_Book_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.DatePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phone_Book_TableDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel StringPanel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox GroupBoxAdvancedSearch;
        private System.Windows.Forms.ComboBox ComboBoxChooseSearch;
        private System.Windows.Forms.Panel DatePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bSearch;
        private Dataset.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource phone_Book_TableBindingSource;
        private Dataset.DataSet1TableAdapters.Phone_Book_TableAdapter phone_Book_TableAdapter;
        private Dataset.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView phone_Book_TableDataGridView;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelAND;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}