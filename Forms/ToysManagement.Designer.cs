
namespace ToyStore.Forms
{
    partial class ToysManagement
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_showToys = new System.Windows.Forms.Button();
            this.btn_modifyToy = new System.Windows.Forms.Button();
            this.btn_deleteToy = new System.Windows.Forms.Button();
            this.btn_addToy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ToyStore.Properties.Resources.connectBg;
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_showToys);
            this.panel1.Controls.Add(this.btn_modifyToy);
            this.panel1.Controls.Add(this.btn_deleteToy);
            this.panel1.Controls.Add(this.btn_addToy);
            this.panel1.Location = new System.Drawing.Point(426, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 248);
            this.panel1.TabIndex = 2;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(154, 193);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 34);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_showToys
            // 
            this.btn_showToys.Location = new System.Drawing.Point(236, 127);
            this.btn_showToys.Name = "btn_showToys";
            this.btn_showToys.Size = new System.Drawing.Size(98, 39);
            this.btn_showToys.TabIndex = 3;
            this.btn_showToys.Text = "Show toys";
            this.btn_showToys.UseVisualStyleBackColor = true;
            this.btn_showToys.Click += new System.EventHandler(this.btn_showToys_Click);
            // 
            // btn_modifyToy
            // 
            this.btn_modifyToy.Location = new System.Drawing.Point(236, 56);
            this.btn_modifyToy.Name = "btn_modifyToy";
            this.btn_modifyToy.Size = new System.Drawing.Size(98, 39);
            this.btn_modifyToy.TabIndex = 2;
            this.btn_modifyToy.Text = "Modify toy";
            this.btn_modifyToy.UseVisualStyleBackColor = true;
            this.btn_modifyToy.Click += new System.EventHandler(this.btn_modifyToy_Click);
            // 
            // btn_deleteToy
            // 
            this.btn_deleteToy.Location = new System.Drawing.Point(60, 127);
            this.btn_deleteToy.Name = "btn_deleteToy";
            this.btn_deleteToy.Size = new System.Drawing.Size(98, 39);
            this.btn_deleteToy.TabIndex = 1;
            this.btn_deleteToy.Text = "Delete toy";
            this.btn_deleteToy.UseVisualStyleBackColor = true;
            this.btn_deleteToy.Click += new System.EventHandler(this.btn_deleteToy_Click);
            // 
            // btn_addToy
            // 
            this.btn_addToy.Location = new System.Drawing.Point(60, 56);
            this.btn_addToy.Name = "btn_addToy";
            this.btn_addToy.Size = new System.Drawing.Size(98, 39);
            this.btn_addToy.TabIndex = 0;
            this.btn_addToy.Text = "Add toy";
            this.btn_addToy.UseVisualStyleBackColor = true;
            this.btn_addToy.Click += new System.EventHandler(this.btn_addToy_Click);
            // 
            // ToysManagement
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
            this.Name = "ToysManagement";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ToysManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_showToys;
        private System.Windows.Forms.Button btn_modifyToy;
        private System.Windows.Forms.Button btn_deleteToy;
        private System.Windows.Forms.Button btn_addToy;
    }
}