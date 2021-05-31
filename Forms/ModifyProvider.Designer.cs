
namespace ToyStore.Forms
{
    partial class ModifyProvider
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
            this.dgv_provider = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.btn_modif = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.list_num = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.list_type = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_types = new System.Windows.Forms.ComboBox();
            this.btn_modiflist = new System.Windows.Forms.Button();
            this.btn_supplist = new System.Windows.Forms.Button();
            this.btn_ajoutlist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_provider)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(299, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modify provider";
            // 
            // dgv_provider
            // 
            this.dgv_provider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_provider.Location = new System.Drawing.Point(12, 83);
            this.dgv_provider.Name = "dgv_provider";
            this.dgv_provider.Size = new System.Drawing.Size(381, 150);
            this.dgv_provider.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adress";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(76, 265);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(170, 20);
            this.txt_name.TabIndex = 5;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(76, 299);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(170, 20);
            this.txt_mail.TabIndex = 6;
            // 
            // txt_adress
            // 
            this.txt_adress.Location = new System.Drawing.Point(76, 337);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(170, 20);
            this.txt_adress.TabIndex = 7;
            // 
            // btn_modif
            // 
            this.btn_modif.Location = new System.Drawing.Point(65, 387);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(94, 39);
            this.btn_modif.TabIndex = 8;
            this.btn_modif.Text = "Modify";
            this.btn_modif.UseVisualStyleBackColor = true;
            this.btn_modif.Click += new System.EventHandler(this.btn_modif_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(257, 387);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(94, 39);
            this.btn_quitter.TabIndex = 9;
            this.btn_quitter.Text = "Close";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ToyStore.Properties.Resources.connectBg;
            this.panel1.Controls.Add(this.btn_ajoutlist);
            this.panel1.Controls.Add(this.btn_supplist);
            this.panel1.Controls.Add(this.btn_modiflist);
            this.panel1.Controls.Add(this.cmb_types);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.list_type);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_num);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.list_num);
            this.panel1.Location = new System.Drawing.Point(411, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 343);
            this.panel1.TabIndex = 10;
            // 
            // list_num
            // 
            this.list_num.FormattingEnabled = true;
            this.list_num.Location = new System.Drawing.Point(37, 49);
            this.list_num.Name = "list_num";
            this.list_num.Size = new System.Drawing.Size(120, 134);
            this.list_num.TabIndex = 0;
            this.list_num.SelectedIndexChanged += new System.EventHandler(this.list_num_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phone number list";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(37, 219);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(120, 20);
            this.txt_num.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Phone number";
            // 
            // list_type
            // 
            this.list_type.FormattingEnabled = true;
            this.list_type.Location = new System.Drawing.Point(212, 49);
            this.list_type.Name = "list_type";
            this.list_type.Size = new System.Drawing.Size(120, 134);
            this.list_type.TabIndex = 4;
            this.list_type.SelectedIndexChanged += new System.EventHandler(this.list_type_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Toy types list";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Toy types";
            // 
            // cmb_types
            // 
            this.cmb_types.FormattingEnabled = true;
            this.cmb_types.Location = new System.Drawing.Point(212, 217);
            this.cmb_types.Name = "cmb_types";
            this.cmb_types.Size = new System.Drawing.Size(120, 21);
            this.cmb_types.TabIndex = 7;
            // 
            // btn_modiflist
            // 
            this.btn_modiflist.Location = new System.Drawing.Point(37, 281);
            this.btn_modiflist.Name = "btn_modiflist";
            this.btn_modiflist.Size = new System.Drawing.Size(88, 36);
            this.btn_modiflist.TabIndex = 8;
            this.btn_modiflist.Text = "Modify";
            this.btn_modiflist.UseVisualStyleBackColor = true;
            this.btn_modiflist.Click += new System.EventHandler(this.btn_modiflist_Click);
            // 
            // btn_supplist
            // 
            this.btn_supplist.Location = new System.Drawing.Point(141, 281);
            this.btn_supplist.Name = "btn_supplist";
            this.btn_supplist.Size = new System.Drawing.Size(88, 36);
            this.btn_supplist.TabIndex = 9;
            this.btn_supplist.Text = "Delete";
            this.btn_supplist.UseVisualStyleBackColor = true;
            this.btn_supplist.Click += new System.EventHandler(this.btn_supplist_Click);
            // 
            // btn_ajoutlist
            // 
            this.btn_ajoutlist.Location = new System.Drawing.Point(244, 281);
            this.btn_ajoutlist.Name = "btn_ajoutlist";
            this.btn_ajoutlist.Size = new System.Drawing.Size(88, 36);
            this.btn_ajoutlist.TabIndex = 10;
            this.btn_ajoutlist.Text = "Add";
            this.btn_ajoutlist.UseVisualStyleBackColor = true;
            this.btn_ajoutlist.Click += new System.EventHandler(this.btn_ajoutlist_Click);
            // 
            // ModifyProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn_modif);
            this.Controls.Add(this.txt_adress);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_provider);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifyProvider";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyProvider";
            this.Load += new System.EventHandler(this.ModifyProvider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_provider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_provider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ajoutlist;
        private System.Windows.Forms.Button btn_supplist;
        private System.Windows.Forms.Button btn_modiflist;
        private System.Windows.Forms.ComboBox cmb_types;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox list_type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox list_num;
    }
}