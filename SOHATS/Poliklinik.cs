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
    public partial class Poliklinik : Form
    {
        SqlConnectionClass sql = new SqlConnectionClass();

        #region Properties of Items
        public static string PolycilinicName { get; set; }
        public static string Explanation { get; set; }
        public static bool Situation{ get; set; }

        #endregion
        public void PropertiesToItemsData()
        {          
            polyclinicNameTxtBox.Text = PolycilinicName;
            situationChckBox.Checked = Situation;
            explanationRchBox.Text = Explanation;

        }
        public void ItemsToPropertiesData()
        {
            PolycilinicName = polyclinicNameTxtBox.Text;
            Situation = situationChckBox.Checked;
            Explanation = explanationRchBox.Text;
        }
        public Poliklinik()
        {
            InitializeComponent();
        }
        private void Poliklinik_Load(object sender, EventArgs e)
        {           
            if (sql != null) 
            {
                sql.PoliklinikBringData(); //Load polyclinic data
                PropertiesToItemsData();
            }
            if (PolycilinicName == "" || PolycilinicName == null)
            {
                situationChckBox.Checked = PoliTanıt.Valid;
                polyclinicNameTxtBox.Text = PoliTanıt.polyclinicName;
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (sql != null)
            {
                sql.PoliklinikDeleteData(); 
            }
            this.Close();
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            ItemsToPropertiesData();
            sql.PoliklinikInsertOrUpdateData();
            MessageBox.Show("successfull");
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
    }
}
