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
    public partial class PoliTanıt : Form
    {
        public PoliTanıt()
        {
            InitializeComponent();
            this.polyclinicCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        public static string polyclinicName;
        public static bool Valid;
  
        private void polyclinicCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Valid = validUnvalidChckBox.Checked;
            polyclinicName = polyclinicCmbBox.Text;
            Poliklinik polikinlik = new Poliklinik();
            polikinlik.Show();
            this.Close();
        }
    }
}
