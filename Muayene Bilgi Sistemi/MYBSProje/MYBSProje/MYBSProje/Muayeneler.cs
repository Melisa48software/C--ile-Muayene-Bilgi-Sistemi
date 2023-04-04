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
    public partial class frmMuayeneler : Form
    {
        public frmMuayeneler()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port=5432; Database= dbMYBS; username = postgres; password = 1234");
        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from tblmuayeneler";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewMuayeneler.DataSource = ds.Tables[0];
        }

        public void MuayeneKaydet()
        {
            baglanti.Open();
            string ekle = "insert into tblhastalar (muayene_no,muayene_tarih,hasta_tckimlikno,hasta_sikayet,hasta_tani,onerilen_tedavi) values(@p1, @p2, @p3, @p4, @p5, @p6)";
            NpgsqlCommand cmd = new NpgsqlCommand(ekle, baglanti);
            cmd.Parameters.AddWithValue("@p1", txtMuayeneNo.Text);
            cmd.Parameters.AddWithValue("@p2", txtMuayeneTarih.Text);
            cmd.Parameters.AddWithValue("@p3", txtTc.Text);
            cmd.Parameters.AddWithValue("@p4", txtSikayet.Text);
            cmd.Parameters.AddWithValue("@p5", txtTani.Text);
            cmd.Parameters.AddWithValue("@p6", txtTedavi.Text);
      

            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Muayene Bilgileri Kaydedildi.");

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MuayeneKaydet();
            
        }

        private void frmMuayeneler_Load(object sender, EventArgs e)
        {

        }
    }
}
