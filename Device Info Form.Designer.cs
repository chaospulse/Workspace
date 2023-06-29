using System.ComponentModel;

namespace Phone_Book
{
    partial class Device_Info_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.bDeviceInfo = new System.Windows.Forms.Button();
            this.textBox_DeviceName = new System.Windows.Forms.TextBox();
            this.bLoginUser = new System.Windows.Forms.Button();
            this.textBox_LoginUser = new System.Windows.Forms.TextBox();
            this.bCPU = new System.Windows.Forms.Button();
            this.textBox_CPU = new System.Windows.Forms.TextBox();
            this.bResolution = new System.Windows.Forms.Button();
            this.textBox_Resolution = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bDeviceInfo
            // 
            this.bDeviceInfo.Location = new System.Drawing.Point(12, 21);
            this.bDeviceInfo.Name = "bDeviceInfo";
            this.bDeviceInfo.Size = new System.Drawing.Size(117, 47);
            this.bDeviceInfo.TabIndex = 0;
            this.bDeviceInfo.Text = "Get Device Info";
            this.bDeviceInfo.UseVisualStyleBackColor = true;
            this.bDeviceInfo.Click += new System.EventHandler(this.bDeviceInfo_Click);
            // 
            // textBox_DeviceName
            // 
            this.textBox_DeviceName.Location = new System.Drawing.Point(135, 21);
            this.textBox_DeviceName.Multiline = true;
            this.textBox_DeviceName.Name = "textBox_DeviceName";
            this.textBox_DeviceName.Size = new System.Drawing.Size(239, 47);
            this.textBox_DeviceName.TabIndex = 1;
            // 
            // bLoginUser
            // 
            this.bLoginUser.Location = new System.Drawing.Point(12, 74);
            this.bLoginUser.Name = "bLoginUser";
            this.bLoginUser.Size = new System.Drawing.Size(117, 47);
            this.bLoginUser.TabIndex = 2;
            this.bLoginUser.Text = "Get Login User";
            this.bLoginUser.UseVisualStyleBackColor = true;
            this.bLoginUser.Click += new System.EventHandler(this.bLoginUser_Click);
            // 
            // textBox_LoginUser
            // 
            this.textBox_LoginUser.Location = new System.Drawing.Point(135, 74);
            this.textBox_LoginUser.Multiline = true;
            this.textBox_LoginUser.Name = "textBox_LoginUser";
            this.textBox_LoginUser.Size = new System.Drawing.Size(239, 47);
            this.textBox_LoginUser.TabIndex = 3;
            // 
            // bCPU
            // 
            this.bCPU.Location = new System.Drawing.Point(12, 127);
            this.bCPU.Name = "bCPU";
            this.bCPU.Size = new System.Drawing.Size(117, 47);
            this.bCPU.TabIndex = 4;
            this.bCPU.Text = "Get CPU Count";
            this.bCPU.UseVisualStyleBackColor = true;
            this.bCPU.Click += new System.EventHandler(this.bCPU_Click);
            // 
            // textBox_CPU
            // 
            this.textBox_CPU.Location = new System.Drawing.Point(135, 127);
            this.textBox_CPU.Multiline = true;
            this.textBox_CPU.Name = "textBox_CPU";
            this.textBox_CPU.Size = new System.Drawing.Size(239, 47);
            this.textBox_CPU.TabIndex = 5;
            // 
            // bResolution
            // 
            this.bResolution.Location = new System.Drawing.Point(12, 180);
            this.bResolution.Name = "bResolution";
            this.bResolution.Size = new System.Drawing.Size(117, 47);
            this.bResolution.TabIndex = 6;
            this.bResolution.Text = "Get Resolution";
            this.bResolution.UseVisualStyleBackColor = true;
            this.bResolution.Click += new System.EventHandler(this.bResolution_Click);
            // 
            // textBox_Resolution
            // 
            this.textBox_Resolution.Location = new System.Drawing.Point(135, 180);
            this.textBox_Resolution.Multiline = true;
            this.textBox_Resolution.Name = "textBox_Resolution";
            this.textBox_Resolution.Size = new System.Drawing.Size(239, 47);
            this.textBox_Resolution.TabIndex = 7;
            // 
            // Device_Info_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 263);
            this.Controls.Add(this.textBox_Resolution);
            this.Controls.Add(this.bResolution);
            this.Controls.Add(this.textBox_CPU);
            this.Controls.Add(this.bCPU);
            this.Controls.Add(this.textBox_LoginUser);
            this.Controls.Add(this.bLoginUser);
            this.Controls.Add(this.textBox_DeviceName);
            this.Controls.Add(this.bDeviceInfo);
            this.Name = "Device_Info_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Device_Info_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button bDeviceInfo;
        private System.Windows.Forms.TextBox textBox_DeviceName;

        #endregion

        private System.Windows.Forms.Button bLoginUser;
        private System.Windows.Forms.TextBox textBox_LoginUser;
        private System.Windows.Forms.Button bCPU;
        private System.Windows.Forms.TextBox textBox_CPU;
        private System.Windows.Forms.Button bResolution;
        private System.Windows.Forms.TextBox textBox_Resolution;
    }
}