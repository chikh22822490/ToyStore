
namespace ToyStore.Forms
{
    partial class ProviderManagement
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
            this.btn_showProviders = new System.Windows.Forms.Button();
            this.btn_modifyProvider = new System.Windows.Forms.Button();
            this.btn_deleteProvider = new System.Windows.Forms.Button();
            this.btn_addProvider = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ToyStore.Properties.Resources.connectBg;
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_showProviders);
            this.panel1.Controls.Add(this.btn_modifyProvider);
            this.panel1.Controls.Add(this.btn_deleteProvider);
            this.panel1.Controls.Add(this.btn_addProvider);
            this.panel1.Location = new System.Drawing.Point(426, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 248);
            this.panel1.TabIndex = 1;
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
            // btn_showProviders
            // 
            this.btn_showProviders.Location = new System.Drawing.Point(236, 127);
            this.btn_showProviders.Name = "btn_showProviders";
            this.btn_showProviders.Size = new System.Drawing.Size(98, 39);
            this.btn_showProviders.TabIndex = 3;
            this.btn_showProviders.Text = "Show providers";
            this.btn_showProviders.UseVisualStyleBackColor = true;
            this.btn_showProviders.Click += new System.EventHandler(this.btn_showProviders_Click);
            // 
            // btn_modifyProvider
            // 
            this.btn_modifyProvider.Location = new System.Drawing.Point(236, 56);
            this.btn_modifyProvider.Name = "btn_modifyProvider";
            this.btn_modifyProvider.Size = new System.Drawing.Size(98, 39);
            this.btn_modifyProvider.TabIndex = 2;
            this.btn_modifyProvider.Text = "Modify provider";
            this.btn_modifyProvider.UseVisualStyleBackColor = true;
            this.btn_modifyProvider.Click += new System.EventHandler(this.btn_modifyProvider_Click);
            // 
            // btn_deleteProvider
            // 
            this.btn_deleteProvider.Location = new System.Drawing.Point(60, 127);
            this.btn_deleteProvider.Name = "btn_deleteProvider";
            this.btn_deleteProvider.Size = new System.Drawing.Size(98, 39);
            this.btn_deleteProvider.TabIndex = 1;
            this.btn_deleteProvider.Text = "Delete provider";
            this.btn_deleteProvider.UseVisualStyleBackColor = true;
            this.btn_deleteProvider.Click += new System.EventHandler(this.btn_deleteProvider_Click);
            // 
            // btn_addProvider
            // 
            this.btn_addProvider.Location = new System.Drawing.Point(60, 56);
            this.btn_addProvider.Name = "btn_addProvider";
            this.btn_addProvider.Size = new System.Drawing.Size(98, 39);
            this.btn_addProvider.TabIndex = 0;
            this.btn_addProvider.Text = "Add provider";
            this.btn_addProvider.UseVisualStyleBackColor = true;
            this.btn_addProvider.Click += new System.EventHandler(this.btn_addProvider_Click);
            // 
            // ProviderManagement
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
            this.Name = "ProviderManagement";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Provider Management";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_showProviders;
        private System.Windows.Forms.Button btn_modifyProvider;
        private System.Windows.Forms.Button btn_deleteProvider;
        private System.Windows.Forms.Button btn_addProvider;
        private System.Windows.Forms.Button btn_back;
    }
}