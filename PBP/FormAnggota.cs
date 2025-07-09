using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PBP
{
    public partial class FormAnggota : Form
    {
        private readonly string connStr = ConfigurationManager.ConnectionStrings["PBP.Properties.Settings.PBPConnectionString"].ConnectionString;
        private bool isNavigatingBack = false;

        public FormAnggota()
        {
            InitializeComponent();
        }

        private void FormAnggota_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT id_anggota, nama, alamat, email, no_telepon FROM Anggota ORDER BY nama ASC", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtID.Clear();
            txtNama.Clear();
            txtAlamat.Clear();
            txtEmail.Clear();
            txtTelepon.Clear();
            txtPasswordBaru.Clear();
            txtNama.Focus();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                 string.IsNullOrWhiteSpace(txtAlamat.Text) ||
                 string.IsNullOrWhiteSpace(txtEmail.Text) ||
                 string.IsNullOrWhiteSpace(txtTelepon.Text) ||
                 string.IsNullOrWhiteSpace(txtPasswordBaru.Text))
            {
                MessageBox.Show("Semua field wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("Admin_InsertAnggota", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_nama", txtNama.Text);
                        cmd.Parameters.AddWithValue("@p_alamat", txtAlamat.Text);
                        cmd.Parameters.AddWithValue("@p_email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@p_telp", txtTelepon.Text);
                        cmd.Parameters.AddWithValue("@p_password", txtPasswordBaru.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Data anggota baru berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyimpan data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Pilih data yang akan diupdate dari tabel.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("Admin_UpdateAnggota", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id", txtID.Text);
                        cmd.Parameters.AddWithValue("@p_nama", txtNama.Text);
                        cmd.Parameters.AddWithValue("@p_alamat", txtAlamat.Text);
                        cmd.Parameters.AddWithValue("@p_email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@p_telp", txtTelepon.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Data anggota berhasil diupdate.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearFields();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("Gagal mengupdate: Email yang Anda masukkan sudah digunakan oleh anggota lain.", "Error Duplikasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Gagal mengupdate data karena kesalahan database: {ex.Message}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mengupdate data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells["id_anggota"].Value.ToString();
                txtNama.Text = row.Cells["nama"].Value.ToString();
                txtAlamat.Text = row.Cells["alamat"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtTelepon.Text = row.Cells["no_telepon"].Value.ToString();
                txtPasswordBaru.Clear();
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Pilih anggota yang passwordnya akan di-reset dari tabel.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPasswordBaru.Text))
            {
                MessageBox.Show("Isi password baru di field 'Password Baru'.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPasswordBaru.Text.Length < 8)
            {
                MessageBox.Show("Password baru harus terdiri dari minimal 8 karakter.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show($"Anda yakin ingin mereset password untuk anggota '{txtNama.Text}'?", "Konfirmasi Reset Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("Admin_ResetPasswordAnggota", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@p_newPass", txtPasswordBaru.Text);
                            cmd.Parameters.AddWithValue("@p_id", txtID.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Password berhasil di-reset.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal mereset password: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Pilih data yang akan dihapus dengan mengklik baris pada tabel.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("Admin_DeleteAnggota", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@p_id", txtID.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Data anggota berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearFields();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Gagal menghapus: Anggota ini masih memiliki riwayat peminjaman aktif dan tidak bisa dihapus.", "Error Integritas Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Gagal menghapus data: {ex.Message}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan umum: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormAnggota_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !isNavigatingBack)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormMenuAdmin adminDashboard = Application.OpenForms.OfType<FormMenuAdmin>().FirstOrDefault();
            if (adminDashboard != null)
            {
                adminDashboard.Show(); 
            }

            this.isNavigatingBack = true; 
            this.Close();
        }
        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nama hanya boleh huruf dan spasi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtAlamat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
            !char.IsLetterOrDigit(e.KeyChar) &&
            e.KeyChar != ' ' && e.KeyChar != ',' &&
            e.KeyChar != '.' && e.KeyChar != '/' &&
            e.KeyChar != '-')
            {
                e.Handled = true;
                MessageBox.Show("Alamat hanya boleh berisi huruf, angka, dan simbol umum alamat.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (email.Length == 0)
                return; // biarkan kosong dulu tanpa pesan

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email tidak valid. Contoh: nama@email.com", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nomor telepon hanya boleh angka.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPasswordBaru_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Password hanya boleh huruf dan angka.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}