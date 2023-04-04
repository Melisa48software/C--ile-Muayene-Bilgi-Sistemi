using Npgsql;
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
    public partial class frmPoliklinik : Form
    {
        public frmPoliklinik()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port=5432; Database= dbMYBS; username = postgres; password = 1234");

        private void dataGridViewPoliklinikKayit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT tblmuayeneler.muayene_no, tblmuayeneler.muayene_tarih, tblhastalar.hasta_ad, tblhastalar.hasta_soyad, tblhastalar.dogum_yeri, tblhastalar.dogum_tarihi, tblmuayeneler.hasta_sikayeti, tblmuayeneler.hasta_tani, tblmuayeneler.onerilen_tedavi FROM tblhastalar INNER JOIN tblmuayeneler ON tblhastalar.hasta_tckimlikno = tblmuayeneler.hasta_tckimlikno";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewPoliklinikKayit.DataSource = ds.Tables[0];
        }
    }
}


