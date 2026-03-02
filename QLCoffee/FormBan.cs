using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLCoffee
{
    public partial class FormBan : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLCoffee"].ConnectionString; // gọi kết nối csdl
        void LoadBan()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Ban";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBan.DataSource = dt;
            }
        }
        public FormBan()
        {
            InitializeComponent();
        }

        private void FormBan_Load(object sender, EventArgs e)
        {
            cbTrangThai.Items.Add("Trống");
            cbTrangThai.Items.Add("Có khách");
            cbTrangThai.SelectedIndex = 0;

            LoadBan();
        }

        private void dgvBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTenBan.Text = dgvBan.Rows[e.RowIndex].Cells["TenBan"].Value.ToString();
                cbTrangThai.Text = dgvBan.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();
            }
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Ban (TenBan, TrangThai) VALUES (@TenBan, @TrangThai)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@TenBan", txtTenBan.Text);
                cmd.Parameters.AddWithValue("@TrangThai", cbTrangThai.Text);

                cmd.ExecuteNonQuery();
            }

            LoadBan();
        }

        private void btnSuaBan_Click(object sender, EventArgs e)
        {
            if (dgvBan.CurrentRow == null) return;

            int maBan = Convert.ToInt32(dgvBan.CurrentRow.Cells["MaBan"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Ban SET TenBan=@TenBan, TrangThai=@TrangThai WHERE MaBan=@MaBan";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@TenBan", txtTenBan.Text);
                cmd.Parameters.AddWithValue("@TrangThai", cbTrangThai.Text);
                cmd.Parameters.AddWithValue("@MaBan", maBan);

                cmd.ExecuteNonQuery();
            }

            LoadBan();
        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            if (dgvBan.CurrentRow == null) return;

            int maBan = Convert.ToInt32(dgvBan.CurrentRow.Cells["MaBan"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Ban WHERE MaBan=@MaBan";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaBan", maBan);
                cmd.ExecuteNonQuery();
            }

            LoadBan();
        }
    }
}
