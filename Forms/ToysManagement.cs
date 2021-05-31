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
    public partial class ToysManagement : Form
    {
        public ToysManagement()
        {
            InitializeComponent();
        }

        private void btn_addToy_Click(object sender, EventArgs e)
        {
            AddToy f1 = new AddToy();
            f1.Show();
        }

        private void btn_deleteToy_Click(object sender, EventArgs e)
        {
            DeleteToy f2 = new DeleteToy();
            f2.Show();
        }

        private void btn_showToys_Click(object sender, EventArgs e)
        {
            ToyList f3 = new ToyList();
            f3.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modifyToy_Click(object sender, EventArgs e)
        {
            ModifyToy f4 = new ModifyToy();
            f4.Show();
        }
    }
}
