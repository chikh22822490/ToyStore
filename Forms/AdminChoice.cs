using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyStore.Forms
{
    public partial class AdminChoice : Form
    {
        public AdminChoice()
        {
            InitializeComponent();
        }

        private void AdminChoice_Load(object sender, EventArgs e)
        {
            
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select Login, Photo from Admin where Id =" + Program.idAdminLoged;
                cmd.Connection = con;

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                img_admin.SizeMode = PictureBoxSizeMode.StretchImage;
                img_admin.ImageLocation = reader.GetString(1);
                lbl_nomAdmin.Text = reader.GetString(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }
            this.panel2.Show();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.panel2.Hide();
        }

        private void btn_bestCashier_Click(object sender, EventArgs e)
        {
            BestCashier f1 = new BestCashier();
            f1.Show();
        }

        private void btn_sellCancel_Click(object sender, EventArgs e)
        {
            SellCancel f2 = new SellCancel();
            f2.Show();
        }
    }
}
