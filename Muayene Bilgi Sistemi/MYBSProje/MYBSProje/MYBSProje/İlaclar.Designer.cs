
namespace MYBSProje
{
    partial class frmİlaclar
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
            this.lblIlaclar = new System.Windows.Forms.Label();
            this.dataGridViewIlaclar = new System.Windows.Forms.DataGridView();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblTipi = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.txtTipi = new System.Windows.Forms.TextBox();
            this.txtBarkodNumarasi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIlaclar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIlaclar
            // 
            this.lblIlaclar.AutoSize = true;
            this.lblIlaclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlaclar.Location = new System.Drawing.Point(12, 75);
            this.lblIlaclar.Name = "lblIlaclar";
            this.lblIlaclar.Size = new System.Drawing.Size(107, 32);
            this.lblIlaclar.TabIndex = 5;
            this.lblIlaclar.Text = "İlaçlar:";
            // 
            // dataGridViewIlaclar
            // 
            this.dataGridViewIlaclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIlaclar.Location = new System.Drawing.Point(435, 89);
            this.dataGridViewIlaclar.Name = "dataGridViewIlaclar";
            this.dataGridViewIlaclar.RowHeadersWidth = 51;
            this.dataGridViewIlaclar.RowTemplate.Height = 24;
            this.dataGridViewIlaclar.Size = new System.Drawing.Size(874, 491);
            this.dataGridViewIlaclar.TabIndex = 11;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(384, 21);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(489, 38);
            this.lblBaslik.TabIndex = 12;
            this.lblBaslik.Text = "Muayene Bilgi Sistemi (MYBS)";
            // 
            // lblTipi
            // 
            this.lblTipi.AutoSize = true;
            this.lblTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTipi.Location = new System.Drawing.Point(13, 290);
            this.lblTipi.Name = "lblTipi";
            this.lblTipi.Size = new System.Drawing.Size(46, 25);
            this.lblTipi.TabIndex = 17;
            this.lblTipi.Text = "Tip:";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdi.Location = new System.Drawing.Point(12, 228);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(47, 25);
            this.lblAdi.TabIndex = 18;
            this.lblAdi.Text = "Adı:";
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarkod.Location = new System.Drawing.Point(12, 169);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(168, 25);
            this.lblBarkod.TabIndex = 19;
            this.lblBarkod.Text = "Barkod Numarası:";
            // 
            // txtTipi
            // 
            this.txtTipi.Location = new System.Drawing.Point(198, 294);
            this.txtTipi.Name = "txtTipi";
            this.txtTipi.Size = new System.Drawing.Size(181, 22);
            this.txtTipi.TabIndex = 27;
            // 
            // txtBarkodNumarasi
            // 
            this.txtBarkodNumarasi.Location = new System.Drawing.Point(198, 172);
            this.txtBarkodNumarasi.Name = "txtBarkodNumarasi";
            this.txtBarkodNumarasi.Size = new System.Drawing.Size(181, 22);
            this.txtBarkodNumarasi.TabIndex = 28;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(198, 228);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(181, 22);
            this.txtAdi.TabIndex = 29;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Crimson;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKaydet.Location = new System.Drawing.Point(39, 420);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(141, 62);
            this.btnKaydet.TabIndex = 32;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Yellow;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(238, 420);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(141, 65);
            this.btnListele.TabIndex = 33;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // frmİlaclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1329, 592);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.txtBarkodNumarasi);
            this.Controls.Add(this.txtTipi);
            this.Controls.Add(this.lblBarkod);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.lblTipi);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.dataGridViewIlaclar);
            this.Controls.Add(this.lblIlaclar);
            this.Name = "frmİlaclar";
            this.Text = "İlaclar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIlaclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIlaclar;
        private System.Windows.Forms.DataGridView dataGridViewIlaclar;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblTipi;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.TextBox txtTipi;
        private System.Windows.Forms.TextBox txtBarkodNumarasi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnListele;
    }
}