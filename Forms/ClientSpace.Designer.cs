
namespace ToyStore.Forms
{
    partial class ClientSpace
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_apply = new System.Windows.Forms.Button();
            this.grpBoxPrice = new System.Windows.Forms.GroupBox();
            this.rdb_price4 = new System.Windows.Forms.RadioButton();
            this.rdb_price3 = new System.Windows.Forms.RadioButton();
            this.rdb_price2 = new System.Windows.Forms.RadioButton();
            this.rdb_price1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.in_maxAge = new System.Windows.Forms.NumericUpDown();
            this.in_minAge = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.toy_list = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBoxPrice.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.in_maxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_minAge)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 680);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.btn_exit);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_apply);
            this.groupBox1.Controls.Add(this.grpBoxPrice);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(22, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 610);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Use filters";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(61, 555);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 36);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(104, 493);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(80, 35);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "Reset filter";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(17, 493);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(81, 35);
            this.btn_apply.TabIndex = 3;
            this.btn_apply.Text = "Apply filter";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // grpBoxPrice
            // 
            this.grpBoxPrice.Controls.Add(this.rdb_price4);
            this.grpBoxPrice.Controls.Add(this.rdb_price3);
            this.grpBoxPrice.Controls.Add(this.rdb_price2);
            this.grpBoxPrice.Controls.Add(this.rdb_price1);
            this.grpBoxPrice.Location = new System.Drawing.Point(17, 333);
            this.grpBoxPrice.Name = "grpBoxPrice";
            this.grpBoxPrice.Size = new System.Drawing.Size(167, 143);
            this.grpBoxPrice.TabIndex = 2;
            this.grpBoxPrice.TabStop = false;
            this.grpBoxPrice.Text = "Price";
            // 
            // rdb_price4
            // 
            this.rdb_price4.AutoSize = true;
            this.rdb_price4.Location = new System.Drawing.Point(38, 111);
            this.rdb_price4.Name = "rdb_price4";
            this.rdb_price4.Size = new System.Drawing.Size(70, 17);
            this.rdb_price4.TabIndex = 3;
            this.rdb_price4.TabStop = true;
            this.rdb_price4.Text = " >  100  €";
            this.rdb_price4.UseVisualStyleBackColor = true;
            // 
            // rdb_price3
            // 
            this.rdb_price3.AutoSize = true;
            this.rdb_price3.Location = new System.Drawing.Point(38, 82);
            this.rdb_price3.Name = "rdb_price3";
            this.rdb_price3.Size = new System.Drawing.Size(91, 17);
            this.rdb_price3.TabIndex = 2;
            this.rdb_price3.TabStop = true;
            this.rdb_price3.Text = "51  -->  100  €";
            this.rdb_price3.UseVisualStyleBackColor = true;
            // 
            // rdb_price2
            // 
            this.rdb_price2.AutoSize = true;
            this.rdb_price2.Location = new System.Drawing.Point(38, 52);
            this.rdb_price2.Name = "rdb_price2";
            this.rdb_price2.Size = new System.Drawing.Size(85, 17);
            this.rdb_price2.TabIndex = 1;
            this.rdb_price2.TabStop = true;
            this.rdb_price2.Text = "21  -->  50  €";
            this.rdb_price2.UseVisualStyleBackColor = true;
            // 
            // rdb_price1
            // 
            this.rdb_price1.AutoSize = true;
            this.rdb_price1.Location = new System.Drawing.Point(38, 26);
            this.rdb_price1.Name = "rdb_price1";
            this.rdb_price1.Size = new System.Drawing.Size(79, 17);
            this.rdb_price1.TabIndex = 0;
            this.rdb_price1.TabStop = true;
            this.rdb_price1.Text = "0  -->  20  €";
            this.rdb_price1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.in_maxAge);
            this.groupBox3.Controls.Add(this.in_minAge);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(17, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Age";
            // 
            // in_maxAge
            // 
            this.in_maxAge.Location = new System.Drawing.Point(109, 57);
            this.in_maxAge.Name = "in_maxAge";
            this.in_maxAge.Size = new System.Drawing.Size(40, 20);
            this.in_maxAge.TabIndex = 3;
            // 
            // in_minAge
            // 
            this.in_minAge.Location = new System.Drawing.Point(21, 58);
            this.in_minAge.Name = "in_minAge";
            this.in_minAge.Size = new System.Drawing.Size(42, 20);
            this.in_minAge.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age min";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Location = new System.Drawing.Point(17, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 160);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toy type";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(18, 20);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(131, 124);
            this.checkedListBox1.TabIndex = 0;
            // 
            // toy_list
            // 
            this.toy_list.AutoScroll = true;
            this.toy_list.BackColor = System.Drawing.Color.Transparent;
            this.toy_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toy_list.Location = new System.Drawing.Point(250, 40);
            this.toy_list.Margin = new System.Windows.Forms.Padding(0);
            this.toy_list.Name = "toy_list";
            this.toy_list.Size = new System.Drawing.Size(950, 680);
            this.toy_list.TabIndex = 1;
            // 
            // ClientSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ToyStore.Properties.Resources._333917;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.ControlBox = false;
            this.Controls.Add(this.toy_list);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientSpace";
            this.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ClientSpace";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ClientSpace_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grpBoxPrice.ResumeLayout(false);
            this.grpBoxPrice.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.in_maxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_minAge)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel toy_list;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpBoxPrice;
        private System.Windows.Forms.RadioButton rdb_price4;
        private System.Windows.Forms.RadioButton rdb_price3;
        private System.Windows.Forms.RadioButton rdb_price2;
        private System.Windows.Forms.RadioButton rdb_price1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown in_maxAge;
        private System.Windows.Forms.NumericUpDown in_minAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_apply;
        public System.Windows.Forms.Button btn_exit;
    }
}