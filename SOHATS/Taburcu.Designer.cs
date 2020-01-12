namespace SOHATS
{
    partial class Taburcu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fileNumberTxtBox = new System.Windows.Forms.TextBox();
            this.totalFeeTxtBox = new System.Windows.Forms.TextBox();
            this.paymentRateCmbBox = new System.Windows.Forms.ComboBox();
            this.dispatchdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.exitdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sevk Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Çıkış Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ödeme Şekli";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Toplam Tutar";
            // 
            // fileNumberTxtBox
            // 
            this.fileNumberTxtBox.Location = new System.Drawing.Point(93, 13);
            this.fileNumberTxtBox.Name = "fileNumberTxtBox";
            this.fileNumberTxtBox.ReadOnly = true;
            this.fileNumberTxtBox.Size = new System.Drawing.Size(181, 20);
            this.fileNumberTxtBox.TabIndex = 5;
            // 
            // totalFeeTxtBox
            // 
            this.totalFeeTxtBox.Location = new System.Drawing.Point(93, 124);
            this.totalFeeTxtBox.MaxLength = 20;
            this.totalFeeTxtBox.Name = "totalFeeTxtBox";
            this.totalFeeTxtBox.Size = new System.Drawing.Size(181, 20);
            this.totalFeeTxtBox.TabIndex = 6;
            this.totalFeeTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.totalFeeTxtBox_KeyPress);
            // 
            // paymentRateCmbBox
            // 
            this.paymentRateCmbBox.FormattingEnabled = true;
            this.paymentRateCmbBox.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı - taksitli",
            "Kredi Kartı - tek çekim",
            "Çek",
            "Senet"});
            this.paymentRateCmbBox.Location = new System.Drawing.Point(93, 98);
            this.paymentRateCmbBox.MaxLength = 30;
            this.paymentRateCmbBox.Name = "paymentRateCmbBox";
            this.paymentRateCmbBox.Size = new System.Drawing.Size(181, 21);
            this.paymentRateCmbBox.TabIndex = 9;
            // 
            // dispatchdateTimePicker
            // 
            this.dispatchdateTimePicker.Enabled = false;
            this.dispatchdateTimePicker.Location = new System.Drawing.Point(93, 42);
            this.dispatchdateTimePicker.Name = "dispatchdateTimePicker";
            this.dispatchdateTimePicker.Size = new System.Drawing.Size(181, 20);
            this.dispatchdateTimePicker.TabIndex = 10;
            // 
            // exitdateTimePicker
            // 
            this.exitdateTimePicker.Enabled = false;
            this.exitdateTimePicker.Location = new System.Drawing.Point(93, 69);
            this.exitdateTimePicker.Name = "exitdateTimePicker";
            this.exitdateTimePicker.Size = new System.Drawing.Size(181, 20);
            this.exitdateTimePicker.TabIndex = 11;
            this.exitdateTimePicker.Value = new System.DateTime(2019, 12, 27, 20, 57, 27, 0);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(12, 179);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Vazgeç";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(199, 179);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Kaydet";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Taburcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 226);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.exitdateTimePicker);
            this.Controls.Add(this.dispatchdateTimePicker);
            this.Controls.Add(this.paymentRateCmbBox);
            this.Controls.Add(this.totalFeeTxtBox);
            this.Controls.Add(this.fileNumberTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Taburcu";
            this.Text = "Taburcu";
            this.Load += new System.EventHandler(this.Taburcu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fileNumberTxtBox;
        private System.Windows.Forms.TextBox totalFeeTxtBox;
        private System.Windows.Forms.ComboBox paymentRateCmbBox;
        private System.Windows.Forms.DateTimePicker dispatchdateTimePicker;
        private System.Windows.Forms.DateTimePicker exitdateTimePicker;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}