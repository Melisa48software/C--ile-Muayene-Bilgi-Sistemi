
namespace MYBSProje
{
    partial class frmPoliklinik
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
            this.dataGridViewPoliklinikKayit = new System.Windows.Forms.DataGridView();
            this.lblPoliklinik = new System.Windows.Forms.Label();
            this.btnGoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoliklinikKayit)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPoliklinikKayit
            // 
            this.dataGridViewPoliklinikKayit.AllowUserToAddRows = false;
            this.dataGridViewPoliklinikKayit.AllowUserToDeleteRows = false;
            this.dataGridViewPoliklinikKayit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPoliklinikKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPoliklinikKayit.Location = new System.Drawing.Point(89, 137);
            this.dataGridViewPoliklinikKayit.Name = "dataGridViewPoliklinikKayit";
            this.dataGridViewPoliklinikKayit.ReadOnly = true;
            this.dataGridViewPoliklinikKayit.RowHeadersWidth = 51;
            this.dataGridViewPoliklinikKayit.RowTemplate.Height = 24;
            this.dataGridViewPoliklinikKayit.Size = new System.Drawing.Size(1147, 429);
            this.dataGridViewPoliklinikKayit.TabIndex = 12;
            this.dataGridViewPoliklinikKayit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPoliklinikKayit_CellContentClick);
            // 
            // lblPoliklinik
            // 
            this.lblPoliklinik.AutoSize = true;
            this.lblPoliklinik.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPoliklinik.Location = new System.Drawing.Point(369, 41);
            this.lblPoliklinik.Name = "lblPoliklinik";
            this.lblPoliklinik.Size = new System.Drawing.Size(469, 38);
            this.lblPoliklinik.TabIndex = 13;
            this.lblPoliklinik.Text = "POLİKLİNİK KAYIT DEFTERİ";
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.Color.Yellow;
            this.btnGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoster.Location = new System.Drawing.Point(37, 34);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(141, 65);
            this.btnGoster.TabIndex = 38;
            this.btnGoster.Text = "GÖSTER";
            this.btnGoster.UseVisualStyleBackColor = false;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // frmPoliklinik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1332, 596);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.lblPoliklinik);
            this.Controls.Add(this.dataGridViewPoliklinikKayit);
            this.Name = "frmPoliklinik";
            this.Text = "Poliklinik_Kayıt_Defteri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoliklinikKayit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPoliklinikKayit;
        private System.Windows.Forms.Label lblPoliklinik;
        private System.Windows.Forms.Button btnGoster;
    }
}