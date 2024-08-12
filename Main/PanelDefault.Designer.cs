namespace Main
{
    partial class PanelDefault
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelDefault));
            this.CloseApplicationButton = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.SystemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BillMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DetailBillMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainBody = new System.Windows.Forms.Panel();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseApplicationButton
            // 
            this.CloseApplicationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseApplicationButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.CloseApplicationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseApplicationButton.FlatAppearance.BorderSize = 0;
            this.CloseApplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CloseApplicationButton.ForeColor = System.Drawing.Color.White;
            this.CloseApplicationButton.Location = new System.Drawing.Point(1157, 31);
            this.CloseApplicationButton.Margin = new System.Windows.Forms.Padding(4);
            this.CloseApplicationButton.Name = "CloseApplicationButton";
            this.CloseApplicationButton.Size = new System.Drawing.Size(139, 42);
            this.CloseApplicationButton.TabIndex = 0;
            this.CloseApplicationButton.Text = "Đăng xuất";
            this.CloseApplicationButton.UseVisualStyleBackColor = false;
            this.CloseApplicationButton.Click += new System.EventHandler(this.CloseApplicationButton_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.MenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemMenuItem,
            this.ProductMenuItem,
            this.EmployeeMenuItem,
            this.CustomerMenuItem,
            this.BillMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(241, 9);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(15);
            this.MenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MenuStrip.Size = new System.Drawing.Size(693, 86);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // SystemMenuItem
            // 
            this.SystemMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.SystemMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserListMenuItem,
            this.AddUserMenuItem,
            this.ChangePasswordMenuItem});
            this.SystemMenuItem.Name = "SystemMenuItem";
            this.SystemMenuItem.Padding = new System.Windows.Forms.Padding(8);
            this.SystemMenuItem.Size = new System.Drawing.Size(123, 56);
            this.SystemMenuItem.Text = "Hệ Thống";
            // 
            // UserListMenuItem
            // 
            this.UserListMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.UserListMenuItem.Name = "UserListMenuItem";
            this.UserListMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.UserListMenuItem.Size = new System.Drawing.Size(236, 30);
            this.UserListMenuItem.Text = "Danh Sách";
            // 
            // AddUserMenuItem
            // 
            this.AddUserMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.AddUserMenuItem.Name = "AddUserMenuItem";
            this.AddUserMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.AddUserMenuItem.Size = new System.Drawing.Size(236, 30);
            this.AddUserMenuItem.Text = "Thêm Tài Khoản";
            // 
            // ChangePasswordMenuItem
            // 
            this.ChangePasswordMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.ChangePasswordMenuItem.Name = "ChangePasswordMenuItem";
            this.ChangePasswordMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.ChangePasswordMenuItem.Size = new System.Drawing.Size(236, 30);
            this.ChangePasswordMenuItem.Text = "Đổi Mật Khẩu";
            // 
            // ProductMenuItem
            // 
            this.ProductMenuItem.Name = "ProductMenuItem";
            this.ProductMenuItem.Padding = new System.Windows.Forms.Padding(12);
            this.ProductMenuItem.Size = new System.Drawing.Size(131, 56);
            this.ProductMenuItem.Text = "Sản Phẩm";
            this.ProductMenuItem.ToolTipText = "Quản lý sản phẩm";
            // 
            // EmployeeMenuItem
            // 
            this.EmployeeMenuItem.Name = "EmployeeMenuItem";
            this.EmployeeMenuItem.Padding = new System.Windows.Forms.Padding(12);
            this.EmployeeMenuItem.Size = new System.Drawing.Size(136, 56);
            this.EmployeeMenuItem.Text = "Nhân Viên";
            // 
            // CustomerMenuItem
            // 
            this.CustomerMenuItem.Name = "CustomerMenuItem";
            this.CustomerMenuItem.Padding = new System.Windows.Forms.Padding(12);
            this.CustomerMenuItem.Size = new System.Drawing.Size(150, 56);
            this.CustomerMenuItem.Text = "Khách Hàng";
            // 
            // BillMenuItem
            // 
            this.BillMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DetailBillMenuItem});
            this.BillMenuItem.Name = "BillMenuItem";
            this.BillMenuItem.Padding = new System.Windows.Forms.Padding(12);
            this.BillMenuItem.Size = new System.Drawing.Size(121, 56);
            this.BillMenuItem.Text = "Hoá Đơn";
            // 
            // DetailBillMenuItem
            // 
            this.DetailBillMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DetailBillMenuItem.Name = "DetailBillMenuItem";
            this.DetailBillMenuItem.Size = new System.Drawing.Size(159, 32);
            this.DetailBillMenuItem.Text = "Chi Tiết";
            // 
            // Logo
            // 
            this.Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(63, 9);
            this.Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(135, 86);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.MenuStrip);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Controls.Add(this.CloseApplicationButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 105);
            this.panel1.TabIndex = 0;
            // 
            // MainBody
            // 
            this.MainBody.AutoScroll = true;
            this.MainBody.AutoSize = true;
            this.MainBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainBody.Location = new System.Drawing.Point(0, 105);
            this.MainBody.Margin = new System.Windows.Forms.Padding(4);
            this.MainBody.Name = "MainBody";
            this.MainBody.Size = new System.Drawing.Size(1309, 584);
            this.MainBody.TabIndex = 1;
            // 
            // PanelDefault
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1309, 689);
            this.Controls.Add(this.MainBody);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PanelDefault";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Default";
            this.Load += new System.EventHandler(this.PanelDefault_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseApplicationButton;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SystemMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmployeeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BillMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DetailBillMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddUserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordMenuItem;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MainBody;


    }
}

