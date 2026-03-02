using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;  // kết nối csdl ở App.cofig

namespace QLCoffee
{
    public partial class FormMain : Form
    {
        int maBanDangChon = 0;
        string userRole;
        string connectionString = ConfigurationManager.ConnectionStrings["QLCoffee"].ConnectionString; // gọi để kn csdl
        double tongTien = 0;
        double giamGia = 0;
        const int MA_BAN_MANG_VE = 3; ///bàn ảo
        string oldUsername = "";

        public FormMain(string role)
        {
            InitializeComponent();
            userRole = role;
        }
        void ResetAccountForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            cbRole.SelectedIndex = 0;
            txtUsername.Focus();
        }
        private void LoadBan()
        {
            flowLayoutPanelBan.Controls.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Ban WHERE MaBan <> 3";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Button btn = new Button();
                    btn.Width = 90;
                    btn.Height = 90;

                    btn.Text = reader["TenBan"].ToString();
                    btn.Tag = reader["MaBan"];

                    string trangThai = reader["TrangThai"].ToString();

                    if (trangThai == "Trống")
                        btn.BackColor = Color.White;
                    else
                        btn.BackColor = Color.Red;  // Chưa thanh toán

                    btn.Click += Btn_Click;

                    flowLayoutPanelBan.Controls.Add(btn);
                }
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            maBanDangChon = Convert.ToInt32(btn.Tag);

            labelBanDangChon.Text = "Bàn đang chọn: " + btn.Text;
            // Cập nhật Bàn số trong chi tiết hóa đơn
            lblBan.Text = "Bàn số: " + maBanDangChon;
            LoadHoaDonTheoBan(maBanDangChon);
        }
        void LoadAccount()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT Username, Password, Role FROM Account WHERE IsActive = 1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvAccount.DataSource = dt;
            }
        }
        void LoadMon(string keyword = "")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT MaMon, TenMon, Gia FROM Mon";

                if (!string.IsNullOrEmpty(keyword))
                {
                    query += " WHERE TenMon LIKE @kw";
                }

                SqlCommand cmd = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(keyword))
                {
                    cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvMon.DataSource = dt;
            }
        }
        void LoadNhanVien()
        {
            string query = "SELECT Id, Username FROM Account WHERE Role = N'Nhân viên' AND IsActive = 1";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cbNhanVien.DataSource = dt;
                cbNhanVien.DisplayMember = "Username";   // dùng Username
                cbNhanVien.ValueMember = "Id";
            }
        }
        void CapNhatSTT()
        {
            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                dgvHoaDon.Rows[i].Cells["colSTT"].Value = i + 1;
            }
        }
        private void TinhTongTien()
        {
            tongTien = 0;

            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                if (row.Cells["colThanhTien"].Value != null)
                {
                    tongTien += Convert.ToDouble(row.Cells["colThanhTien"].Value);
                }
            }

            lblTotalPrice.Text = tongTien.ToString("N0");
        }
        void TinhThanhTien()
        {
            double tong = tongTien;

            double giamPhanTram = (double)nmDiscount.Value;

            double thanhTien = tong - (tong * giamPhanTram / 100);

            if (thanhTien < 0)
                thanhTien = 0;

            txtThanhTien.Text = thanhTien.ToString("N0");
        }
        int LayHoaDonChuaThanhToan(int maBan)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT MaHoaDon 
                         FROM HoaDon 
                         WHERE MaBan = @MaBan 
                         AND TrangThai = 0";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaBan", maBan);

                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }
        void LoadHoaDonTheoBan(int maBan)
        {
            dgvHoaDon.Rows.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 🔥 Lấy hóa đơn chưa thanh toán của bàn
                string getHD = @"SELECT MaHoaDon 
                         FROM HoaDon 
                         WHERE MaBan = @MaBan AND TrangThai = 0";

                SqlCommand cmdHD = new SqlCommand(getHD, conn);
                cmdHD.Parameters.AddWithValue("@MaBan", maBan);

                object resultHD = cmdHD.ExecuteScalar();

                if (resultHD == null)
                    return;

                int maHoaDon = Convert.ToInt32(resultHD);

                // 🔥 JOIN với bảng Mon để lấy TenMon
                string query = @"
            SELECT m.TenMon,
                   cthd.DonGia,
                   cthd.SoLuong,
                   cthd.ThanhTien
            FROM ChiTietHoaDon cthd
            JOIN Mon m ON cthd.MaMon = m.MaMon
            WHERE cthd.MaHoaDon = @MaHD";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHD", maHoaDon);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dgvHoaDon.Rows.Add(
                        null,
                        reader["TenMon"],
                        reader["DonGia"],
                        reader["SoLuong"],
                        reader["ThanhTien"]
                    );
                }
            }

            CapNhatSTT();
            TinhTongTien();
            TinhThanhTien();
        }
        public FormMain()
        {
            InitializeComponent();
        }

        private void tabAccount_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            rbTaiCho.Checked = true;
            cbRole.Items.Add("Admin");
            cbRole.Items.Add("Nhân viên");
            cbRole.SelectedIndex = 0;

            LoadAccount();
            if (userRole == "Nhân viên")
            {
                tabMain.TabPages.Remove(tabAccount);
                tabMain.TabPages.Remove(tabQuanLy);
            }
            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadBan();
            labelBanDangChon.Text = "Bàn đang chọn: Chưa chọn bàn";

            dgvHoaDon.ReadOnly = false;
            foreach (DataGridViewColumn col in dgvHoaDon.Columns)
            {
                col.ReadOnly = true;   // khóa tất cả
            }
            // Mở riêng cột số lượng
            dgvHoaDon.Columns["colSoLuong"].ReadOnly = false;

            dtpNgayVao.Value = DateTime.Now;
            LoadNhanVien();
            cbGiamGia.SelectedIndex = 0;
            nmDiscount.ValueChanged += (s, ev) => TinhThanhTien();
            cbGiamGia.SelectedIndexChanged += (s, ev) => TinhThanhTien();

            LoadMon();
            dgvMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO Account (Username,Password,Role,IsActive)\r\nVALUES (@user,@pass,@role,1)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                cmd.Parameters.AddWithValue("@role", cbRole.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Thêm thành công!");
            LoadAccount();
            LoadNhanVien();
            ResetAccountForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"UPDATE Account 
                 SET Username=@newUser, Password=@pass, Role=@role 
                 WHERE Username=@oldUser";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@newUser", txtUsername.Text);
                cmd.Parameters.AddWithValue("@oldUser", oldUsername);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                cmd.Parameters.AddWithValue("@role", cbRole.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Sửa thành công!");
            LoadAccount();
            LoadNhanVien();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE Account SET IsActive = 0 WHERE Username=@user";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Đã vô hiệu hóa tài khoản!");
            LoadAccount();
            LoadNhanVien();
            ResetAccountForm();
        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            bool laMangVe = rbMangVe.Checked;

            if (!laMangVe && maBanDangChon == 0)
            {
                MessageBox.Show("Vui lòng chọn bàn trước!");
                return;
            }

            if (dgvMon.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn món!");
                return;
            }

            int maMon = Convert.ToInt32(dgvMon.CurrentRow.Cells["MaMon"].Value);
            decimal donGia = Convert.ToDecimal(dgvMon.CurrentRow.Cells["Gia"].Value);
            int soLuong = (int)numSoLuong.Value;

            if (soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!");
                return;
            }
            int maBanSuDung;

            if (rbMangVe.Checked)
            {
                maBanSuDung = MA_BAN_MANG_VE;
            }
            else
            {
                maBanSuDung = maBanDangChon;
            }

            int maHoaDon = LayHoaDonChuaThanhToan(maBanSuDung);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1️⃣ Nếu chưa có hóa đơn → tạo mới
                if (maHoaDon == -1)
                {
                    string insertHD = @"INSERT INTO HoaDon
                    (MaBan, AccountId, NgayVao, TrangThai, LoaiHoaDon)
                    VALUES (@MaBan, @AccountId, GETDATE(), 0, @Loai);
                    SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdInsertHD = new SqlCommand(insertHD, conn);
                    string loaiHoaDon = rbMangVe.Checked ? "Mang về" : "Tại chỗ";

                    cmdInsertHD.Parameters.AddWithValue("@Loai", loaiHoaDon);

                    cmdInsertHD.Parameters.AddWithValue("@MaBan", maBanSuDung);
                    cmdInsertHD.Parameters.AddWithValue("@AccountId", cbNhanVien.SelectedValue);
                    maHoaDon = Convert.ToInt32(cmdInsertHD.ExecuteScalar());
                }

                // 2️⃣ Kiểm tra món đã tồn tại chưa
                string checkMon = @"SELECT SoLuong 
                                    FROM ChiTietHoaDon
                                    WHERE MaHoaDon = @MaHD AND MaMon = @MaMon";

                SqlCommand cmdCheck = new SqlCommand(checkMon, conn);
                cmdCheck.Parameters.AddWithValue("@MaHD", maHoaDon);
                cmdCheck.Parameters.AddWithValue("@MaMon", maMon);


                object result = cmdCheck.ExecuteScalar();

                if (result != null)
                {
                    // 3️⃣ Nếu tồn tại → cộng dồn
                    int slCu = Convert.ToInt32(result);
                    int slMoi = slCu + soLuong;

                    string updateCT = @"UPDATE ChiTietHoaDon
                            SET SoLuong = @SoLuong WHERE MaHoaDon = @MaHD AND MaMon = @MaMon";

                    SqlCommand cmdUpdate = new SqlCommand(updateCT, conn);
                    cmdUpdate.Parameters.AddWithValue("@SoLuong", slMoi);
                    cmdUpdate.Parameters.AddWithValue("@MaHD", maHoaDon);
                    cmdUpdate.Parameters.AddWithValue("@MaMon", maMon);
                    cmdUpdate.ExecuteNonQuery();
                }
                else
                {
                            // 4️⃣ Nếu chưa có → thêm mới
                    string insertCT = @"INSERT INTO ChiTietHoaDon (MaHoaDon, MaMon, SoLuong, DonGia) VALUES (@MaHD,@MaMon,@SoLuong,@DonGia)";

                            SqlCommand cmdInsert = new SqlCommand(insertCT, conn);
                    cmdInsert.Parameters.AddWithValue("@MaHD", maHoaDon);
                    cmdInsert.Parameters.AddWithValue("@MaMon", maMon);
                    cmdInsert.Parameters.AddWithValue("@SoLuong", soLuong);
                    cmdInsert.Parameters.AddWithValue("@DonGia", donGia);
                    cmdInsert.ExecuteNonQuery();
                }

                // 5️⃣ Cập nhật trạng thái bàn
                if (!rbMangVe.Checked)
                {
                    string updateBan = "UPDATE Ban SET TrangThai = N'Có khách' WHERE MaBan = @MaBan";
                    SqlCommand cmdBan = new SqlCommand(updateBan, conn);
                    cmdBan.Parameters.AddWithValue("@MaBan", maBanSuDung);
                    cmdBan.ExecuteNonQuery();
                }
                
            }

            // Load lại hóa đơn
            LoadHoaDonTheoBan(maBanSuDung);

            LoadBan();
            TinhTongTien();
            TinhThanhTien();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow != null)
            {
                dgvHoaDon.Rows.Remove(dgvHoaDon.CurrentRow);

                CapNhatSTT();
                TinhTongTien();
                TinhThanhTien();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow != null)
            {
                dgvHoaDon.BeginEdit(true);
            }
        }

        private void dgvHoaDon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvHoaDon.Columns["colSoLuong"].Index)
            {
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];

                decimal donGia = Convert.ToDecimal(row.Cells["colDonGia"].Value);
                int soLuong = Convert.ToInt32(row.Cells["colSoLuong"].Value);

                row.Cells["colThanhTien"].Value = donGia * soLuong;

                TinhTongTien();
                TinhThanhTien();
            }
        }

        private void nmDiscount_ValueChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int maBanSuDung = rbMangVe.Checked ? MA_BAN_MANG_VE : maBanDangChon;
            int maHoaDon = LayHoaDonChuaThanhToan(maBanSuDung);
            if (maHoaDon == -1)
            {
                MessageBox.Show("Không có hóa đơn để thanh toán!");
                return;
            }

            TinhTongTien();
            TinhThanhTien();

            double thanhTien = double.Parse(txtThanhTien.Text.Replace(",", ""));

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string updateHD = @"UPDATE HoaDon
                            SET TrangThai = 1,
                                NgayRa = GETDATE(),
                                GiamGia = @GiamGia,
                                TongTien = @TongTien
                            WHERE MaHoaDon = @MaHD";

                SqlCommand cmd = new SqlCommand(updateHD, conn);
                cmd.Parameters.AddWithValue("@MaHD", maHoaDon);
                cmd.Parameters.AddWithValue("@GiamGia", nmDiscount.Value);
                cmd.Parameters.AddWithValue("@TongTien", thanhTien);
                cmd.ExecuteNonQuery();

                if (!rbMangVe.Checked)
                {
                    string updateBan = "UPDATE Ban SET TrangThai = N'Trống' WHERE MaBan = @MaBan";
                    SqlCommand cmdBan = new SqlCommand(updateBan, conn);
                    cmdBan.Parameters.AddWithValue("@MaBan", maBanSuDung);
                    cmdBan.ExecuteNonQuery();
                }
                
            }

            MessageBox.Show("Thanh toán thành công!");
            // Reset trạng thái
            maBanDangChon = 0;
            labelBanDangChon.Text = "Bàn đang chọn: Chưa chọn bàn";
            lblBan.Text = "Bàn số: ";
            LoadBan();
            dgvHoaDon.Rows.Clear();
            TinhTongTien();
            TinhThanhTien();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadMon(txtTim.Text.Trim());
        }

        private void btnQuanLyMon_Click(object sender, EventArgs e)
        {
            FormMon f = new FormMon();
            f.ShowDialog();
            LoadMon();
        }

        private void btnQuanLyBan_Click(object sender, EventArgs e)
        {
            FormBan f = new FormBan();
            f.ShowDialog();
            LoadBan();
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAccount.CurrentRow != null)
            {
                txtUsername.Text = dgvAccount.CurrentRow.Cells["Username"].Value.ToString();
                txtPassword.Text = dgvAccount.CurrentRow.Cells["Password"].Value.ToString();
                cbRole.Text = dgvAccount.CurrentRow.Cells["Role"].Value.ToString();

                oldUsername = txtUsername.Text;

                // Nếu là Admin thì không cho sửa Username
                if (cbRole.Text == "Admin")
                {
                    txtUsername.Enabled = false;
                }
                else
                {
                    txtUsername.Enabled = true;
                }
            }
        }
    }
}
