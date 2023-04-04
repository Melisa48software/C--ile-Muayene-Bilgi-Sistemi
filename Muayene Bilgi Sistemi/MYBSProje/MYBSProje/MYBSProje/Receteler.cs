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
    public partial class frmReceteler : Form
    {
        public frmReceteler()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();
        private void frmReceteler_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("Reçete Numarası", typeof(int));
            tablo.Columns.Add("Hasta Ad Soyad", typeof(string));
            tablo.Columns.Add("Hasta TC Kimlik No", typeof(string));
            tablo.Columns.Add("Barkod No", typeof(string));
            tablo.Columns.Add("İlaç Adı", typeof(string));
            tablo.Columns.Add("İlaç Adet", typeof(int));
            dataGridViewReceteler.DataSource = tablo;
        }

        private void btnReceteKaydet_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(txtReceteNumarasi.Text, txtHastaAdSoyad.Text, txtTc.Text, txtBarkodNo.Text, txtBirinciIlac.Text, txtIkinciIlac.Text, txtUcuncuIlac.Text, txtDorduncuIlac.Text, txtBesinciIlac.Text);
            dataGridViewReceteler.DataSource = tablo;
        }

        private void btnReceteListele_Click(object sender, EventArgs e)
        {

        }
    }
}
