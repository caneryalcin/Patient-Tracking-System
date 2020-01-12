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
    public partial class KulTanit : Form
    {
        Kullanıcı kullanici = new Kullanıcı();
        public static string username;
        public KulTanit()
        {
            InitializeComponent();
            this.defineUserCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void addNewUser_Click(object sender, EventArgs e)
        {

            kullanici.Show();
            this.Close();
        }
        

        //brings usernames
        public void BringData()
        {
            string query = "SELECT * FROM kullanici";
            string data = "username";

            string connectionAddress = "Data Source=DESKTOP-QSVT225;Initial Catalog=SOHATS;Persist Security Info=True;User ID=sa;Password=zinagafsa29";
            SqlConnection connection = new SqlConnection(connectionAddress);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr;
            connection.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                defineUserCmbBox.Items.Add(dr[data]);
            }

            connection.Close();
        }

        private void KulTanit_Load(object sender, EventArgs e)
        {
            BringData();
        }

        private void defineUserCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            username = defineUserCmbBox.Text;           
            kullanici.Show();
            this.Close();

        }
    }
}
