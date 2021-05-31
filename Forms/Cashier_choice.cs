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
    public partial class Cashier_choice : Form
    {
        public Cashier_choice()
        {
            InitializeComponent();
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            Sell f1 = new Sell();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            previousSales f2 = new previousSales();
            f2.Show();
        }

        private void Cashier_choice_Load(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select Login, Photo from Cashier where Id =" + Program.idCaissLoged;
                cmd.Connection = con;

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                img_cashier.SizeMode = PictureBoxSizeMode.StretchImage;
                img_cashier.ImageLocation = reader.GetString(1);
                lbl_nomCashier.Text = reader.GetString(0);
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
    }
}
