using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SOHATS
{
    public partial class Hastaİslemleri : Form
    {
        public Hastaİslemleri()
        {
            InitializeComponent();
            this.drCodeCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.previousProcessCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.polyclinicCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ProcessCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dispatchdateTimePicker.Value = DateTime.Now;

        }
        private void Hastaİslemleri_Load(object sender, EventArgs e)
        {
            processToDo = new List<string>();

            sql.HastaİslemleriProcessesData();

            foreach (var item in processToDo)
            {
                ProcessCmbBox.Items.Add(item);
            }
        }

        SqlConnectionClass sql = new SqlConnectionClass();
        DataTable table = new DataTable();

        public static List<string> previousProcesses = new List<string>();
        public static List<string> processToDo = new List<string>();
        public static List<string> doctorCode = new List<string>();
        int sum = 0;

        #region Properties of Items
        public static string FileNo { get; set; }
        public static string PatientName { get; set; }
        public static string PatientSurname { get; set; }
        public static string InstutionName { get; set; }
        public static DateTime DispatchDate { get; set; }
        public static string PreviousProcess { get; set; }
        public static DateTime PreviousProcessDate { get; set; }
        public static string ProcessToDo { get; set; }
        public static string UnitFee { get; set; }
        public static string Polyclinic { get; set; }
        public static string QueueNumber { get; set; }
        public static string DoctorCode { get; set; }
        public static string Unit { get; set; }
        public static string Hour { get; set; }
        public static string DoctorName { get; set; }
        public static string TotalFee { get; set; }
        public static Boolean Discharged { get; set; }
        #endregion

        public void PropertiesToItemsData()
        {
            fileNoTxtBox.Text = FileNo;
            patientName.Text = PatientName;
            patientSurname.Text = PatientSurname;
            institutionName.Text = InstutionName;
            if (DispatchDate > Convert.ToDateTime("1/1/0001 12:00:00 AM"))
            {
                dispatchdateTimePicker.Value = DispatchDate;
            } 
            foreach (var item in previousProcesses)
            {
                previousProcessCmbBox.Items.Add(item);                                
            }
        }
        public void ItemsToPropertiesData()
        {
            FileNo = fileNoTxtBox.Text;
            PatientName = patientName.Text;
            PatientSurname = patientSurname.Text;
            InstutionName = institutionName.Text;
            DispatchDate = dispatchdateTimePicker.Value;
            PreviousProcess = previousProcessCmbBox.Text;
            Polyclinic = polyclinicCmbBox.Text;
            Unit = unitPriceTxtBox.Text;
            UnitFee = unitPriceTxtBox.Text;
            DoctorCode = drCodeCmbBox.Text;
            TotalFee = totalFeeLbl.Text;
            
        }    
        public void AddToDataGrid()
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = polyclinicCmbBox.Text;
            dataGridView1.Rows[n].Cells[1].Value = queueNumberTxtBox.Text;
            dataGridView1.Rows[n].Cells[2].Value = dispatchdateTimePicker.Value.ToShortTimeString();
            dataGridView1.Rows[n].Cells[3].Value = ProcessCmbBox.Text;
            dataGridView1.Rows[n].Cells[4].Value = drCodeCmbBox.Text;
            dataGridView1.Rows[n].Cells[5].Value = UnitNmrcUpDwn.Text;
            dataGridView1.Rows[n].Cells[6].Value = unitPriceTxtBox.Text;
            Polyclinic = polyclinicCmbBox.Text;
            QueueNumber = queueNumberTxtBox.Text;
            Hour = dispatchdateTimePicker.Value.ToShortTimeString();
            ProcessToDo = ProcessCmbBox.Text;
            DoctorCode = drCodeCmbBox.Text;
            Unit = UnitNmrcUpDwn.Text;            
            UnitFee = unitPriceTxtBox.Text;
        }
        public void PrintData()
        {
            if (sql != null)
            {
                TotalFee = totalFeeLbl.Text;

                sql.HastaİslemleriPrintData();
                DataTable dt = new DataTable();
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Surname", typeof(string));
                dt.Columns.Add("Polyclinic", typeof(string));
                dt.Columns.Add("QueueNumber", typeof(string));
                dt.Columns.Add("Hour", typeof(string));
                dt.Columns.Add("ProcessTodo", typeof(string));
                dt.Columns.Add("DrCode", typeof(string));
                dt.Columns.Add("Unit", typeof(string));
                dt.Columns.Add("UnitFee", typeof(string));
                dt.Columns.Add("TotalFee", typeof(string));
                dt.Columns.Add("DoctorName", typeof(string));
                dt.Columns.Add("DispatchDate", typeof(string));

                dt.Rows.Add(PatientName, PatientSurname, Polyclinic, QueueNumber, Hour, ProcessToDo, DoctorCode,
                    Unit ,UnitFee,TotalFee, DoctorName, DispatchDate.ToShortDateString());

                PrintReport pReport = new PrintReport();
                pReport.Database.Tables["PrintTable"].SetDataSource(dt);
                CrystalReport creport = new CrystalReport();
                creport.crystalReportViewer1.ReportSource = pReport;
                creport.Show();
            }
        }
        public void Sum()
        {

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value) * Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
            }
            totalFeeLbl.Text = sum.ToString();
            TotalFee = sum.ToString();
            MessageBox.Show(TotalFee);

        }
        private void dischargePatientBtn_Click(object sender, EventArgs e)
        {
            //DispatchDate = dispatchdateTimePicker.Value;
            if (FileNo != null && FileNo != "" && Polyclinic != null && Polyclinic != "") 
            {
                Taburcu taburcu = new Taburcu();
                taburcu.Show();
            }
            else
            {
                MessageBox.Show("Taburcu etmek için dosya numarası belirtmeniz  ve ekleme işlemini yapmanız gerekiyor");
            }
            
        }
        private void printPreviewBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("Yazdırılacak bir şey bulunamadı!");

            }
            else
            {
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == DialogResult.OK)
                {

                    CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument =
                new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                    reportDocument.Load(Application.StartupPath + "\\PrintReport.rpt");
                    reportDocument.PrintOptions.PrinterName = printDialog.PrinterSettings.PrinterName;
                    PrintData();
                }
            }
            
        }
        private void patientInfoBtn_Click(object sender, EventArgs e)
        {
            if (FileNo != "" && FileNo != null)
            {
                HastaBilgileri hBilgileri = new HastaBilgileri();
                hBilgileri.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bilgileri gösterilecek bir hasta bulunmamaktadır.");
            }
            
        }
        private void choseDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                Polyclinic = dataGridView1.SelectedRows[rowIndex].Cells[0].Value.ToString();
                Hour = dataGridView1.SelectedRows[rowIndex].Cells[2].Value.ToString();
                DispatchDate = dispatchdateTimePicker.Value;
                sql.HastaİslemleriDeleteData();
                dataGridView1.Rows.RemoveAt(rowIndex);
            }
            catch (Exception except)
            {

                MessageBox.Show("İşlem Yapılamadı.\nTüm verilerin girildiğinden emin olun.");

            }
            
        }
        private void findBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            ResetUtilities resetUtilities = new ResetUtilities();
            resetUtilities.ResetAllControls(this);

            previousProcesses = new List<string>();
            previousProcessCmbBox.Items.Clear();
            if (fileNoTxtBox.Text == "")
            {
                DosyaBul dosyaBul = new DosyaBul();
                dosyaBul.Show();
                this.Close();
            }
            else
            {
                FileNo = fileNoTxtBox.Text;
                sql.HastaİslemleriBringDataFromHastaTable();
                sql.HastaİslemleriBringDataFromSevkTable();
                PropertiesToItemsData();
            }
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            ItemsToPropertiesData();
            if (QueueNumber != "20")
            {
                if (FileNo != null && Polyclinic != null && QueueNumber != null && ProcessToDo != null && DoctorCode != "" && Unit != null && UnitFee != null)
                {
                    AddToDataGrid();
                    sql.SevkInsertData();

                    Sum();
                }

                else
                {
                    MessageBox.Show("Eklenecek bilgileri kontrol ediniz.\nGerekli bilgileri doldurmayıp boş kutucuk bırakmış olabilirsiniz.");
                }
            }
            else
            {

                MessageBox.Show("Bu polikinliğin sırası bu gün için dolmuş.\nBaşka bir gün deneyin");

            }
        }
        private void goBtn_Click(object sender, EventArgs e)
        {
            if (previousProcessCmbBox.Text == "")
            {
                MessageBox.Show("Önceden yapılmış bir işlem bulunmamaktadır");
            }
            else
            {
                sql.HastaİslemleriDataGrid();

                if (Discharged == true)
                {
                    MessageBox.Show("Bu hasta taburcu olmuştur.");
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = Polyclinic;
                    dataGridView1.Rows[n].Cells[1].Value = QueueNumber;
                    dataGridView1.Rows[n].Cells[2].Value = Hour;
                    dataGridView1.Rows[n].Cells[3].Value = ProcessToDo;
                    dataGridView1.Rows[n].Cells[4].Value = DoctorCode;
                    dataGridView1.Rows[n].Cells[5].Value = Unit;
                    dataGridView1.Rows[n].Cells[6].Value = UnitFee;
                    Sum();
                }
                else
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = Polyclinic;
                    dataGridView1.Rows[n].Cells[1].Value = QueueNumber;
                    dataGridView1.Rows[n].Cells[2].Value = Hour;
                    dataGridView1.Rows[n].Cells[3].Value = ProcessToDo;
                    dataGridView1.Rows[n].Cells[4].Value = DoctorCode;
                    dataGridView1.Rows[n].Cells[5].Value = Unit;
                    dataGridView1.Rows[n].Cells[6].Value = UnitFee;

                    Sum();
                }
            }
        }
        private void newBtn_Click(object sender, EventArgs e)
        {

            HastaBilgileri hBilgileri = new HastaBilgileri();
            hBilgileri.Show();
            this.Close();
        }
        private void printBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("Yazdırılacak bir şey bulunamadı!");

            }
            else
            {
                PrintData();
            }
        }
        private void previousProcessCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreviousProcess = previousProcessCmbBox.Text;
            PreviousProcessDate = Convert.ToDateTime(previousProcessCmbBox.Text);
        }
        private void polyclinicCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            doctorCode = new List<string>();
            drCodeCmbBox.Items.Clear();
            DispatchDate = dispatchdateTimePicker.Value;
            Polyclinic = polyclinicCmbBox.Text;

            if (FileNo != null && FileNo != "")
            {
                sql.HastaİslemleriQueueNumber();
                sql.HastaİslemleriDoctorCode();
            }
            if (QueueNumber == "" || QueueNumber == null)
            {
                queueNumberTxtBox.Text = "1";

            }
            else
            {
                queueNumberTxtBox.Text = (int.Parse(QueueNumber) + 1).ToString();
            }
            
            foreach (var item in doctorCode)
            {
                drCodeCmbBox.Items.Add(item);
            }
        }
        private void ProcessCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProcessToDo = ProcessCmbBox.Text;
            sql.HastaİslemleriFeeData();
            unitPriceTxtBox.Text = UnitFee;
        }
        private void fileNoTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
   
    }
}
