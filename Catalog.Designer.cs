
namespace ToyStore
{
    partial class Catalog
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.img_toy = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_minAge = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_maxAge = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_toy)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.img_toy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(150, 150);
            this.panel1.TabIndex = 0;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // img_toy
            // 
            this.img_toy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img_toy.ErrorImage = null;
            this.img_toy.InitialImage = null;
            this.img_toy.Location = new System.Drawing.Point(10, 10);
            this.img_toy.Name = "img_toy";
            this.img_toy.Size = new System.Drawing.Size(130, 130);
            this.img_toy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_toy.TabIndex = 0;
            this.img_toy.TabStop = false;
            this.img_toy.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.img_toy.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.lblStock);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(780, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 150);
            this.panel2.TabIndex = 1;
            this.panel2.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(44, 97);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(68, 18);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "In stock";
            this.lblStock.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.lblStock.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "€";
            this.label1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(22, 50);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(74, 20);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "00.00";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPrice.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.lblPrice.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(53, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price";
            this.label3.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblName.Location = new System.Drawing.Point(169, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "product name";
            this.lblName.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.lblName.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(170, 58);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(602, 81);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "desctiption";
            this.lblDescription.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.lblDescription.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblType.Location = new System.Drawing.Point(170, 35);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(129, 20);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type";
            this.lblType.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.lblType.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(303, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "[";
            this.label2.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // lbl_minAge
            // 
            this.lbl_minAge.AutoSize = true;
            this.lbl_minAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minAge.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_minAge.Location = new System.Drawing.Point(316, 35);
            this.lbl_minAge.Name = "lbl_minAge";
            this.lbl_minAge.Size = new System.Drawing.Size(15, 16);
            this.lbl_minAge.TabIndex = 6;
            this.lbl_minAge.Text = "3";
            this.lbl_minAge.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.lbl_minAge.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(335, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "-";
            this.label7.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.label7.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // lbl_maxAge
            // 
            this.lbl_maxAge.AutoSize = true;
            this.lbl_maxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maxAge.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_maxAge.Location = new System.Drawing.Point(348, 35);
            this.lbl_maxAge.Name = "lbl_maxAge";
            this.lbl_maxAge.Size = new System.Drawing.Size(15, 16);
            this.lbl_maxAge.TabIndex = 10;
            this.lbl_maxAge.Text = "3";
            this.lbl_maxAge.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.lbl_maxAge.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(365, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "] Years";
            this.label6.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.label6.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_maxAge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_minAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Catalog";
            this.Size = new System.Drawing.Size(930, 150);
            this.Load += new System.EventHandler(this.panel1_MouseLeave);
            this.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_toy)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox img_toy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_minAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_maxAge;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblStock;
    }
}
