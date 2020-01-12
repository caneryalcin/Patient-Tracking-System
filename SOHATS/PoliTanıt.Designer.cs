namespace SOHATS
{
    partial class PoliTanıt
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
            this.polyclinicCmbBox = new System.Windows.Forms.ComboBox();
            this.validUnvalidChckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Polikinlik Adi";
            // 
            // polyclinicCmbBox
            // 
            this.polyclinicCmbBox.FormattingEnabled = true;
            this.polyclinicCmbBox.Items.AddRange(new object[] {
            "Polikinlik 1",
            "Polikinlik 2",
            "Polikinlik 3",
            "Polikinlik 4"});
            this.polyclinicCmbBox.Location = new System.Drawing.Point(88, 21);
            this.polyclinicCmbBox.Name = "polyclinicCmbBox";
            this.polyclinicCmbBox.Size = new System.Drawing.Size(121, 21);
            this.polyclinicCmbBox.TabIndex = 1;
            this.polyclinicCmbBox.SelectedIndexChanged += new System.EventHandler(this.polyclinicCmbBox_SelectedIndexChanged);
            // 
            // validUnvalidChckBox
            // 
            this.validUnvalidChckBox.AutoSize = true;
            this.validUnvalidChckBox.Location = new System.Drawing.Point(88, 59);
            this.validUnvalidChckBox.Name = "validUnvalidChckBox";
            this.validUnvalidChckBox.Size = new System.Drawing.Size(105, 17);
            this.validUnvalidChckBox.TabIndex = 2;
            this.validUnvalidChckBox.Text = "Geçerli/Geçersiz";
            this.validUnvalidChckBox.UseVisualStyleBackColor = true;
            // 
            // PoliTanıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(245, 107);
            this.Controls.Add(this.validUnvalidChckBox);
            this.Controls.Add(this.polyclinicCmbBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PoliTanıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PoliTanıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox validUnvalidChckBox;
        public System.Windows.Forms.ComboBox polyclinicCmbBox;
    }
}