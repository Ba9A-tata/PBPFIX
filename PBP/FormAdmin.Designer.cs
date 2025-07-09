namespace PBP
{
    partial class FormMenuAdmin
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
            this.btnAnggota = new System.Windows.Forms.Button();
            this.btnBuku = new System.Windows.Forms.Button();
            this.btnPeminjaman = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnggota
            // 
            this.btnAnggota.Location = new System.Drawing.Point(105, 100);
            this.btnAnggota.Name = "btnAnggota";
            this.btnAnggota.Size = new System.Drawing.Size(126, 40);
            this.btnAnggota.TabIndex = 0;
            this.btnAnggota.Text = "Anggota";
            this.btnAnggota.UseVisualStyleBackColor = true;
            this.btnAnggota.Click += new System.EventHandler(this.btnAnggota_Click);
            // 
            // btnBuku
            // 
            this.btnBuku.Location = new System.Drawing.Point(237, 100);
            this.btnBuku.Name = "btnBuku";
            this.btnBuku.Size = new System.Drawing.Size(126, 40);
            this.btnBuku.TabIndex = 1;
            this.btnBuku.Text = "Buku";
            this.btnBuku.UseVisualStyleBackColor = true;
            this.btnBuku.Click += new System.EventHandler(this.btnBuku_Click);
            // 
            // btnPeminjaman
            // 
            this.btnPeminjaman.Location = new System.Drawing.Point(105, 146);
            this.btnPeminjaman.Name = "btnPeminjaman";
            this.btnPeminjaman.Size = new System.Drawing.Size(126, 40);
            this.btnPeminjaman.TabIndex = 2;
            this.btnPeminjaman.Text = "Peminjaman";
            this.btnPeminjaman.UseVisualStyleBackColor = true;
            this.btnPeminjaman.Click += new System.EventHandler(this.btnPeminjaman_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(169, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Silahkan pilih menu";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(237, 146);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(126, 40);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Kembali ke login";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(105, 192);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(126, 40);
            this.btnChart.TabIndex = 6;
            this.btnChart.Text = "Chart";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(461, 296);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPeminjaman);
            this.Controls.Add(this.btnBuku);
            this.Controls.Add(this.btnAnggota);
            this.Name = "FormMenuAdmin";
            this.Text = "MenuAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdmin_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnggota;
        private System.Windows.Forms.Button btnBuku;
        private System.Windows.Forms.Button btnPeminjaman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChart;
    }
}

