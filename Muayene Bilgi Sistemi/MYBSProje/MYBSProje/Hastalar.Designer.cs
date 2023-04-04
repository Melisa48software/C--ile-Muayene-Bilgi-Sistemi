
namespace MYBSProje
{
    partial class frmHastalar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHastalar = new System.Windows.Forms.Label();
            this.dataGridViewHastalar = new System.Windows.Forms.DataGridView();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblTckimlik = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.lblDogumYeri = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblMedeniDurum = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtMedeniDurumu = new System.Windows.Forms.TextBox();
            this.txtDogumTarihi = new System.Windows.Forms.TextBox();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHastalar
            // 
            this.lblHastalar.AutoSize = true;
            this.lblHastalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastalar.Location = new System.Drawing.Point(28, 75);
            this.lblHastalar.Name = "lblHastalar";
            this.lblHastalar.Size = new System.Drawing.Size(129, 32);
            this.lblHastalar.TabIndex = 2;
            this.lblHastalar.Text = "Hastalar";
            this.lblHastalar.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewHastalar
            // 
            this.dataGridViewHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHastalar.Location = new System.Drawing.Point(650, 145);
            this.dataGridViewHastalar.Name = "dataGridViewHastalar";
            this.dataGridViewHastalar.RowHeadersWidth = 51;
            this.dataGridViewHastalar.RowTemplate.Height = 24;
            this.dataGridViewHastalar.Size = new System.Drawing.Size(661, 385);
            this.dataGridViewHastalar.TabIndex = 7;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(340, 20);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(489, 38);
            this.lblBaslik.TabIndex = 8;
            this.lblBaslik.Text = "Muayene Bilgi Sistemi (MYBS)";
            // 
            // lblTckimlik
            // 
            this.lblTckimlik.AutoSize = true;
            this.lblTckimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTckimlik.Location = new System.Drawing.Point(27, 152);
            this.lblTckimlik.Name = "lblTckimlik";
            this.lblTckimlik.Size = new System.Drawing.Size(133, 25);
            this.lblTckimlik.TabIndex = 9;
            this.lblTckimlik.Text = "TC Kimlik No:";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdi.Location = new System.Drawing.Point(29, 202);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(47, 25);
            this.lblAdi.TabIndex = 16;
            this.lblAdi.Text = "Adı:";
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyadi.Location = new System.Drawing.Point(29, 258);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(79, 25);
            this.lblSoyadi.TabIndex = 17;
            this.lblSoyadi.Text = "Soyadı:";
            // 
            // lblDogumYeri
            // 
            this.lblDogumYeri.AutoSize = true;
            this.lblDogumYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumYeri.Location = new System.Drawing.Point(29, 309);
            this.lblDogumYeri.Name = "lblDogumYeri";
            this.lblDogumYeri.Size = new System.Drawing.Size(120, 25);
            this.lblDogumYeri.TabIndex = 18;
            this.lblDogumYeri.Text = "Doğum Yeri:";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumTarihi.Location = new System.Drawing.Point(27, 362);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(135, 25);
            this.lblDogumTarihi.TabIndex = 19;
            this.lblDogumTarihi.Text = "Doğum Tarihi:";
            // 
            // lblMedeniDurum
            // 
            this.lblMedeniDurum.AutoSize = true;
            this.lblMedeniDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMedeniDurum.Location = new System.Drawing.Point(27, 410);
            this.lblMedeniDurum.Name = "lblMedeniDurum";
            this.lblMedeniDurum.Size = new System.Drawing.Size(157, 25);
            this.lblMedeniDurum.TabIndex = 20;
            this.lblMedeniDurum.Text = "Medeni Durumu:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(27, 456);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(70, 25);
            this.lblAdres.TabIndex = 21;
            this.lblAdres.Text = "Adres:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.Location = new System.Drawing.Point(27, 509);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(84, 25);
            this.lblTelefon.TabIndex = 22;
            this.lblTelefon.Text = "Telefon:";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(218, 152);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(181, 22);
            this.txtTC.TabIndex = 23;
            // 
            // txtMedeniDurumu
            // 
            this.txtMedeniDurumu.Location = new System.Drawing.Point(218, 414);
            this.txtMedeniDurumu.Name = "txtMedeniDurumu";
            this.txtMedeniDurumu.Size = new System.Drawing.Size(181, 22);
            this.txtMedeniDurumu.TabIndex = 24;
            // 
            // txtDogumTarihi
            // 
            this.txtDogumTarihi.Location = new System.Drawing.Point(218, 365);
            this.txtDogumTarihi.Name = "txtDogumTarihi";
            this.txtDogumTarihi.Size = new System.Drawing.Size(181, 22);
            this.txtDogumTarihi.TabIndex = 25;
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(218, 312);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(181, 22);
            this.txtDogumYeri.TabIndex = 26;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(218, 513);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(181, 22);
            this.txtTelefon.TabIndex = 27;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(218, 261);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(181, 22);
            this.txtSoyadi.TabIndex = 28;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(218, 202);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(181, 22);
            this.txtAdi.TabIndex = 29;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(218, 456);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(181, 43);
            this.txtAdres.TabIndex = 30;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Crimson;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKaydet.Location = new System.Drawing.Point(457, 152);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(141, 62);
            this.btnKaydet.TabIndex = 31;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Yellow;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(457, 258);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(141, 65);
            this.btnListele.TabIndex = 32;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // frmHastalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1323, 560);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtDogumYeri);
            this.Controls.Add(this.txtDogumTarihi);
            this.Controls.Add(this.txtMedeniDurumu);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblMedeniDurum);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.lblDogumYeri);
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.lblTckimlik);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.dataGridViewHastalar);
            this.Controls.Add(this.lblHastalar);
            this.Name = "frmHastalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastalar";
            this.Load += new System.EventHandler(this.btnListele_Click);
            this.Click += new System.EventHandler(this.frmHastalar_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHastalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHastalar;
        private System.Windows.Forms.DataGridView dataGridViewHastalar;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblTckimlik;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.Label lblDogumYeri;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblMedeniDurum;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtMedeniDurumu;
        private System.Windows.Forms.TextBox txtDogumTarihi;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnListele;
    }
}

