
namespace MYBSProje
{
    partial class frmRapor1
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
            this.dataGridViewRapor1 = new System.Windows.Forms.DataGridView();
            this.btnRaporGoster = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRapor1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRapor1
            // 
            this.dataGridViewRapor1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRapor1.Location = new System.Drawing.Point(458, 131);
            this.dataGridViewRapor1.Name = "dataGridViewRapor1";
            this.dataGridViewRapor1.RowHeadersWidth = 51;
            this.dataGridViewRapor1.RowTemplate.Height = 24;
            this.dataGridViewRapor1.Size = new System.Drawing.Size(764, 369);
            this.dataGridViewRapor1.TabIndex = 0;
            // 
            // btnRaporGoster
            // 
            this.btnRaporGoster.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnRaporGoster.Location = new System.Drawing.Point(176, 298);
            this.btnRaporGoster.Name = "btnRaporGoster";
            this.btnRaporGoster.Size = new System.Drawing.Size(155, 63);
            this.btnRaporGoster.TabIndex = 1;
            this.btnRaporGoster.Text = "GÖSTER";
            this.btnRaporGoster.UseVisualStyleBackColor = false;
            this.btnRaporGoster.Click += new System.EventHandler(this.btnRaporGoster_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hasta TC Kimlik No Giriniz:";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(281, 154);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(155, 22);
            this.txtTC.TabIndex = 3;
            // 
            // frmRapor1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1330, 590);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRaporGoster);
            this.Controls.Add(this.dataGridViewRapor1);
            this.Name = "frmRapor1";
            this.Text = "frmRapor1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRapor1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRapor1;
        private System.Windows.Forms.Button btnRaporGoster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTC;
    }
}