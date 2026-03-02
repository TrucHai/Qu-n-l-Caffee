using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCoffee.DTO;
using QLCoffee.BUS;

namespace QLCoffee
{
    public partial class FormLogin : Form
    {
        private AccountBUS accountBUS = new AccountBUS();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AccountDTO account = new AccountDTO(
                txtUsername.Text,
                txtPassword.Text
            );

            string role = accountBUS.Login(account);

            if (role != null)
            {
                FormMain main = new FormMain(role);

                this.Hide();           // Ẩn Login
                main.ShowDialog();     // Mở FormMain
                this.Close();          // Đóng Login khi Main đóng
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
