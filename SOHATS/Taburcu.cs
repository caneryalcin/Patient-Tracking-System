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
    public partial class Taburcu : Form
    {
        SqlConnectionClass sql = new SqlConnectionClass();
        public static DateTime dispatchDate;
        public Taburcu()
        {
            InitializeComponent();
            this.paymentRateCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        #region Properties of Items
        public static string FileNo { get; set; }
        public static DateTime DisPatchDate { get; set; }
        public static DateTime ExitDate { get; set; }
        public static string PaymentRate { get; set; }
        public static string TotalFee { get; set; }

        public static bool DisCharged { get; set; }

        #endregion

        public void PropertiesToItemsData()
        {

            fileNumberTxtBox.Text = FileNo;
            dispatchdateTimePicker.Value = DisPatchDate;
            exitdateTimePicker.Value = ExitDate;
            paymentRateCmbBox.Text = PaymentRate;
            totalFeeTxtBox.Text = TotalFee;

        }

        public void ItemsToPropertiesData()
        {

            FileNo = fileNumberTxtBox.Text;
            DisPatchDate = dispatchdateTimePicker.Value;
            ExitDate = exitdateTimePicker.Value;
            PaymentRate = paymentRateCmbBox.Text;
            TotalFee = totalFeeTxtBox.Text;
            DisCharged = true;

        }

        private void Taburcu_Load(object sender, EventArgs e)
        {
            FileNo = fileNumberTxtBox.Text;
            fileNumberTxtBox.Text = Hastaİslemleri.FileNo;
            dispatchdateTimePicker.Value = Hastaİslemleri.DispatchDate;
            if (ExitDate == Convert.ToDateTime("1/1/0001 12:00:00 AM"))
            { 
                exitdateTimePicker.Value = Hastaİslemleri.DispatchDate; 
            }
            else
            {
                exitdateTimePicker.Value = Hastaİslemleri.PreviousProcessDate;
            }          
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            ItemsToPropertiesData();
            if (PaymentRate == null && TotalFee == null)
            {

                MessageBox.Show("Lütfen Boş kutucukları doldurun.");

            }
            else{
            if (sql != null) 
            { 
                sql.TaburcuInsertOrUpdateData();
                sql.SekvUpdate();
            }
            this.Close();}  
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void totalFeeTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

      
        
    }
}
