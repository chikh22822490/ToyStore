
namespace ToyStore.Forms
{
    partial class ModifyToy
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
            this.label1 = new System.Windows.Forms.Label();
            this.dGV_toys = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_prix = new System.Windows.Forms.TextBox();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_provider = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_min = new System.Windows.Forms.NumericUpDown();
            this.txt_max = new System.Windows.Forms.NumericUpDown();
            this.txt_stock = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pic_img = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_modif = new System.Windows.Forms.Button();
            this.bt_quitter = new System.Windows.Forms.Button();
            this.txt_image = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_toys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_img)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(313, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modify toy";
            // 
            // dGV_toys
            // 
            this.dGV_toys.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_toys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_toys.Location = new System.Drawing.Point(12, 104);
            this.dGV_toys.Name = "dGV_toys";
            this.dGV_toys.Size = new System.Drawing.Size(776, 138);
            this.dGV_toys.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select a toy to show image and description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(101, 262);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(121, 20);
            this.txt_nom.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // txt_prix
            // 
            this.txt_prix.Location = new System.Drawing.Point(101, 304);
            this.txt_prix.Name = "txt_prix";
            this.txt_prix.Size = new System.Drawing.Size(121, 20);
            this.txt_prix.TabIndex = 6;
            // 
            // cmb_type
            // 
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(101, 351);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(121, 21);
            this.cmb_type.TabIndex = 7;
            this.cmb_type.SelectedIndexChanged += new System.EventHandler(this.cmb_type_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type";
            // 
            // cmb_provider
            // 
            this.cmb_provider.FormattingEnabled = true;
            this.cmb_provider.Location = new System.Drawing.Point(101, 390);
            this.cmb_provider.Name = "cmb_provider";
            this.cmb_provider.Size = new System.Drawing.Size(121, 21);
            this.cmb_provider.TabIndex = 9;
            this.cmb_provider.SelectedIndexChanged += new System.EventHandler(this.cmb_provider_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Provider";
            // 
            // txt_min
            // 
            this.txt_min.Location = new System.Drawing.Point(319, 281);
            this.txt_min.Name = "txt_min";
            this.txt_min.Size = new System.Drawing.Size(93, 20);
            this.txt_min.TabIndex = 11;
            // 
            // txt_max
            // 
            this.txt_max.Location = new System.Drawing.Point(319, 326);
            this.txt_max.Name = "txt_max";
            this.txt_max.Size = new System.Drawing.Size(93, 20);
            this.txt_max.TabIndex = 12;
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(319, 370);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(93, 20);
            this.txt_stock.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Min Age";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Max Age";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Stock";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(463, 287);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(154, 140);
            this.txt_desc.TabIndex = 17;
            this.txt_desc.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(460, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Description";
            // 
            // pic_img
            // 
            this.pic_img.Location = new System.Drawing.Point(637, 287);
            this.pic_img.Name = "pic_img";
            this.pic_img.Size = new System.Drawing.Size(140, 140);
            this.pic_img.TabIndex = 19;
            this.pic_img.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(637, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Image";
            // 
            // bt_modif
            // 
            this.bt_modif.Location = new System.Drawing.Point(232, 452);
            this.bt_modif.Name = "bt_modif";
            this.bt_modif.Size = new System.Drawing.Size(115, 36);
            this.bt_modif.TabIndex = 21;
            this.bt_modif.Text = "Modify";
            this.bt_modif.UseVisualStyleBackColor = true;
            this.bt_modif.Click += new System.EventHandler(this.bt_modif_Click);
            // 
            // bt_quitter
            // 
            this.bt_quitter.Location = new System.Drawing.Point(434, 452);
            this.bt_quitter.Name = "bt_quitter";
            this.bt_quitter.Size = new System.Drawing.Size(115, 36);
            this.bt_quitter.TabIndex = 22;
            this.bt_quitter.Text = "Cancel";
            this.bt_quitter.UseVisualStyleBackColor = true;
            this.bt_quitter.Click += new System.EventHandler(this.bt_quitter_Click);
            // 
            // txt_image
            // 
            this.txt_image.Location = new System.Drawing.Point(637, 433);
            this.txt_image.Name = "txt_image";
            this.txt_image.Size = new System.Drawing.Size(140, 20);
            this.txt_image.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(748, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 20);
            this.button1.TabIndex = 25;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModifyToy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_image);
            this.Controls.Add(this.bt_quitter);
            this.Controls.Add(this.bt_modif);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pic_img);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.txt_max);
            this.Controls.Add(this.txt_min);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_provider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.txt_prix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dGV_toys);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifyToy";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyToy";
            this.Load += new System.EventHandler(this.ModifyToy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_toys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGV_toys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_prix;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_provider;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txt_min;
        private System.Windows.Forms.NumericUpDown txt_max;
        private System.Windows.Forms.NumericUpDown txt_stock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txt_desc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pic_img;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bt_modif;
        private System.Windows.Forms.Button bt_quitter;
        private System.Windows.Forms.TextBox txt_image;
        private System.Windows.Forms.Button button1;
    }
}