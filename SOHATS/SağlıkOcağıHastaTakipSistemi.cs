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
    public partial class SağlıkOcağıHastaTakipSistemi : Form
    {
        public static ToolStripMenuItem referansMenu;
        public SağlıkOcağıHastaTakipSistemi()
        {
            InitializeComponent();
        }
        
        private void SağlıkOcağıHastaTakipSistemi_Load(object sender, EventArgs e)
        {
            referansMenu = referanceMenuItem;
            referansMenu.Visible = false;
            Login logInForm = new Login();
            logInForm.MdiParent = this;
            logInForm.Show();
        }

        private void polikinlikTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoliTanıt poliTanit = new PoliTanıt();
            poliTanit.Show();
        }

        private void kullanıcıTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KulTanit kulTanit = new KulTanit();
            kulTanit.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void hastaİslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                SağlıkOcağıHastaTakipSistemi.ActiveForm.ActiveMdiChild.Close();

            }
            Hastaİslemleri hİslemleri = new Hastaİslemleri();
            hİslemleri.MdiParent = this;
            hİslemleri.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login logInForm = new Login();
            logInForm.MdiParent = this;
            logInForm.Show();
            menuStrip1.Items[0].Visible = false;

        }

        private void raporGeçiciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                SağlıkOcağıHastaTakipSistemi.ActiveForm.ActiveMdiChild.Close();

            }
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
            
        }


     
       
    }
}
