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
    public partial class Login_cashier : Form
    {
        public Login_cashier()
        {
            InitializeComponent();
        }

        private void Login_cashier_Load(object sender, EventArgs e)
        {
            /*this.IsMdiContainer = true;
            Forms.Login f2 = new Login();
            f2.MdiParent = this;
            f2.Show();*/
        }

        public bool verif()
        {
            bool valid = false;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select Id,Login, Password from Cashier where Login ='" + txt_login.Text + "' and Password = '" + txt_pass.Text + "'";
                cmd.Connection = con;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Program.idCaissLoged = reader.GetInt32(0);
                    valid = true;
                }
                else
                    valid = false;
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
            return valid;
        }
    }
}
