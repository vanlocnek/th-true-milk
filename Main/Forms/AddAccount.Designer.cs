namespace Main.Forms
{
    partial class AddAccount
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
            this.addAccountTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addAccountTitle
            // 
            this.addAccountTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addAccountTitle.AutoSize = true;
            this.addAccountTitle.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAccountTitle.Location = new System.Drawing.Point(390, 60);
            this.addAccountTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addAccountTitle.Name = "addAccountTitle";
            this.addAccountTitle.Size = new System.Drawing.Size(326, 41);
            this.addAccountTitle.TabIndex = 1;
            this.addAccountTitle.Text = "Thêm Tài Khoản";
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1090, 474);
            this.Controls.Add(this.addAccountTitle);
            this.Name = "AddAccount";
            this.Text = "AddAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addAccountTitle;

    }
}