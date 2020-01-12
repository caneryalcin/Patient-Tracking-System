using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOHATS
{
    public partial class Form1 : Form
    {
        SqlConnectionClass sql = new SqlConnectionClass();

        #region Properties of Items
        public static string StartDate { get; set; }
        public static string EndDate { get; set; }
        public static Boolean AllPatiens { get; set; }
        public static Boolean DischargePatiens { get; set; }
        public static Boolean NotDischargePatiens { get; set; }
        public static string FileNo { get; set; }
        public static string PatientName { get; set; }
        public static string PatientSurname { get; set; }
        public static string DispatchDate { get; set; }
        public static string Polyclinic { get; set; }
        public static string QueueNumber { get; set; }
        public static string Hour { get; set; }
        public static string ProcessToDo { get; set; }
        public static string DoctorCode { get; set; }
        public static string DoctorName { get; set; }
        public static string DoctorSurname { get; set; }
        public static string Unit { get; set; }
        public static string UnitFee { get; set; }
        public static string TotalFee { get; set; }
        public static string Discharged { get; set; }
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        public void QueryData()
        {
            if (allRadioBtn.Checked == true)
            {
                dischargeRadioBtn.Checked = false;
                NotDschargeRadioBtn.Checked = false;
            }
            else if (dischargeRadioBtn.Checked == true)
            {
                allRadioBtn.Checked = false;
                NotDschargeRadioBtn.Checked = false;
            }
            else if (NotDschargeRadioBtn.Checked == true)
            {
                dischargeRadioBtn.Checked = false;
                allRadioBtn.Checked = false;
            }
            NotDischargePatiens = NotDschargeRadioBtn.Checked;
            DischargePatiens = dischargeRadioBtn.Checked;
            AllPatiens = allRadioBtn.Checked;
            StartDate = dateOfStart.Value.ToShortDateString();
            EndDate = dateOfEnd.Value.ToShortDateString();
        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            QueryData();
            dataGridView1.DataSource = sql.Form1loadData();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            ResetUtilities resetUtilities = new ResetUtilities();
            resetUtilities.ResetAllControls(this);
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 1 || dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Yazdırılacak bir şey bulunamadı!");
            }
            else
            {
                reportform1 form1printdata = new reportform1();
                form1printdata.SetDataSource(sql.Form1loadData());
                CrystalReport creport = new CrystalReport();
                creport.crystalReportViewer1.ReportSource = form1printdata;
                creport.Show();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateOfStart.Value = DateTime.Now;
            dateOfEnd.Value = DateTime.Now;
        }
    }


}

