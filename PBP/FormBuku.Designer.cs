﻿namespace PBP
{
    partial class FormBuku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuku));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdBuku = new System.Windows.Forms.TextBox();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.txtPengarang = new System.Windows.Forms.TextBox();
            this.txtPenerbit = new System.Windows.Forms.TextBox();
            this.txtTahun = new System.Windows.Forms.TextBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.dataGridViewBuku = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_Analyze = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Judul";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pengarang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Penerbit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tahun";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kategori";
            // 
            // txtIdBuku
            // 
            this.txtIdBuku.Location = new System.Drawing.Point(237, 58);
            this.txtIdBuku.Name = "txtIdBuku";
            this.txtIdBuku.ReadOnly = true;
            this.txtIdBuku.Size = new System.Drawing.Size(251, 22);
            this.txtIdBuku.TabIndex = 6;
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(237, 84);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(251, 22);
            this.txtJudul.TabIndex = 7;
            this.txtJudul.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJudul_KeyPress);
            // 
            // txtPengarang
            // 
            this.txtPengarang.Location = new System.Drawing.Point(237, 111);
            this.txtPengarang.Name = "txtPengarang";
            this.txtPengarang.Size = new System.Drawing.Size(251, 22);
            this.txtPengarang.TabIndex = 8;
            this.txtPengarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPengarang_KeyPress);
            // 
            // txtPenerbit
            // 
            this.txtPenerbit.Location = new System.Drawing.Point(237, 137);
            this.txtPenerbit.Name = "txtPenerbit";
            this.txtPenerbit.Size = new System.Drawing.Size(251, 22);
            this.txtPenerbit.TabIndex = 9;
            this.txtPenerbit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPenerbit_KeyPress);
            // 
            // txtTahun
            // 
            this.txtTahun.Location = new System.Drawing.Point(237, 163);
            this.txtTahun.Name = "txtTahun";
            this.txtTahun.Size = new System.Drawing.Size(251, 22);
            this.txtTahun.TabIndex = 10;
            this.txtTahun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTahun_KeyPress);
            this.txtTahun.Leave += new System.EventHandler(this.txtTahun_Leave);
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(237, 189);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(251, 22);
            this.txtKategori.TabIndex = 11;
            this.txtKategori.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKategori_KeyPress);
            // 
            // dataGridViewBuku
            // 
            this.dataGridViewBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuku.Location = new System.Drawing.Point(37, 266);
            this.dataGridViewBuku.Name = "dataGridViewBuku";
            this.dataGridViewBuku.RowHeadersWidth = 51;
            this.dataGridViewBuku.RowTemplate.Height = 24;
            this.dataGridViewBuku.Size = new System.Drawing.Size(723, 225);
            this.dataGridViewBuku.TabIndex = 15;
            this.dataGridViewBuku.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBuku_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(595, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(595, 111);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(595, 163);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(721, 111);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btn_Analyze
            // 
            this.btn_Analyze.Location = new System.Drawing.Point(595, 224);
            this.btn_Analyze.Name = "btn_Analyze";
            this.btn_Analyze.Size = new System.Drawing.Size(75, 23);
            this.btn_Analyze.TabIndex = 21;
            this.btn_Analyze.Text = "Analyze";
            this.btn_Analyze.UseVisualStyleBackColor = true;
            this.btn_Analyze.Click += new System.EventHandler(this.btn_Analyze_Click);
            // 
            // FormBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.btn_Analyze);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewBuku);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.txtTahun);
            this.Controls.Add(this.txtPenerbit);
            this.Controls.Add(this.txtPengarang);
            this.Controls.Add(this.txtJudul);
            this.Controls.Add(this.txtIdBuku);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBuku";
            this.Text = "FormBuku";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBuku_FormClosing);
            this.Load += new System.EventHandler(this.FormBuku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdBuku;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.TextBox txtPengarang;
        private System.Windows.Forms.TextBox txtPenerbit;
        private System.Windows.Forms.TextBox txtTahun;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.DataGridView dataGridViewBuku;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_Analyze;
    }
}