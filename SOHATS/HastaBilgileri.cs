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
    public partial class HastaBilgileri : Form
    {

        SqlConnectionClass sql = new SqlConnectionClass();
        public HastaBilgileri()
        {
            InitializeComponent();
            this.bloodGroupCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.genderCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.maritalStatusCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void HastaBilgileri_Load(object sender, EventArgs e)
        {

            if (Hastaİslemleri.FileNo != "" && Hastaİslemleri.FileNo != null)
            {
                sql.HastaBilgileriBringData();
                PropertiesToItemsData();
            }
        }

        #region Properties Of Items

        public static string FileNo { get; set; }
        public static string Identity { get; set; }
        public static string PatientName { get; set; }
        public static string PatientSurName { get; set; }
        public static string BirthPlace { get; set; }
        public static DateTime BirthDay { get; set; }
        public static string FatherName { get; set; }
        public static string MotherName { get; set; }
        public static string Gender { get; set; }
        public static string BloodGroup { get; set; }
        public static string MaritalStatus { get; set; }
        public static string Address { get; set; }
        public static string PhoneNumber { get; set; }
        public static string InstutionRegisteryNumber { get; set; }
        public static string InstutionName { get; set; }
        public static string CloseRelativePhoneNumber { get; set; }
        public static string CloseRelativeInstutionRegisteryNumber { get; set; }
        public static string CloseRelativeInstutionName { get; set; }
        #endregion 
        public void PropertiesToItemsData()
        {
            fileNoTxtBox.Text = Hastaİslemleri.FileNo;
            identityNoTxtBox.Text = Identity;
            nameTxtBox.Text = PatientName;
            surnameTxtBox.Text = PatientSurName;
            birthPlaceTxtBox.Text = BirthPlace;
            birtdayDtTmPckr.Value = BirthDay;
            fatherNameTxtBox.Text = FatherName;
            motherNameTxtBox.Text = MotherName;
            genderCmbBox.Text = Gender;
            bloodGroupCmbBox.Text = BloodGroup;
            maritalStatusCmbBox.Text = MaritalStatus;
            addressTxtBox.Text = Address;
            phoneNumberTxtBox.Text = PhoneNumber;
            institutionRegisteryNumberTxtBox.Text = InstutionRegisteryNumber;
            institutionNameTxtBox.Text = InstutionName;
            clsRltvPhoneNumberTxtBox.Text = CloseRelativePhoneNumber;
            clsRltvinstitutionRegisteryNumberTxtBox.Text = CloseRelativeInstutionRegisteryNumber;
            clsRltvinstitutionNameTxtBox.Text = CloseRelativeInstutionName;
        }
        public void ItemsToPropertiesData()
        {
            FileNo = fileNoTxtBox.Text;
            Identity  = identityNoTxtBox.Text;
            PatientName = nameTxtBox.Text;
            PatientSurName = surnameTxtBox.Text;
            BirthPlace = birthPlaceTxtBox.Text;
            BirthDay = birtdayDtTmPckr.Value;
            FatherName = fatherNameTxtBox.Text;
            MotherName = motherNameTxtBox.Text;
            Gender = genderCmbBox.Text;
            BloodGroup = bloodGroupCmbBox.Text;
            MaritalStatus = maritalStatusCmbBox.Text;
            Address = addressTxtBox.Text;
            PhoneNumber = phoneNumberTxtBox.Text;
            InstutionRegisteryNumber = institutionRegisteryNumberTxtBox.Text;
            InstutionName = institutionNameTxtBox.Text;
            CloseRelativePhoneNumber = clsRltvPhoneNumberTxtBox.Text;
            CloseRelativeInstutionRegisteryNumber = clsRltvinstitutionRegisteryNumberTxtBox.Text;
            CloseRelativeInstutionName = clsRltvinstitutionNameTxtBox.Text;
        }
        private void newRegisterBtn_Click(object sender, EventArgs e)
        {
            ResetUtilities resetUtilities = new ResetUtilities();
            resetUtilities.ResetAllControls(this);
        }
        private void registerBtn_Click(object sender, EventArgs e)
        {
            ItemsToPropertiesData();
            if (Identity == "" || PatientName == "" || PatientSurName == "" || BloodGroup == "" || Gender == null || BloodGroup == null || BirthDay == Convert.ToDateTime("1/1/0001 12:00:00 AM") ||
                Identity == null || PatientName == null || PatientSurName == null || Gender == null)
            {
                MessageBox.Show("Lütfen kutucukların hepsini doğru ve boş bırakmadan doldurunuz!");
            }
            else
            { 
            if (sql != null)
            {
                sql.HastaBilgileriInsertOrUpdateData();
            }
            MessageBox.Show("successfull");
            }
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string FillingWithZero(int number)
        {
            return (number.ToString().PadLeft(5, '0'));
        }

        private void nameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void surnameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void birthPlaceTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void fatherNameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void motherNameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void identityNoTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void phoneNumberTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void clsRltvPhoneNumberTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void institutionRegisteryNumberTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void clsRltvinstitutionRegisteryNumberTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void birtdayDtTmPckr_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            if (birtdayDtTmPckr.Value > today)
            {
                birtdayDtTmPckr.Value = today;
                MessageBox.Show("Bugünden büyük bir tarih seçemezsiniz!");
            }
        }
        
    }
}
