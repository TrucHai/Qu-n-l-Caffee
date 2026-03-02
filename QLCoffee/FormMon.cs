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
using System.Configuration;

namespace QLCoffee
{
    public partial class FormMon : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLCoffee"].ConnectionString; // gọi kết nối csdl
        SqlConnection conn;
        public FormMon()
        {
            InitializeComponent();
        }
        void LoadMon()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaMon, TenMon, Gia, TrangThai FROM Mon";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMon.DataSource = dt;
            }
        }

        private void FormMon_Load(object sender, EventArgs e)
        {
            LoadMon();

            cbTrangThaiThem.Items.Add("Còn bán");
            cbTrangThaiThem.Items.Add("Hết");

            cbTrangThaiEdit.Items.Add("Còn bán");
            cbTrangThaiEdit.Items.Add("Hết");

        }

        private void dgvMon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "INSERT INTO Mon (TenMon, Gia, TrangThai) VALUES (@ten, @gia, @tt)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ten", txtTenMonThem.Text);
            cmd.Parameters.AddWithValue("@gia", float.Parse(txtGiaThem.Text));
            cmd.Parameters.AddWithValue("@tt", cbTrangThaiThem.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            LoadMon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();

            int maMon = Convert.ToInt32(dgvMon.CurrentRow.Cells["MaMon"].Value);

            string query = "DELETE FROM Mon WHERE MaMon=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", maMon);

            cmd.ExecuteNonQuery();
            conn.Close();

            LoadMon();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();

            int maMon = Convert.ToInt32(dgvMon.CurrentRow.Cells["MaMon"].Value);

            string query = "UPDATE Mon SET TenMon=@ten, Gia=@gia, TrangThai=@tt WHERE MaMon=@id";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ten", txtTenMonSua.Text);
            cmd.Parameters.AddWithValue("@gia", float.Parse(txtGiaSua.Text));
            cmd.Parameters.AddWithValue("@tt", cbTrangThaiEdit.Text);
            cmd.Parameters.AddWithValue("@id", maMon);

            cmd.ExecuteNonQuery();
            conn.Close();

            LoadMon();
        }

        private void dgvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMon.Rows[e.RowIndex];
                txtMaMon.Text = row.Cells["MaMon"].Value.ToString();
                txtTenMonSua.Text = row.Cells["TenMon"].Value.ToString();
                txtGiaSua.Text = row.Cells["Gia"].Value.ToString();
                cbTrangThaiEdit.Text = row.Cells["TrangThai"].Value.ToString();
            }
        }
    }
}
