
namespace MYBSProje
{
    partial class frmMuayeneler
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
            this.lblMuayeneler = new System.Windows.Forms.Label();
            this.dataGridViewMuayeneler = new System.Windows.Forms.DataGridView();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblTckimlik = new System.Windows.Forms.Label();
            this.lblMuayeneTarihi = new System.Windows.Forms.Label();
            this.txtMuayeneTarih = new System.Windows.Forms.TextBox();
            this.txtMuayeneNo = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblSikayet = new System.Windows.Forms.Label();
            this.lblHastaTani = new System.Windows.Forms.Label();
            this.lblTedavi = new System.Windows.Forms.Label();
            this.txtTedavi = new System.Windows.Forms.TextBox();
            this.txtTani = new System.Windows.Forms.TextBox();
            this.txtSikayet = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuayeneler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMuayeneler
            // 
            this.lblMuayeneler.AutoSize = true;
            this.lblMuayeneler.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMuayeneler.Location = new System.Drawing.Point(20, 67);
            this.lblMuayeneler.Name = "lblMuayeneler";
            this.lblMuayeneler.Size = new System.Drawing.Size(259, 32);
            this.lblMuayeneler.TabIndex = 4;
            this.lblMuayeneler.Text = "Muayene Kayıtları";
            // 
            // dataGridViewMuayeneler
            // 
            this.dataGridViewMuayeneler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMuayeneler.Location = new System.Drawing.Point(462, 87);
            this.dataGridViewMuayeneler.Name = "dataGridViewMuayeneler";
            this.dataGridViewMuayeneler.RowHeadersWidth = 51;
            this.dataGridViewMuayeneler.RowTemplate.Height = 24;
            this.dataGridViewMuayeneler.Size = new System.Drawing.Size(842, 480);
            this.dataGridViewMuayeneler.TabIndex = 10;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(376, 20);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(489, 38);
            this.lblBaslik.TabIndex = 11;
            this.lblBaslik.Text = "Muayene Bilgi Sistemi (MYBS)";
            // 
            // lblTckimlik
            // 
            this.lblTckimlik.AutoSize = true;
            this.lblTckimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTckimlik.Location = new System.Drawing.Point(24, 145);
            this.lblTckimlik.Name = "lblTckimlik";
            this.lblTckimlik.Size = new System.Drawing.Size(130, 25);
            this.lblTckimlik.TabIndex = 16;
            this.lblTckimlik.Text = "Muayene No:";
            // 
            // lblMuayeneTarihi
            // 
            this.lblMuayeneTarihi.AutoSize = true;
            this.lblMuayeneTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMuayeneTarihi.Location = new System.Drawing.Point(24, 199);
            this.lblMuayeneTarihi.Name = "lblMuayeneTarihi";
            this.lblMuayeneTarihi.Size = new System.Drawing.Size(154, 25);
            this.lblMuayeneTarihi.TabIndex = 18;
            this.lblMuayeneTarihi.Text = "Muayene Tarihi:";
            // 
            // txtMuayeneTarih
            // 
            this.txtMuayeneTarih.Location = new System.Drawing.Point(215, 203);
            this.txtMuayeneTarih.Name = "txtMuayeneTarih";
            this.txtMuayeneTarih.Size = new System.Drawing.Size(181, 22);
            this.txtMuayeneTarih.TabIndex = 25;
            // 
            // txtMuayeneNo
            // 
            this.txtMuayeneNo.Location = new System.Drawing.Point(215, 148);
            this.txtMuayeneNo.Name = "txtMuayeneNo";
            this.txtMuayeneNo.Size = new System.Drawing.Size(181, 22);
            this.txtMuayeneNo.TabIndex = 26;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Crimson;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKaydet.Location = new System.Drawing.Point(47, 495);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(141, 62);
            this.btnKaydet.TabIndex = 36;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Yellow;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(267, 492);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(141, 65);
            this.btnListele.TabIndex = 37;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.Location = new System.Drawing.Point(24, 254);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(185, 25);
            this.lblTc.TabIndex = 38;
            this.lblTc.Text = "Hasta TC kimlik No:";
            // 
            // lblSikayet
            // 
            this.lblSikayet.AutoSize = true;
            this.lblSikayet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSikayet.Location = new System.Drawing.Point(24, 304);
            this.lblSikayet.Name = "lblSikayet";
            this.lblSikayet.Size = new System.Drawing.Size(143, 25);
            this.lblSikayet.TabIndex = 39;
            this.lblSikayet.Text = "Hasta Şikayeti:";
            // 
            // lblHastaTani
            // 
            this.lblHastaTani.AutoSize = true;
            this.lblHastaTani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaTani.Location = new System.Drawing.Point(24, 356);
            this.lblHastaTani.Name = "lblHastaTani";
            this.lblHastaTani.Size = new System.Drawing.Size(113, 25);
            this.lblHastaTani.TabIndex = 40;
            this.lblHastaTani.Text = "Hasta Tanı:";
            // 
            // lblTedavi
            // 
            this.lblTedavi.AutoSize = true;
            this.lblTedavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTedavi.Location = new System.Drawing.Point(21, 407);
            this.lblTedavi.Name = "lblTedavi";
            this.lblTedavi.Size = new System.Drawing.Size(157, 25);
            this.lblTedavi.TabIndex = 41;
            this.lblTedavi.Text = "Önerilen Tedavi:";
            // 
            // txtTedavi
            // 
            this.txtTedavi.Location = new System.Drawing.Point(215, 411);
            this.txtTedavi.Name = "txtTedavi";
            this.txtTedavi.Size = new System.Drawing.Size(181, 22);
            this.txtTedavi.TabIndex = 42;
            // 
            // txtTani
            // 
            this.txtTani.Location = new System.Drawing.Point(215, 360);
            this.txtTani.Name = "txtTani";
            this.txtTani.Size = new System.Drawing.Size(181, 22);
            this.txtTani.TabIndex = 43;
            // 
            // txtSikayet
            // 
            this.txtSikayet.Location = new System.Drawing.Point(215, 308);
            this.txtSikayet.Name = "txtSikayet";
            this.txtSikayet.Size = new System.Drawing.Size(181, 22);
            this.txtSikayet.TabIndex = 44;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(215, 258);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(181, 22);
            this.txtTc.TabIndex = 45;
            // 
            // frmMuayeneler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1316, 579);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtSikayet);
            this.Controls.Add(this.txtTani);
            this.Controls.Add(this.txtTedavi);
            this.Controls.Add(this.lblTedavi);
            this.Controls.Add(this.lblHastaTani);
            this.Controls.Add(this.lblSikayet);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtMuayeneNo);
            this.Controls.Add(this.txtMuayeneTarih);
            this.Controls.Add(this.lblMuayeneTarihi);
            this.Controls.Add(this.lblTckimlik);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.dataGridViewMuayeneler);
            this.Controls.Add(this.lblMuayeneler);
            this.Name = "frmMuayeneler";
            this.Text = "Muayeneler";
            this.Load += new System.EventHandler(this.frmMuayeneler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuayeneler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMuayeneler;
        private System.Windows.Forms.DataGridView dataGridViewMuayeneler;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblTckimlik;
        private System.Windows.Forms.Label lblMuayeneTarihi;
        private System.Windows.Forms.TextBox txtMuayeneTarih;
        private System.Windows.Forms.TextBox txtMuayeneNo;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblSikayet;
        private System.Windows.Forms.Label lblHastaTani;
        private System.Windows.Forms.Label lblTedavi;
        private System.Windows.Forms.TextBox txtTedavi;
        private System.Windows.Forms.TextBox txtTani;
        private System.Windows.Forms.TextBox txtSikayet;
        private System.Windows.Forms.TextBox txtTc;
    }
}