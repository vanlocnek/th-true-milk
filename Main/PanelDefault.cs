using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class PanelDefault : Form
    {
        private string formName;
        public PanelDefault(string formName = null)
        {
            InitializeComponent();
            this.formName = formName;
        }

        private void PanelDefault_Load(object sender, EventArgs e)
        {
            // Truyền tên form trống sẽ báo không hợp lệ
            if (this.formName == null)
            {
                MessageBox.Show("Biến truyền trống!");
                this.Close();
            }

            if (this.formName == "Login")
            {
                Form loginForm = new Main.Forms.Login();
                setFormTitle(loginForm.Text);
                this.MenuStrip.Visible = false;

                loginForm.TopLevel = false;
                loginForm.FormBorderStyle = FormBorderStyle.None;
                loginForm.Dock = DockStyle.Fill;

                this.MainBody.Controls.Clear();
                this.MainBody.Controls.Add(loginForm);
                loginForm.Show();

            }
        }

        private void setFormTitle(string name = "Undefined!") {
            this.Text = name;
        }


        private void MinimizeApplicationButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseApplicationButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
