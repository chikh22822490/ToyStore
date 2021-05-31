using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyStore.Forms
{
    public partial class Container : Form
    {
        
        public Container()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }


        private void Container_Load(object sender, EventArgs e)
        {
            
        }

        Login_admin login_admin = null;
        Login_cashier login_Cashier = null;
        ToysManagement toys = null;
        AdminChoice adminChoice = null;
        ProviderManagement providerManagement = null;
        ClientSpace client = null;
        Cashier_choice cashier_Choice = null;

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
                login_admin = null;
                toys = null;
                adminChoice = null;
                providerManagement = null;

            }
            this.welcomPanel.Show();
        }

        private void adminSpaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.welcomPanel.Visible == true)
                this.welcomPanel.Hide();
            if (login_admin == null)
            {
                login_admin = new Login_admin();
                login_admin.MdiParent = this;
                login_admin.Show();
                if (adminChoice != null)
                {
                    adminChoice.Close();
                    adminChoice = null;
                }
                if (toys != null)
                {
                    toys.Close();
                    toys = null;
                }
                if (providerManagement != null)
                {
                    providerManagement.Close();
                    providerManagement = null;
                }
            }
            else
            {
                login_admin.Activate();
                login_admin.BringToFront();
            }
            login_admin.btn_login1.Click += Btn_login_Click;
            login_admin.btn_exit1.Click += Btn_exit_Click;
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.welcomPanel.Show();
            login_admin.Close();
            login_admin = null;
        }

        private void Btn_login_Click(object sender, EventArgs e)//admin loged in
        {
            if(login_admin.verif() == true)
            {
                if (adminChoice == null)
                {
                    adminChoice = new AdminChoice();
                    adminChoice.MdiParent = this;
                    adminChoice.Show();
                    login_admin.Close();
                    login_admin = null;
                }
                else
                    adminChoice.Activate();

                adminChoice.btn_providerManagement.Click += Btn_providerManagement_Click;
                adminChoice.btn_toyManagement.Click += Btn_toyManagement_Click;
                adminChoice.btn_logout.Click += Btn_logout_Click;
            }
            else
                MessageBox.Show("Username or password invalid");

            
        }

        private void Btn_toyManagement_Click(object sender, EventArgs e)
        {
            if (toys == null)
            {
                toys = new ToysManagement();
                toys.MdiParent = this;
                toys.Show();
            }
            else
                toys.Activate();
            
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            Program.idAdminLoged = 0;
            if (login_admin == null)
            {
                login_admin = new Login_admin();
                login_admin.MdiParent = this;
                login_admin.Show();
            }
            else
            {
                login_admin.Activate();
                login_admin.BringToFront();
            }
            adminChoice.Close();
            adminChoice = null;
            if (toys != null)
            {
                toys.Close();
                toys = null;
            }
            if (providerManagement != null)
            {
                providerManagement.Close();
                providerManagement = null;
            }
            login_admin.btn_login1.Click += Btn_login_Click;
            login_admin.btn_exit1.Click += Btn_exit_Click;
        }

        private void Btn_providerManagement_Click(object sender, EventArgs e)
        {
            if (providerManagement == null)
            {
                providerManagement = new ProviderManagement();
                providerManagement.MdiParent = this;
                providerManagement.Show();
            }
            else
                providerManagement.Activate();
        }


        private void clientSpaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.welcomPanel.Visible == true)
                this.welcomPanel.Hide();
            if (client == null)
            {
                client = new ClientSpace();
                client.MdiParent = this;
                client.Show();
            }
            else
            {
                client.Activate();
                client.BringToFront();
            }
            client.btn_exit.Click += Btn_exit_Click1;
        }

        private void Btn_exit_Click1(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Would you like to subscribe to our e-mailing list ?", "Subscription", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                Subscription sub = new Subscription();
                sub.Show();
            }
            client.Close();
            client = null;
            this.welcomPanel.Show();
        }

        private void cashierSpaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.welcomPanel.Visible == true)
                this.welcomPanel.Hide();
            if (login_Cashier == null)
            {
                login_Cashier = new Login_cashier();
                login_Cashier.MdiParent = this;
                login_Cashier.Show();
            }
            else
            {
                login_Cashier.Activate();
                login_Cashier.BringToFront();
            }
            login_Cashier.btn_login.Click += Btn_login_Click1;
            login_Cashier.btn_exit2.Click += Btn_exit_Click2;
        }

        private void Btn_login_Click1(object sender, EventArgs e)
        {
            if (login_Cashier.verif() == true)
            {
                if (cashier_Choice == null)
                {
                    cashier_Choice = new Cashier_choice();
                    cashier_Choice.MdiParent = this;
                    cashier_Choice.Show();
                    login_Cashier.Close();
                    login_Cashier = null;
                }
                else
                    cashier_Choice.Activate();
                
            }
            else
                MessageBox.Show("Username or password invalid");
            
        }

        private void Btn_exit_Click2(object sender, EventArgs e)
        {
            this.welcomPanel.Show();
            login_Cashier.Close();
            login_Cashier = null;
        }
    }
}
