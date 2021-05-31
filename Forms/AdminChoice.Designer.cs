
namespace ToyStore.Forms
{
    partial class AdminChoice
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_providerManagement = new System.Windows.Forms.Button();
            this.btn_bestCashier = new System.Windows.Forms.Button();
            this.btn_profit = new System.Windows.Forms.Button();
            this.btn_sellCancel = new System.Windows.Forms.Button();
            this.btn_toyManagement = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ok = new System.Windows.Forms.Button();
            this.img_admin = new System.Windows.Forms.PictureBox();
            this.lbl_nomAdmin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ToyStore.Properties.Resources.connectBg;
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_providerManagement);
            this.panel1.Controls.Add(this.btn_bestCashier);
            this.panel1.Controls.Add(this.btn_profit);
            this.panel1.Controls.Add(this.btn_sellCancel);
            this.panel1.Controls.Add(this.btn_toyManagement);
            this.panel1.Location = new System.Drawing.Point(319, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 355);
            this.panel1.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(232, 289);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(112, 38);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            // 
            // btn_providerManagement
            // 
            this.btn_providerManagement.Location = new System.Drawing.Point(342, 67);
            this.btn_providerManagement.Name = "btn_providerManagement";
            this.btn_providerManagement.Size = new System.Drawing.Size(112, 42);
            this.btn_providerManagement.TabIndex = 4;
            this.btn_providerManagement.Text = "Providers management";
            this.btn_providerManagement.UseVisualStyleBackColor = true;
            // 
            // btn_bestCashier
            // 
            this.btn_bestCashier.Location = new System.Drawing.Point(113, 202);
            this.btn_bestCashier.Name = "btn_bestCashier";
            this.btn_bestCashier.Size = new System.Drawing.Size(112, 44);
            this.btn_bestCashier.TabIndex = 3;
            this.btn_bestCashier.Text = "Best cashier";
            this.btn_bestCashier.UseVisualStyleBackColor = true;
            this.btn_bestCashier.Click += new System.EventHandler(this.btn_bestCashier_Click);
            // 
            // btn_profit
            // 
            this.btn_profit.Location = new System.Drawing.Point(342, 202);
            this.btn_profit.Name = "btn_profit";
            this.btn_profit.Size = new System.Drawing.Size(112, 44);
            this.btn_profit.TabIndex = 2;
            this.btn_profit.Text = "Profit calculator";
            this.btn_profit.UseVisualStyleBackColor = true;
            this.btn_profit.Click += new System.EventHandler(this.btn_profit_Click);
            // 
            // btn_sellCancel
            // 
            this.btn_sellCancel.Location = new System.Drawing.Point(232, 137);
            this.btn_sellCancel.Name = "btn_sellCancel";
            this.btn_sellCancel.Size = new System.Drawing.Size(112, 45);
            this.btn_sellCancel.TabIndex = 1;
            this.btn_sellCancel.Text = "Sell cancel";
            this.btn_sellCancel.UseVisualStyleBackColor = true;
            this.btn_sellCancel.Click += new System.EventHandler(this.btn_sellCancel_Click);
            // 
            // btn_toyManagement
            // 
            this.btn_toyManagement.Location = new System.Drawing.Point(113, 67);
            this.btn_toyManagement.Name = "btn_toyManagement";
            this.btn_toyManagement.Size = new System.Drawing.Size(112, 42);
            this.btn_toyManagement.TabIndex = 0;
            this.btn_toyManagement.Text = "Toys management";
            this.btn_toyManagement.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_ok);
            this.panel2.Controls.Add(this.img_admin);
            this.panel2.Controls.Add(this.lbl_nomAdmin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(319, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 355);
            this.panel2.TabIndex = 6;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(250, 304);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // img_admin
            // 
            this.img_admin.Location = new System.Drawing.Point(228, 53);
            this.img_admin.Name = "img_admin";
            this.img_admin.Size = new System.Drawing.Size(120, 120);
            this.img_admin.TabIndex = 2;
            this.img_admin.TabStop = false;
            // 
            // lbl_nomAdmin
            // 
            this.lbl_nomAdmin.AutoSize = true;
            this.lbl_nomAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomAdmin.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_nomAdmin.Location = new System.Drawing.Point(249, 237);
            this.lbl_nomAdmin.Name = "lbl_nomAdmin";
            this.lbl_nomAdmin.Size = new System.Drawing.Size(76, 25);
            this.lbl_nomAdmin.TabIndex = 1;
            this.lbl_nomAdmin.Text = "label2";
            this.lbl_nomAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(236, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // AdminChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ToyStore.Properties.Resources._333917;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1200, 720);
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "AdminChoice";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AdminChoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminChoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_admin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btn_logout;
        public System.Windows.Forms.Button btn_providerManagement;
        public System.Windows.Forms.Button btn_bestCashier;
        public System.Windows.Forms.Button btn_profit;
        public System.Windows.Forms.Button btn_sellCancel;
        public System.Windows.Forms.Button btn_toyManagement;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox img_admin;
        private System.Windows.Forms.Label lbl_nomAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ok;
    }
}