namespace SOHATS
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exitBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.queryBtn = new System.Windows.Forms.Button();
            this.allRadioBtn = new System.Windows.Forms.RadioButton();
            this.NotDschargeRadioBtn = new System.Windows.Forms.RadioButton();
            this.dischargeRadioBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateOfStart = new System.Windows.Forms.DateTimePicker();
            this.dateOfEnd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 274);
            this.dataGridView1.TabIndex = 27;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(708, 9);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(94, 38);
            this.exitBtn.TabIndex = 26;
            this.exitBtn.Text = "Çıkış";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(598, 9);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(94, 38);
            this.printBtn.TabIndex = 25;
            this.printBtn.Text = "Yazdır";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(498, 9);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(94, 38);
            this.ClearBtn.TabIndex = 24;
            this.ClearBtn.Text = "Temizle";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // queryBtn
            // 
            this.queryBtn.Location = new System.Drawing.Point(398, 9);
            this.queryBtn.Name = "queryBtn";
            this.queryBtn.Size = new System.Drawing.Size(94, 38);
            this.queryBtn.TabIndex = 23;
            this.queryBtn.Text = "Sorgula";
            this.queryBtn.UseVisualStyleBackColor = true;
            this.queryBtn.Click += new System.EventHandler(this.queryBtn_Click);
            // 
            // allRadioBtn
            // 
            this.allRadioBtn.AutoSize = true;
            this.allRadioBtn.Location = new System.Drawing.Point(285, 53);
            this.allRadioBtn.Name = "allRadioBtn";
            this.allRadioBtn.Size = new System.Drawing.Size(52, 17);
            this.allRadioBtn.TabIndex = 20;
            this.allRadioBtn.TabStop = true;
            this.allRadioBtn.Text = "Hepsi";
            this.allRadioBtn.UseVisualStyleBackColor = true;
            // 
            // NotDschargeRadioBtn
            // 
            this.NotDschargeRadioBtn.AutoSize = true;
            this.NotDschargeRadioBtn.Location = new System.Drawing.Point(285, 30);
            this.NotDschargeRadioBtn.Name = "NotDschargeRadioBtn";
            this.NotDschargeRadioBtn.Size = new System.Drawing.Size(105, 17);
            this.NotDschargeRadioBtn.TabIndex = 19;
            this.NotDschargeRadioBtn.TabStop = true;
            this.NotDschargeRadioBtn.Text = "Taburcu olmamış";
            this.NotDschargeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // dischargeRadioBtn
            // 
            this.dischargeRadioBtn.AutoSize = true;
            this.dischargeRadioBtn.Location = new System.Drawing.Point(285, 7);
            this.dischargeRadioBtn.Name = "dischargeRadioBtn";
            this.dischargeRadioBtn.Size = new System.Drawing.Size(97, 17);
            this.dischargeRadioBtn.TabIndex = 18;
            this.dischargeRadioBtn.TabStop = true;
            this.dischargeRadioBtn.Text = "Taburcu Olmuş";
            this.dischargeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // dateOfStart
            // 
            this.dateOfStart.Location = new System.Drawing.Point(100, 6);
            this.dateOfStart.Name = "dateOfStart";
            this.dateOfStart.Size = new System.Drawing.Size(181, 20);
            this.dateOfStart.TabIndex = 28;
            // 
            // dateOfEnd
            // 
            this.dateOfEnd.Location = new System.Drawing.Point(99, 42);
            this.dateOfEnd.Name = "dateOfEnd";
            this.dateOfEnd.Size = new System.Drawing.Size(180, 20);
            this.dateOfEnd.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 386);
            this.Controls.Add(this.dateOfEnd);
            this.Controls.Add(this.dateOfStart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.queryBtn);
            this.Controls.Add(this.allRadioBtn);
            this.Controls.Add(this.NotDschargeRadioBtn);
            this.Controls.Add(this.dischargeRadioBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SağlıkOcağıHastaTakipSistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button queryBtn;
        private System.Windows.Forms.RadioButton allRadioBtn;
        private System.Windows.Forms.RadioButton NotDschargeRadioBtn;
        private System.Windows.Forms.RadioButton dischargeRadioBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateOfStart;
        private System.Windows.Forms.DateTimePicker dateOfEnd;
    }
}