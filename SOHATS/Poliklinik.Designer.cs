namespace SOHATS
{
    partial class Poliklinik
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
            this.explanationRchBox = new System.Windows.Forms.RichTextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.polyclinicNameTxtBox = new System.Windows.Forms.TextBox();
            this.situationChckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poliklinik Adı";
            // 
            // explanationRchBox
            // 
            this.explanationRchBox.Location = new System.Drawing.Point(12, 75);
            this.explanationRchBox.MaxLength = 255;
            this.explanationRchBox.Name = "explanationRchBox";
            this.explanationRchBox.Size = new System.Drawing.Size(260, 96);
            this.explanationRchBox.TabIndex = 2;
            this.explanationRchBox.Text = "";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(12, 188);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 47);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "Güncelle";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(93, 188);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 47);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Sil";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(197, 188);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 47);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Çıkış";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // polyclinicNameTxtBox
            // 
            this.polyclinicNameTxtBox.Location = new System.Drawing.Point(84, 6);
            this.polyclinicNameTxtBox.MaxLength = 50;
            this.polyclinicNameTxtBox.Name = "polyclinicNameTxtBox";
            this.polyclinicNameTxtBox.Size = new System.Drawing.Size(188, 20);
            this.polyclinicNameTxtBox.TabIndex = 6;
            // 
            // situationChckBox
            // 
            this.situationChckBox.AutoSize = true;
            this.situationChckBox.Location = new System.Drawing.Point(84, 32);
            this.situationChckBox.Name = "situationChckBox";
            this.situationChckBox.Size = new System.Drawing.Size(130, 17);
            this.situationChckBox.TabIndex = 7;
            this.situationChckBox.Text = "Geçerli / Geçerli Değil";
            this.situationChckBox.UseVisualStyleBackColor = true;
            // 
            // Poliklinik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.situationChckBox);
            this.Controls.Add(this.polyclinicNameTxtBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.explanationRchBox);
            this.Controls.Add(this.label1);
            this.Name = "Poliklinik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poliklinik";
            this.Load += new System.EventHandler(this.Poliklinik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox explanationRchBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox polyclinicNameTxtBox;
        private System.Windows.Forms.CheckBox situationChckBox;
    }
}