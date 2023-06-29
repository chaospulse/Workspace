namespace Phone_Book
{
    partial class Calendar_Form
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
            this.label_year = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_month = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_year
            // 
            this.label_year.BackColor = System.Drawing.Color.Transparent;
            this.label_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_year.Location = new System.Drawing.Point(250, 103);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(61, 23);
            this.label_year.TabIndex = 1;
            this.label_year.Text = "2023";
            // 
            // label_date
            // 
            this.label_date.BackColor = System.Drawing.Color.Transparent;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_date.Location = new System.Drawing.Point(68, 136);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(259, 59);
            this.label_date.TabIndex = 3;
            this.label_date.Text = "23, Friday";
            this.label_date.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_month
            // 
            this.label_month.BackColor = System.Drawing.Color.Transparent;
            this.label_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_month.Location = new System.Drawing.Point(83, 103);
            this.label_month.Name = "label_month";
            this.label_month.Size = new System.Drawing.Size(79, 23);
            this.label_month.TabIndex = 4;
            this.label_month.Text = "March";
            this.label_month.Click += new System.EventHandler(this.label_month_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_time
            // 
            this.label_time.BackColor = System.Drawing.Color.Transparent;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_time.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label_time.Location = new System.Drawing.Point(66, 195);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(258, 59);
            this.label_time.TabIndex = 5;
            this.label_time.Text = "10:10:10";
            this.label_time.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Calendar_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Phone_Book.Properties.Resources.istockphoto_1279719215_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(393, 318);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_month);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_year);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Calendar_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Calendar_Form_FormClosed);
            this.Load += new System.EventHandler(this.Calendar_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_month;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_time;
    }
}