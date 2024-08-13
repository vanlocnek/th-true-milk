using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Forms
{
    public partial class Login : Form
    {
        public PanelDefault panel;
        public Login(PanelDefault panel)
        {
            InitializeComponent();
            this.panel = panel;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Main.Classes.Validation loginVal = new Main.Classes.Validation(username.Text, password.Text);
            if (loginVal.GetStatus() == 0)
            {
                MessageBox.Show("Thiếu thông tin đăng nhập!");
            }
            else if (loginVal.GetStatus() == 1)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai");
            }
            else if (loginVal.GetStatus() == 2)
            {
                MessageBox.Show("Đăng nhập thành công <3");
                if (loginVal.HasAdmin())
                {
                    MessageBox.Show("Xin chào quản trị viên!");

                }

            }
            else if (loginVal.GetStatus() == 3)
            {
                MessageBox.Show("Người dùng chưa được cấp quyền nào!");
            }
        }
    }
}
