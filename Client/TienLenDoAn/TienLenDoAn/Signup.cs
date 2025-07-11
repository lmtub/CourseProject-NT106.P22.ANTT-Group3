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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        public string NewUsername { get; private set; }
        private void customButton1_Click(object sender, EventArgs e)
        {
            string entered = txtNewUsername.Text.Trim();
            string password = txtNewPassword.Text;

            if (!string.IsNullOrEmpty(entered) && !string.IsNullOrEmpty(password))
            {
                // Kiểm tra username đã tồn tại chưa
                var existingUser = MongoDBHelper.Users.Find(u => u.Username == entered).FirstOrDefault();
                if (existingUser != null)
                {
                    MessageBox.Show("Tên người dùng đã tồn tại. Hãy chọn tên khác.");
                    return;
                }

                // Thêm user mới
                var newUser = new User { Username = entered, Password = password };
                MongoDBHelper.Users.InsertOne(newUser);

                NewUsername = entered;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
