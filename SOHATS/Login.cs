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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnectionClass sql = new SqlConnectionClass();

        public static string UserName { get; set; }
        public static string Password{ get; set; }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            UserName = userTextBox.Text;
            Password = passwordTextBox.Text;
           
            if (sql != null) 
            {
                sql.userAuthentication();
            }

            if (sql.dtbl.Rows.Count == 1)
            {
                SağlıkOcağıHastaTakipSistemi.referansMenu.Visible = true;
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre");
            }

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            userTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
