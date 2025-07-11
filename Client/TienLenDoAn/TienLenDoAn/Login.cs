using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace TienLenDoAn
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void customButton1_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text;

            var existingUser = MongoDBHelper.Users
                .Find(u => u.Username == user && u.Password == pass)
                .FirstOrDefault();

            if (existingUser != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng thử lại.",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            using (var signUpForm = new Signup())
            {
                if (signUpForm.ShowDialog() == DialogResult.OK)
                {
                    // Nếu đăng ký xong, có thể tự động gán username để user login luôn, v.v.
                    txtUsername.Text = signUpForm.NewUsername; // giả sử bạn expose property này
                    txtPassword.Focus();
                }
            }
        }
    }
}
