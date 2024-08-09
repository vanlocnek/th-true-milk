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
        private DBS dbs;
        public PanelDefault(string formName = null)
        {
            InitializeComponent();
            this.formName = formName;
            this.dbs = new DBS();
        }

        private void PanelDefault_Load(object sender, EventArgs e)
        {
            UpdatePanel();
            this.dbs.TestConnect();
        }

        public void UpdatePanel()
        {
            // Truyền tên form trống sẽ báo không hợp lệ
            if (this.formName == null)
            {
                MessageBox.Show("Biến truyền trống!");
                this.Close();
            }

            if (this.formName == "Login")
            {
                RunChildForm(new Main.Forms.Login(this));
                this.MenuStrip.Visible = false;
                this.CloseApplicationButton.Visible = false;
                this.Logo.Visible = false;
            }
            else if (this.formName == "AddAccount")
            {
                RunChildForm(new Main.Forms.AddAccount());
            }
            else if (this.formName == "Home")
            {
                RunChildForm(new Main.Forms.Home());
            }
            else
            {
                MessageBox.Show("Form không tồn tại!!!", "Có lỗi khi xử lý!");
            }
        }

        public void RunChildForm(Form form) {
            setFormTitle(form.Text);
            this.MenuStrip.Visible = true;
            this.CloseApplicationButton.Visible = true;
            this.Logo.Visible = true;

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            this.MainBody.Controls.Clear();
            this.MainBody.Controls.Add(form);
            form.Show();
        }

        public void setFormName(string name)
        {
            this.formName = name;
            UpdatePanel();
        }

        private void setFormTitle(string name = "Undefined!") {
            this.Text = name;
        }

        private void CloseApplicationButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            setFormName("Home");
        }
    }
}
