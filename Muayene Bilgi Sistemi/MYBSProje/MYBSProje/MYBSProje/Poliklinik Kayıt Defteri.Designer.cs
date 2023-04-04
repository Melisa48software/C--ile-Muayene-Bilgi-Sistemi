
namespace MYBSProje
{
    partial class Poliklinik_Kayıt_Defteri
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoliklinikKayit)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPoliklinikKayit
            // 
            this.dataGridViewPoliklinikKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPoliklinikKayit.Location = new System.Drawing.Point(88, 117);
            this.dataGridViewPoliklinikKayit.Name = "dataGridViewPoliklinikKayit";
            this.dataGridViewPoliklinikKayit.RowHeadersWidth = 51;
            this.dataGridViewPoliklinikKayit.RowTemplate.Height = 24;
            this.dataGridViewPoliklinikKayit.Size = new System.Drawing.Size(1147, 429);
            this.dataGridViewPoliklinikKayit.TabIndex = 12;
            // 
            // lblPoliklinik
            // 
            this.lblPoliklinik.AutoSize = true;
            this.lblPoliklinik.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPoliklinik.Location = new System.Drawing.Point(354, 43);
            this.lblPoliklinik.Name = "lblPoliklinik";
            this.lblPoliklinik.Size = new System.Drawing.Size(469, 38);
            this.lblPoliklinik.TabIndex = 13;
            this.lblPoliklinik.Text = "POLİKLİNİK KAYIT DEFTERİ";
            // 
            // Poliklinik_Kayıt_Defteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1332, 596);
            this.Controls.Add(this.lblPoliklinik);
            this.Controls.Add(this.dataGridViewPoliklinikKayit);
            this.Name = "Poliklinik_Kayıt_Defteri";
            this.Text = "Poliklinik_Kayıt_Defteri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoliklinikKayit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPoliklinikKayit;
        private System.Windows.Forms.Label lblPoliklinik;
    }
}