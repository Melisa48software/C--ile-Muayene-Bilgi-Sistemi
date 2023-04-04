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
    public partial class frmRapor1 : Form
    {
        public frmRapor1()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port=5432; Database= dbMYBS; username = postgres; password = 1234");

        private void btnRaporGoster_Click(object sender, EventArgs e)
        {
            string hastatc = txtTC.Text;
            string sorgu = "select tblılaclar.ilac_adi from tblılaclar  inner join tblreceteler on  tblılaclar.barkod_numarasi = tblreceteler.barkod_no inner join tblmuayeneler on  tblmuayeneler.muayene_no = tblreceteler.muayene_id where tblmuayeneler.hasta_tckimlikno='" + hastatc + "'";        
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewRapor1.DataSource = ds.Tables[0];
        }
    }
}
