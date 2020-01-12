namespace SOHATS
{
    partial class KulTanit
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
            this.defineUserCmbBox = new System.Windows.Forms.ComboBox();
            this.addNewUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // defineUserCmbBox
            // 
            this.defineUserCmbBox.FormattingEnabled = true;
            this.defineUserCmbBox.Location = new System.Drawing.Point(113, 38);
            this.defineUserCmbBox.Name = "defineUserCmbBox";
            this.defineUserCmbBox.Size = new System.Drawing.Size(121, 21);
            this.defineUserCmbBox.TabIndex = 2;
            this.defineUserCmbBox.SelectedIndexChanged += new System.EventHandler(this.defineUserCmbBox_SelectedIndexChanged);
            // 
            // addNewUser
            // 
            this.addNewUser.Location = new System.Drawing.Point(113, 80);
            this.addNewUser.Name = "addNewUser";
            this.addNewUser.Size = new System.Drawing.Size(117, 23);
            this.addNewUser.TabIndex = 3;
            this.addNewUser.Text = "Yeni Kullanıcı Ekle";
            this.addNewUser.UseVisualStyleBackColor = true;
            this.addNewUser.Click += new System.EventHandler(this.addNewUser_Click);
            // 
            // KulTanit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(275, 157);
            this.Controls.Add(this.addNewUser);
            this.Controls.Add(this.defineUserCmbBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KulTanit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KulTanit";
            this.Load += new System.EventHandler(this.KulTanit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox defineUserCmbBox;
        private System.Windows.Forms.Button addNewUser;
    }
}