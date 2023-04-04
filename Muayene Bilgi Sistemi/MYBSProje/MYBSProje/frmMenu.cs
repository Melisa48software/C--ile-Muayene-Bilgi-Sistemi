using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYBSProje
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnHastaKayit_Click(object sender, EventArgs e)
        {
            frmHastalar f1 = new frmHastalar();
            f1.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnIlacKayit_Click(object sender, EventArgs e)
        {
            frmİlaclar f4 = new frmİlaclar();
            f4.ShowDialog();
        }

        private void btnReceteKayit_Click(object sender, EventArgs e)
        {
            frmReceteler f3 = new frmReceteler();
            f3.ShowDialog();
        }

        private void btnMuayeneKayit_Click(object sender, EventArgs e)
        {
            frmMuayeneler f2 = new frmMuayeneler();
            f2.ShowDialog();
        }

        private void frmMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnPoliklinikDefteri_Click(object sender, EventArgs e)
        {
           frmPoliklinik f5 = new frmPoliklinik();
            f5.ShowDialog();
        }

        private void btnHastaIlac_Click(object sender, EventArgs e)
        {
            frmRapor1 f6 = new frmRapor1();
            f6.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRapor2 f7 = new frmRapor2();
            f7.ShowDialog();
        }
    }
}
