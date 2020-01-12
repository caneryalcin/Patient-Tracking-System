namespace SOHATS
{
    partial class DosyaBul
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchingTxtBox = new System.Windows.Forms.TextBox();
            this.findBtn = new System.Windows.Forms.Button();
            this.andChckBox = new System.Windows.Forms.CheckBox();
            this.surNameTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.criterionCmbBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.searchingTxtBox);
            this.panel1.Controls.Add(this.findBtn);
            this.panel1.Controls.Add(this.andChckBox);
            this.panel1.Controls.Add(this.surNameTxtBox);
            this.panel1.Controls.Add(this.nameTxtBox);
            this.panel1.Controls.Add(this.criterionCmbBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 56);
            this.panel1.TabIndex = 0;
            // 
            // searchingTxtBox
            // 
            this.searchingTxtBox.Location = new System.Drawing.Point(213, 7);
            this.searchingTxtBox.Name = "searchingTxtBox";
            this.searchingTxtBox.Size = new System.Drawing.Size(250, 20);
            this.searchingTxtBox.TabIndex = 6;
            this.searchingTxtBox.Visible = false;
            this.searchingTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchingTxtBox_KeyPress);
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(514, 9);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(75, 23);
            this.findBtn.TabIndex = 5;
            this.findBtn.Text = "Bul";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // andChckBox
            // 
            this.andChckBox.AutoSize = true;
            this.andChckBox.Location = new System.Drawing.Point(319, 8);
            this.andChckBox.Name = "andChckBox";
            this.andChckBox.Size = new System.Drawing.Size(38, 17);
            this.andChckBox.TabIndex = 4;
            this.andChckBox.Text = "ve";
            this.andChckBox.UseVisualStyleBackColor = true;
            // 
            // surNameTxtBox
            // 
            this.surNameTxtBox.Location = new System.Drawing.Point(363, 7);
            this.surNameTxtBox.Name = "surNameTxtBox";
            this.surNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.surNameTxtBox.TabIndex = 3;
            this.surNameTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surNameTxtBox_KeyPress);
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(213, 7);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.nameTxtBox.TabIndex = 2;
            this.nameTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTxtBox_KeyPress);
            // 
            // criterionCmbBox
            // 
            this.criterionCmbBox.FormattingEnabled = true;
            this.criterionCmbBox.Items.AddRange(new object[] {
            "Hasta Adı Soyadı",
            "Kimlik No",
            "Kurum Sicil No",
            "Dosya No"});
            this.criterionCmbBox.Location = new System.Drawing.Point(86, 6);
            this.criterionCmbBox.Name = "criterionCmbBox";
            this.criterionCmbBox.Size = new System.Drawing.Size(121, 21);
            this.criterionCmbBox.TabIndex = 1;
            this.criterionCmbBox.SelectedIndexChanged += new System.EventHandler(this.criterionCmbBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama Kriterleri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 344);
            this.dataGridView1.TabIndex = 1;
            // 
            // DosyaBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 395);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "DosyaBul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DosyaBul";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.CheckBox andChckBox;
        private System.Windows.Forms.TextBox surNameTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.ComboBox criterionCmbBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchingTxtBox;
    }
}