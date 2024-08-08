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
            this.MinimizeApplicationButton = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.SystemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BillMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DetailBillMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainBody = new System.Windows.Forms.Panel();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseApplicationButton
            // 
            this.CloseApplicationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseApplicationButton.BackColor = System.Drawing.Color.White;
            this.CloseApplicationButton.FlatAppearance.BorderSize = 0;
            this.CloseApplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CloseApplicationButton.ForeColor = System.Drawing.Color.DarkRed;
            this.CloseApplicationButton.Location = new System.Drawing.Point(1226, 29);
            this.CloseApplicationButton.Name = "CloseApplicationButton";
            this.CloseApplicationButton.Size = new System.Drawing.Size(40, 40);
            this.CloseApplicationButton.TabIndex = 0;
            this.CloseApplicationButton.Text = "X";
            this.CloseApplicationButton.UseVisualStyleBackColor = false;
            this.CloseApplicationButton.Click += new System.EventHandler(this.CloseApplicationButton_Click);
            // 
            // MinimizeApplicationButton
            // 
            this.MinimizeApplicationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeApplicationButton.BackColor = System.Drawing.Color.White;
            this.MinimizeApplicationButton.FlatAppearance.BorderSize = 0;
            this.MinimizeApplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MinimizeApplicationButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimizeApplicationButton.Location = new System.Drawing.Point(1180, 29);
            this.MinimizeApplicationButton.Name = "MinimizeApplicationButton";
            this.MinimizeApplicationButton.Size = new System.Drawing.Size(40, 40);
            this.MinimizeApplicationButton.TabIndex = 1;
            this.MinimizeApplicationButton.Text = "-";
            this.MinimizeApplicationButton.UseVisualStyleBackColor = false;
            this.MinimizeApplicationButton.Click += new System.EventHandler(this.MinimizeApplicationButton_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.MenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemMenuItem,
            this.ProductMenuItem,
            this.EmployeeMenuItem,
            this.CustomerMenuItem,
            this.BillMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(227, 9);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(12);
            this.MenuStrip.Size = new System.Drawing.Size(583, 73);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // SystemMenuItem
            // 
            this.SystemMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserListMenuItem,
            this.AddUserMenuItem,
            this.ChangePasswordMenuItem});
            this.SystemMenuItem.Name = "SystemMenuItem";
            this.SystemMenuItem.Padding = new System.Windows.Forms.Padding(12);
            this.SystemMenuItem.Size = new System.Drawing.Size(110, 49);
            this.SystemMenuItem.Text = "Hệ Thống";
            // 
            // ProductMenuItem
            // 
            this.ProductMenuItem.Name = "ProductMenuItem";
            this.ProductMenuItem.Padding = new System.Windows.Forms.Padding(12);
            this.ProductMenuItem.Size = new System.Drawing.Size(108, 49);
            this.ProductMenuItem.Text = "Sản Phẩm";
            // 
            // EmployeeMenuItem
            // 
            this.EmployeeMenuItem.Name = "EmployeeMenuItem";
            this.EmployeeMenuItem.Padding = new System.Windows.Forms.Padding(12);
            this.EmployeeMenuItem.Size = new System.Drawing.Size(112, 49);
            this.EmployeeMenuItem.Text = "Nhân Viên";
            // 
            // CustomerMenuItem
            // 
            this.CustomerMenuItem.Name = "CustomerMenuItem";
            this.CustomerMenuItem.Padding = new System.Windows.Forms.Padding(12);
            this.CustomerMenuItem.Size = new System.Drawing.Size(125, 49);
            this.CustomerMenuItem.Text = "Khách Hàng";
            // 
            // BillMenuItem
            // 
            this.BillMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DetailBillMenuItem});
            this.BillMenuItem.Name = "BillMenuItem";
            this.BillMenuItem.Padding = new System.Windows.Forms.Padding(12);
            this.BillMenuItem.Size = new System.Drawing.Size(102, 49);
            this.BillMenuItem.Text = "Hoá Đơn";
            // 
            // DetailBillMenuItem
            // 
            this.DetailBillMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DetailBillMenuItem.Name = "DetailBillMenuItem";
            this.DetailBillMenuItem.Size = new System.Drawing.Size(152, 26);
            this.DetailBillMenuItem.Text = "Chi Tiết";
            // 
            // AddUserMenuItem
            // 
            this.AddUserMenuItem.Name = "AddUserMenuItem";
            this.AddUserMenuItem.Size = new System.Drawing.Size(194, 26);
            this.AddUserMenuItem.Text = "Thêm Tài Khoản";
            // 
            // ChangePasswordMenuItem
            // 
            this.ChangePasswordMenuItem.Name = "ChangePasswordMenuItem";
            this.ChangePasswordMenuItem.Size = new System.Drawing.Size(194, 26);
            this.ChangePasswordMenuItem.Text = "Đổi Mật Khẩu";
            // 
            // UserListMenuItem
            // 
            this.UserListMenuItem.Name = "UserListMenuItem";
            this.UserListMenuItem.Size = new System.Drawing.Size(194, 26);
            this.UserListMenuItem.Text = "Danh Sách";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.MenuStrip);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.CloseApplicationButton);
            this.panel1.Controls.Add(this.MinimizeApplicationButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 97);
            this.panel1.TabIndex = 0;
            // 
            // MainBody
            // 
            this.MainBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainBody.Location = new System.Drawing.Point(0, 97);
            this.MainBody.Name = "MainBody";
            this.MainBody.Size = new System.Drawing.Size(1280, 494);
            this.MainBody.TabIndex = 1;
            // 
            // PanelDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1280, 591);
            this.ControlBox = false;
            this.Controls.Add(this.MainBody);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "PanelDefault";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Never Give Up";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PanelDefault_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseApplicationButton;
        private System.Windows.Forms.Button MinimizeApplicationButton;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MainBody;


    }
}

