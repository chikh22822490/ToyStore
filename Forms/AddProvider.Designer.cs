
namespace ToyStore.Forms
{
    partial class AddProvider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProvider));
            this.btn_validate = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.btn_addNumber = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelmail = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labeltypes = new System.Windows.Forms.Label();
            this.chk_types = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_phoneNbr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_validate
            // 
            this.btn_validate.Location = new System.Drawing.Point(268, 383);
            this.btn_validate.Name = "btn_validate";
            this.btn_validate.Size = new System.Drawing.Size(93, 35);
            this.btn_validate.TabIndex = 0;
            this.btn_validate.Text = "Validate";
            this.btn_validate.UseVisualStyleBackColor = true;
            this.btn_validate.Click += new System.EventHandler(this.btn_validate_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(488, 383);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(92, 35);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(185, 93);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(228, 20);
            this.txt_name.TabIndex = 3;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(185, 134);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(228, 20);
            this.txt_mail.TabIndex = 4;
            // 
            // txt_adress
            // 
            this.txt_adress.Location = new System.Drawing.Point(185, 176);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(228, 20);
            this.txt_adress.TabIndex = 5;
            // 
            // btn_addNumber
            // 
            this.btn_addNumber.Location = new System.Drawing.Point(578, 143);
            this.btn_addNumber.Name = "btn_addNumber";
            this.btn_addNumber.Size = new System.Drawing.Size(98, 36);
            this.btn_addNumber.TabIndex = 7;
            this.btn_addNumber.Text = "Add number";
            this.btn_addNumber.UseVisualStyleBackColor = true;
            this.btn_addNumber.Click += new System.EventHandler(this.btn_addNumber_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // labelmail
            // 
            this.labelmail.AutoSize = true;
            this.labelmail.Location = new System.Drawing.Point(92, 134);
            this.labelmail.Name = "labelmail";
            this.labelmail.Size = new System.Drawing.Size(35, 13);
            this.labelmail.TabIndex = 9;
            this.labelmail.Text = "E-mail";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(92, 176);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(39, 13);
            this.labelAdress.TabIndex = 10;
            this.labelAdress.Text = "Adress";
            // 
            // labeltypes
            // 
            this.labeltypes.AutoSize = true;
            this.labeltypes.Location = new System.Drawing.Point(92, 220);
            this.labeltypes.Name = "labeltypes";
            this.labeltypes.Size = new System.Drawing.Size(57, 13);
            this.labeltypes.TabIndex = 11;
            this.labeltypes.Text = "Toy Types";
            // 
            // chk_types
            // 
            this.chk_types.FormattingEnabled = true;
            this.chk_types.Location = new System.Drawing.Point(185, 220);
            this.chk_types.Name = "chk_types";
            this.chk_types.Size = new System.Drawing.Size(228, 124);
            this.chk_types.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phone numbers added";
            // 
            // txt_phoneNbr
            // 
            this.txt_phoneNbr.Location = new System.Drawing.Point(593, 93);
            this.txt_phoneNbr.Name = "txt_phoneNbr";
            this.txt_phoneNbr.Size = new System.Drawing.Size(153, 20);
            this.txt_phoneNbr.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Phone number";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(502, 223);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 121);
            this.listBox1.TabIndex = 16;
            // 
            // AddProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_phoneNbr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chk_types);
            this.Controls.Add(this.labeltypes);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.labelmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addNumber);
            this.Controls.Add(this.txt_adress);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_validate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "AddProvider";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Provider";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddProvider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_validate;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.Button btn_addNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelmail;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labeltypes;
        private System.Windows.Forms.CheckedListBox chk_types;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_phoneNbr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
    }
}