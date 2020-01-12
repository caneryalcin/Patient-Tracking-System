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
    public partial class DosyaBul : Form
    {
        SqlConnectionClass sql = new SqlConnectionClass();
        public DosyaBul()
        {
            InitializeComponent();
            this.criterionCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static string PatientName { get; set; }
        public static string PatientSurName { get; set; }
        public static Boolean Bool { get; set; }
        public static string IdentityNumber { get; set; }
        public static string InstutionRegistryNumber { get; set; }
        public static string FileNumber { get; set; }

        private void criterionCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PatientName = null;
            PatientSurName = null;
            IdentityNumber = null;
            InstutionRegistryNumber = null;
            FileNumber = null;
            if (criterionCmbBox.Text == "Kimlik No")
            {
                searchingTxtBox.Visible = true;
                nameTxtBox.Visible = false;
                surNameTxtBox.Visible = false;
                andChckBox.Visible = false;
                IdentityNumber = searchingTxtBox.Text ;
                searchingTxtBox.MaxLength =  11;
            }
            else if (criterionCmbBox.Text == "Kurum Sicil No")
            {
                searchingTxtBox.Visible = true;
                nameTxtBox.Visible = false;
                surNameTxtBox.Visible = false;
                andChckBox.Visible = false;
                InstutionRegistryNumber = searchingTxtBox.Text;
                searchingTxtBox.MaxLength = 10;
            }
            else if (criterionCmbBox.Text == "Dosya No")
            {
                searchingTxtBox.Visible = true;
                nameTxtBox.Visible = false;
                surNameTxtBox.Visible = false;
                andChckBox.Visible = false;
                searchingTxtBox.MaxLength = 15;
            }
            else
            {
                searchingTxtBox.Visible = false;
                nameTxtBox.Visible = true;
                surNameTxtBox.Visible = true;
                andChckBox.Visible = true;
            }
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            if (criterionCmbBox.Text == "Kimlik No")
            {
                IdentityNumber = searchingTxtBox.Text;
            }
            else if (criterionCmbBox.Text == "Kurum Sicil No")
            {
                InstutionRegistryNumber = searchingTxtBox.Text;
            }
            else if (criterionCmbBox.Text == "Dosya No")
            {
                FileNumber = searchingTxtBox.Text;
            }
            else
            {
                PatientName = nameTxtBox.Text;
                PatientSurName = surNameTxtBox.Text;
                Bool = andChckBox.Checked;
            }
           dataGridView1.DataSource=sql.DosyaBringData();
           searchingTxtBox.Text = "";
        }

        private void searchingTxtBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void surNameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
