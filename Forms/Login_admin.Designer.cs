
namespace ToyStore.Forms
{
    partial class Login_admin
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
            this.btn_exit1 = new System.Windows.Forms.Button();
            this.btn_login1 = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ToyStore.Properties.Resources.connectBg;
            this.panel1.Controls.Add(this.btn_exit1);
            this.panel1.Controls.Add(this.btn_login1);
            this.panel1.Controls.Add(this.txt_pass);
            this.panel1.Controls.Add(this.txt_login);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(413, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 237);
            this.panel1.TabIndex = 1;
            // 
            // btn_exit1
            // 
            this.btn_exit1.Location = new System.Drawing.Point(236, 199);
            this.btn_exit1.Name = "btn_exit1";
            this.btn_exit1.Size = new System.Drawing.Size(75, 23);
            this.btn_exit1.TabIndex = 5;
            this.btn_exit1.Text = "Exit";
            this.btn_exit1.UseVisualStyleBackColor = true;
            // 
            // btn_login1
            // 
            this.btn_login1.Location = new System.Drawing.Point(94, 199);
            this.btn_login1.Name = "btn_login1";
            this.btn_login1.Size = new System.Drawing.Size(75, 23);
            this.btn_login1.TabIndex = 4;
            this.btn_login1.Text = "Login";
            this.btn_login1.UseVisualStyleBackColor = true;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(198, 112);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(100, 20);
            this.txt_pass.TabIndex = 3;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(198, 67);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(100, 20);
            this.txt_login.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(112, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // Login_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ToyStore.Properties.Resources._333917;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1200, 720);
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "Login_admin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Login_admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btn_exit1;
        public System.Windows.Forms.Button btn_login1;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_login;

        public bool exit { get; set; }
    }
}