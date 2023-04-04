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
    public partial class frmReceteler : Form
    {
        public frmReceteler()
        {
            InitializeComponent();
        }
     
        private void frmReceteler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select ilac_adi from tblılaclar", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxa.DisplayMember = "ilac_adi";
            comboBoxa.ValueMember = "barkod_numarasi";
            comboBoxa.DataSource = dt;
            comboBoxa.SelectedItem = null;
            baglanti.Close();


            baglanti.Open();
            NpgsqlDataAdapter a = new NpgsqlDataAdapter("select ilac_adi from tblılaclar", baglanti);
            DataTable b = new DataTable();
            a.Fill(b);
            comboBoxb.DisplayMember = "ilac_adi";
            comboBoxb.ValueMember = "barkod_numarasi";
            comboBoxb.DataSource = b;
            comboBoxb.SelectedItem = null;
            baglanti.Close();


            baglanti.Open();
            NpgsqlDataAdapter c = new NpgsqlDataAdapter("select ilac_adi from tblılaclar", baglanti);
            DataTable d = new DataTable();
            c.Fill(d);
            comboBoxc.DisplayMember = "ilac_adi";
            comboBoxc.ValueMember = "barkod_numarasi";
            comboBoxc.DataSource = d;
            comboBoxc.SelectedItem = null;
            baglanti.Close();

            baglanti.Open();
            NpgsqlDataAdapter j = new NpgsqlDataAdapter("select ilac_adi from tblılaclar", baglanti);
            DataTable f = new DataTable();
            j.Fill(f);
            comboBoxd.DisplayMember = "ilac_adi";
            comboBoxd.ValueMember = "barkod_numarasi";
            comboBoxd.DataSource = f;
            comboBoxd.SelectedItem = null;
            baglanti.Close();

            baglanti.Open();
            NpgsqlDataAdapter g = new NpgsqlDataAdapter("select ilac_adi from tblılaclar", baglanti);
            DataTable h = new DataTable();
            g.Fill(h);
            comboBoxe.DisplayMember = "ilac_adi";
            comboBoxe.ValueMember = "barkod_numarasi";
            comboBoxe.DataSource = h;
            comboBoxe.SelectedItem = null;
            baglanti.Close();
        }

        private void btnReceteKaydet_Click(object sender, EventArgs e)
        {
            ReceteKaydet();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port=5432; Database= dbMYBS; username = postgres; password = 1234");
        public void ReceteKaydet()
        {
            baglanti.Open();
            string ekle = "insert into tblmuayeneler a, tblhastalar b, tblılaclar c (a.muayene_tarihi, a.hasta_tani, b.hasta_tckimlikno, b.hasta_ad, b.hasta_soyad, c.ilac_adi, c.kutu_adet) values(@p1, @p2, @p3,@p4,@p5, @p6, @p7)";
            NpgsqlCommand cmd = new NpgsqlCommand(ekle, baglanti);
            cmd.Parameters.AddWithValue("@p1", txtReceteTarihi.Text);
            cmd.Parameters.AddWithValue("@p2", txtHastaTani.Text);
            cmd.Parameters.AddWithValue("@p3", txtTc.Text);
            cmd.Parameters.AddWithValue("@p4", txtHastaAd.Text);
            cmd.Parameters.AddWithValue("@p5", txtHastaSoyad.Text);

            



            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Reçete Bilgileri Kaydedildi.");
        }

        private void btnReceteListele_Click(object sender, EventArgs e)
        {
            string sorgu = "Select tblmuayeneler.muayene_tarih, tblmuayeneler.hasta_tani, tblmuayeneler.hasta_tckimlikno, tblhastalar.hasta_ad, tblhastalar.hasta_soyad, tblılaclar.ilac_adi, tblılaclar.kutu_adet FROM tblreceteler INNER JOIN tblmuayeneler ON tblreceteler.muayene_id = tblmuayeneler.muayene_no INNER JOIN tblılaclar ON tblreceteler.barkod_no = tblılaclar.barkod_numarasi INNER JOIN tblhastalar ON tblhastalar.hasta_tckimlikno = tblmuayeneler.hasta_tckimlikno";
            string sorgu2 = "Select * from tblmuayeneler order by muayene_tarih ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewReceteler.DataSource = ds.Tables[0];
        }
    }
}
