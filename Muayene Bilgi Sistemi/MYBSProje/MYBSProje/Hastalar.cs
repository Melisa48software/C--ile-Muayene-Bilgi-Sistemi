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
    public partial class frmHastalar : Form
    {
        public frmHastalar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void frmMenu_Click(object sender, EventArgs e)
        {

        }

        public void HastaKaydet()
        {
            baglanti.Open();
            string ekle = "insert into tblhastalar (tckimlik_numarasi,ad,soyad,dogum_yeri,dogum_tarihi,medeni_durum,adres,telefon) values(@p1, @p2, @p3, @p4, @p5, @p6, @p7,@p8)";
            NpgsqlCommand cmd = new NpgsqlCommand(ekle, baglanti);
            cmd.Parameters.AddWithValue("@p1", txtTC.Text);
            cmd.Parameters.AddWithValue("@p2", txtAdi.Text);
            cmd.Parameters.AddWithValue("@p3", txtSoyadi.Text);
            cmd.Parameters.AddWithValue("@p4", txtDogumYeri.Text);
            cmd.Parameters.AddWithValue("@p5", Convert.ToDateTime(txtDogumTarihi.Text));
            cmd.Parameters.AddWithValue("@p6", txtMedeniDurumu.Text);
            cmd.Parameters.AddWithValue("@p7", txtAdres.Text);
            cmd.Parameters.AddWithValue("@p8", txtTelefon.Text);


            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hasta Bilgileri Kaydedildi.");

        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port=5432; Database= dbMYBS; username = postgres; password = 1234");
        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from tblhastalar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewHastalar.DataSource = ds.Tables[0];
        }

        private void frmHastalar_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            HastaKaydet();
        }
    }
}
