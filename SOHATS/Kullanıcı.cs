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
    public partial class Kullanıcı : Form
    {
        SqlConnectionClass sql = new SqlConnectionClass();
        public Kullanıcı()
        {
            InitializeComponent();
            this.maritalStatusCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.bloodGroupCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.genderCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.titleCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        
        #region Properties of Items
        public static string  UserCode{ get; set; }
        public static string Name{ get; set; }
        public static string SurName { get; set; }
        public static string Password { get; set; }
        public static bool AuthorizedUser { get; set; }
        public static string Gsm { get; set; }
        public static string PhoneNumber { get; set; }
        public static string Address { get; set; }
        public static string Title { get; set; }
        public static DateTime JobStartDate { get; set; }
        public static string Salary { get; set; }
        public static string BirthPlace { get; set; }
        public static string MotherName { get; set; }
        public static string FatherName { get; set; }
        public static string Gender { get; set; }
        public static string BloodGroup { get; set; }
        public static string MaritalStatus { get; set; }
        public static DateTime BirthDay { get; set; }
        public static string IdentityNo { get; set; }
        public static string UserName { get; set; }

        #endregion

        public void ItemsToIPropertiesData()
        {
            UserCode = usercodeTxtBox.Text.ToString();
            Name = nameTxtBox.Text.ToString();
            SurName = surnameTxtBox.Text.ToString();
            Password = passwordTxtBox.Text.ToString();
            AuthorizedUser = authorizedUseChckBox.Checked;
            Gsm = gsmTxtBox.Text.ToString();
            PhoneNumber = phoneNumberTxtBox.Text.ToString();
            Address = addressTxtBox.Text.ToString();
            Title = titleCmbBox.Text.ToString();
            JobStartDate = jobStartdateTimePicker.Value;
            Salary = salaryTxtBox.Text.ToString();
            BirthPlace = birthPlaceTxtBox.Text.ToString();
            MotherName = motherNameTxtBox.Text.ToString();
            FatherName = fatherNameTxtBox.Text.ToString();
            Gender = genderCmbBox.Text.ToString();
            BloodGroup = bloodGroupCmbBox.Text.ToString();
            MaritalStatus = maritalStatusCmbBox.Text.ToString();
            BirthDay = birtdayDtTmPckr.Value;
            IdentityNo = identityNoTxtBox.Text.ToString();
            UserName = userNameTxtBox.Text.ToString();
        }
        public void PropertiesToItemsData()
        {
            usercodeTxtBox.Text = UserCode;
            nameTxtBox.Text = Name;
            surnameTxtBox.Text = SurName;
            passwordTxtBox.Text = Password;
            authorizedUseChckBox.Checked = AuthorizedUser;
            Gsm = gsmTxtBox.Text;
            phoneNumberTxtBox.Text = PhoneNumber;
            addressTxtBox.Text = Address;
            titleCmbBox.Text = Title;
            jobStartdateTimePicker.Value = JobStartDate;
            salaryTxtBox.Text = Salary;
            birthPlaceTxtBox.Text = BirthPlace;
            motherNameTxtBox.Text = MotherName;
            fatherNameTxtBox.Text = FatherName;
            genderCmbBox.Text= Gender;
            bloodGroupCmbBox.Text = BloodGroup;
            maritalStatusCmbBox.Text = MaritalStatus;
            birtdayDtTmPckr.Value = BirthDay;
            identityNoTxtBox.Text = IdentityNo;
            userNameTxtBox.Text = UserName;
        }


        private void Kullanıcı_Load(object sender, EventArgs e)
        {
            string username = KulTanit.username;
            if (username != null)
            {
                sql.KullanıcıBringData();
                PropertiesToItemsData();
            }
        }                 


        private void updateBtn_Click(object sender, EventArgs e)
        {
            ItemsToIPropertiesData();
            if (IdentityNo == "" || Name == "" || SurName == "" ||  Gender == null || BirthDay == Convert.ToDateTime("1/1/0001 12:00:00 AM") || JobStartDate == Convert.ToDateTime("1/1/0001 12:00:00 AM")||
                IdentityNo == null || Name == null || SurName == null || Gender == null)
            {
                MessageBox.Show("Lütfen kutucukların hepsini doğru ve boş bırakmadan doldurunuz!");
            }
            else
            {
                if (sql != null)
                {
                    sql.KullanıcıInsertOrUpdateData();
                    MessageBox.Show("Succesfull");
                }
            }
        }       
        private void deleteBtn_Click(object sender, EventArgs e)
        {
           sql.KullanıcıDeleteData();
           MessageBox.Show("Succesfull");
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ResetUtilities resetUtilities = new ResetUtilities();
            resetUtilities.ResetAllControls(this);
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
        private void salaryTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void gsmTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void nameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private void surnameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private void jobStartdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            if (jobStartdateTimePicker.Value > today)
            {
                jobStartdateTimePicker.Value = today;
                MessageBox.Show("Bugünden büyük bir tarih seçemezsiniz!");
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
