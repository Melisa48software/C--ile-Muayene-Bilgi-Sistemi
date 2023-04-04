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
    public partial class frmİlaclar : Form
    {
        public frmİlaclar()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port=5432; Database= dbMYBS; username = postgres; password = 1234");
        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from tblılaclar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewIlaclar.DataSource = ds.Tables[0];
        }

        public void İlacKaydet()
        {
            baglanti.Open();
            string ekle = "insert into tblhastalar (barkod_numarasi,ilac_adi, ilac_tip) values(@p1, @p2, @p3)";
            NpgsqlCommand cmd = new NpgsqlCommand(ekle, baglanti);
            cmd.Parameters.AddWithValue("@p1", txtBarkodNumarasi.Text);
            cmd.Parameters.AddWithValue("@p2", txtAdi.Text);
            cmd.Parameters.AddWithValue("@p3", txtTipi.Text);

            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İlaç Bilgileri Kaydedildi.");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            İlacKaydet();
        }

    }
}
