
namespace ToyStore.Forms
{
    partial class Container
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Container));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminSpaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashierSpaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientSpaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.welcomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homePageToolStripMenuItem,
            this.adminSpaceToolStripMenuItem,
            this.cashierSpaceToolStripMenuItem,
            this.clientSpaceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.homePageToolStripMenuItem.Text = "Home page";
            this.homePageToolStripMenuItem.Click += new System.EventHandler(this.homePageToolStripMenuItem_Click);
            // 
            // adminSpaceToolStripMenuItem
            // 
            this.adminSpaceToolStripMenuItem.Name = "adminSpaceToolStripMenuItem";
            this.adminSpaceToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.adminSpaceToolStripMenuItem.Text = "Admin space";
            this.adminSpaceToolStripMenuItem.Click += new System.EventHandler(this.adminSpaceToolStripMenuItem_Click);
            // 
            // cashierSpaceToolStripMenuItem
            // 
            this.cashierSpaceToolStripMenuItem.Name = "cashierSpaceToolStripMenuItem";
            this.cashierSpaceToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.cashierSpaceToolStripMenuItem.Text = "Cashier space";
            this.cashierSpaceToolStripMenuItem.Click += new System.EventHandler(this.cashierSpaceToolStripMenuItem_Click);
            // 
            // clientSpaceToolStripMenuItem
            // 
            this.clientSpaceToolStripMenuItem.Name = "clientSpaceToolStripMenuItem";
            this.clientSpaceToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.clientSpaceToolStripMenuItem.Text = "Client space";
            this.clientSpaceToolStripMenuItem.Click += new System.EventHandler(this.clientSpaceToolStripMenuItem_Click);
            // 
            // welcomPanel
            // 
            this.welcomPanel.BackColor = System.Drawing.Color.Transparent;
            this.welcomPanel.BackgroundImage = global::ToyStore.Properties.Resources.connectBg1;
            this.welcomPanel.Controls.Add(this.label2);
            this.welcomPanel.Controls.Add(this.label1);
            this.welcomPanel.Controls.Add(this.panel2);
            this.welcomPanel.Location = new System.Drawing.Point(330, 172);
            this.welcomPanel.Name = "welcomPanel";
            this.welcomPanel.Size = new System.Drawing.Size(500, 312);
            this.welcomPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(71, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please choose an option from the menu \r\nin the top right corner";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(58, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO ToyBox SHOP";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ToyStore.Properties.Resources.logo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(183, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 126);
            this.panel2.TabIndex = 0;
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ToyStore.Properties.Resources._333917;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.welcomPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "Container";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToyBox";
            this.Load += new System.EventHandler(this.Container_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.welcomPanel.ResumeLayout(false);
            this.welcomPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminSpaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashierSpaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientSpaceToolStripMenuItem;
        private System.Windows.Forms.Panel welcomPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
    }
}