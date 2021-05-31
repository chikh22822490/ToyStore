
namespace ToyStore.Forms
{
    partial class AddToy
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
            this.cmb_types = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_addToy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.minAge = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maxAge = new System.Windows.Forms.NumericUpDown();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.input_stock = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_provider = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_imagePath = new System.Windows.Forms.TextBox();
            this.btn_imagePath = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_types
            // 
            this.cmb_types.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_types.FormattingEnabled = true;
            this.cmb_types.Location = new System.Drawing.Point(177, 255);
            this.cmb_types.Name = "cmb_types";
            this.cmb_types.Size = new System.Drawing.Size(144, 21);
            this.cmb_types.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancel.Location = new System.Drawing.Point(425, 383);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 31);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_addToy
            // 
            this.btn_addToy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_addToy.Location = new System.Drawing.Point(284, 383);
            this.btn_addToy.Name = "btn_addToy";
            this.btn_addToy.Size = new System.Drawing.Size(75, 31);
            this.btn_addToy.TabIndex = 2;
            this.btn_addToy.Text = "Validate";
            this.btn_addToy.UseVisualStyleBackColor = true;
            this.btn_addToy.Click += new System.EventHandler(this.btn_addToy_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Toy type";
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_name.Location = new System.Drawing.Point(177, 89);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(144, 20);
            this.txt_name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // minAge
            // 
            this.minAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minAge.Location = new System.Drawing.Point(177, 146);
            this.minAge.Name = "minAge";
            this.minAge.Size = new System.Drawing.Size(37, 20);
            this.minAge.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Min-age";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Max-age";
            // 
            // maxAge
            // 
            this.maxAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maxAge.Location = new System.Drawing.Point(284, 146);
            this.maxAge.Name = "maxAge";
            this.maxAge.Size = new System.Drawing.Size(37, 20);
            this.maxAge.TabIndex = 9;
            // 
            // txt_price
            // 
            this.txt_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_price.Location = new System.Drawing.Point(177, 197);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(144, 20);
            this.txt_price.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Price";
            // 
            // input_stock
            // 
            this.input_stock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_stock.Location = new System.Drawing.Point(177, 310);
            this.input_stock.Name = "input_stock";
            this.input_stock.Size = new System.Drawing.Size(144, 20);
            this.input_stock.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stock";
            // 
            // cmb_provider
            // 
            this.cmb_provider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_provider.FormattingEnabled = true;
            this.cmb_provider.Location = new System.Drawing.Point(487, 88);
            this.cmb_provider.Name = "cmb_provider";
            this.cmb_provider.Size = new System.Drawing.Size(219, 21);
            this.cmb_provider.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Provider";
            // 
            // txt_description
            // 
            this.txt_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_description.Location = new System.Drawing.Point(487, 197);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(219, 133);
            this.txt_description.TabIndex = 16;
            this.txt_description.Text = "";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 26);
            this.label8.TabIndex = 17;
            this.label8.Text = "Description\r\n(optional)";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Toy image";
            // 
            // txt_imagePath
            // 
            this.txt_imagePath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_imagePath.Enabled = false;
            this.txt_imagePath.Location = new System.Drawing.Point(487, 145);
            this.txt_imagePath.Name = "txt_imagePath";
            this.txt_imagePath.Size = new System.Drawing.Size(219, 20);
            this.txt_imagePath.TabIndex = 19;
            // 
            // btn_imagePath
            // 
            this.btn_imagePath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_imagePath.Location = new System.Drawing.Point(680, 145);
            this.btn_imagePath.Name = "btn_imagePath";
            this.btn_imagePath.Size = new System.Drawing.Size(26, 20);
            this.btn_imagePath.TabIndex = 20;
            this.btn_imagePath.Text = "...";
            this.btn_imagePath.UseVisualStyleBackColor = true;
            this.btn_imagePath.Click += new System.EventHandler(this.btn_imagePath_Click);
            // 
            // AddToy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_imagePath);
            this.Controls.Add(this.txt_imagePath);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_provider);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.input_stock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.maxAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addToy);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.cmb_types);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "AddToy";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddToy";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddToy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_types;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_addToy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown minAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown maxAge;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown input_stock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_provider;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txt_description;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_imagePath;
        private System.Windows.Forms.Button btn_imagePath;
    }
}