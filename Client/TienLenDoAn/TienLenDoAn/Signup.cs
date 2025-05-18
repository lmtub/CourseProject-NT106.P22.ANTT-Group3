using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (!string.IsNullOrEmpty(entered))
            {
                NewUsername = entered;          // Gán username mới cho property
                this.DialogResult = DialogResult.OK;
                this.Close();                  // Đóng form, trả về OK cho caller
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên đăng ký.");
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
