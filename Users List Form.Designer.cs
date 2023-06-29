namespace Phone_Book
{
    partial class Users_List
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
            this.dataSet1 = new Phone_Book.Dataset.DataSet1();
            this.phone_Book_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phone_Book_TableAdapter = new Phone_Book.Dataset.DataSet1TableAdapters.Phone_Book_TableAdapter();
            this.tableAdapterManager = new Phone_Book.Dataset.DataSet1TableAdapters.TableAdapterManager();
            this.phone_Book_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bEdit = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_Book_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_Book_TableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phone_Book_TableBindingSource
            // 
            this.phone_Book_TableBindingSource.DataMember = "Phone_Book_Table";
            this.phone_Book_TableBindingSource.DataSource = this.dataSet1;
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
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn9});
            this.phone_Book_TableDataGridView.DataSource = this.phone_Book_TableBindingSource;
            this.phone_Book_TableDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.phone_Book_TableDataGridView.Location = new System.Drawing.Point(0, 0);
            this.phone_Book_TableDataGridView.Name = "phone_Book_TableDataGridView";
            this.phone_Book_TableDataGridView.ReadOnly = true;
            this.phone_Book_TableDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.phone_Book_TableDataGridView.Size = new System.Drawing.Size(687, 409);
            this.phone_Book_TableDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 45;
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Сustomer_Image";
            this.dataGridViewImageColumn1.HeaderText = "Сustomer_Image";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Date_Of_Birth";
            this.dataGridViewTextBoxColumn9.HeaderText = "Date_Of_Birth";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(12, 418);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(75, 23);
            this.bEdit.TabIndex = 3;
            this.bEdit.Text = "Edit List";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(600, 418);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 4;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // Users_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.phone_Book_TableDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Users_List";
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Users_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_Book_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_Book_TableDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Dataset.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource phone_Book_TableBindingSource;
        private Dataset.DataSet1TableAdapters.Phone_Book_TableAdapter phone_Book_TableAdapter;
        private Dataset.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView phone_Book_TableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bClose;
    }
}