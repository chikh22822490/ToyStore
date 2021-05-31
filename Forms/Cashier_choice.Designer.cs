
namespace ToyStore.Forms
{
    partial class Cashier_choice
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
            this.button2 = new System.Windows.Forms.Button();
            this.btn_sell = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ok = new System.Windows.Forms.Button();
            this.img_cashier = new System.Windows.Forms.PictureBox();
            this.lbl_nomCashier = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_cashier)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ToyStore.Properties.Resources.connectBg;
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_sell);
            this.panel1.Location = new System.Drawing.Point(414, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 249);
            this.panel1.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(157, 169);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(94, 43);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Previous sales";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_sell
            // 
            this.btn_sell.Location = new System.Drawing.Point(75, 73);
            this.btn_sell.Name = "btn_sell";
            this.btn_sell.Size = new System.Drawing.Size(91, 43);
            this.btn_sell.TabIndex = 0;
            this.btn_sell.Text = "New sale";
            this.btn_sell.UseVisualStyleBackColor = true;
            this.btn_sell.Click += new System.EventHandler(this.btn_sell_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btn_ok);
            this.panel2.Controls.Add(this.img_cashier);
            this.panel2.Controls.Add(this.lbl_nomCashier);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(329, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 355);
            this.panel2.TabIndex = 7;
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
            // img_cashier
            // 
            this.img_cashier.Location = new System.Drawing.Point(228, 53);
            this.img_cashier.Name = "img_cashier";
            this.img_cashier.Size = new System.Drawing.Size(120, 120);
            this.img_cashier.TabIndex = 2;
            this.img_cashier.TabStop = false;
            // 
            // lbl_nomCashier
            // 
            this.lbl_nomCashier.AutoSize = true;
            this.lbl_nomCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomCashier.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_nomCashier.Location = new System.Drawing.Point(249, 237);
            this.lbl_nomCashier.Name = "lbl_nomCashier";
            this.lbl_nomCashier.Size = new System.Drawing.Size(76, 25);
            this.lbl_nomCashier.TabIndex = 1;
            this.lbl_nomCashier.Text = "label2";
            this.lbl_nomCashier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // Cashier_choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1200, 720);
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "Cashier_choice";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cashier_choice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cashier_choice_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_cashier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_sell;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.PictureBox img_cashier;
        private System.Windows.Forms.Label lbl_nomCashier;
        private System.Windows.Forms.Label label1;
    }
}