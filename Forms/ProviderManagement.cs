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
    public partial class ProviderManagement : Form
    {
        public ProviderManagement()
        {
            InitializeComponent();
        }

        private void btn_addProvider_Click(object sender, EventArgs e)
        {
            AddProvider f1 = new AddProvider();
            f1.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_showProviders_Click(object sender, EventArgs e)
        {
            ProviderList f2 = new ProviderList();
            f2.Show();
        }

        private void btn_deleteProvider_Click(object sender, EventArgs e)
        {
            DeleteProvider f3 = new DeleteProvider();
            f3.Show();
        }

        private void btn_modifyProvider_Click(object sender, EventArgs e)
        {
            ModifyProvider f4 = new ModifyProvider();
            f4.Show();
        }
    }
}
