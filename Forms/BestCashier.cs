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
    public partial class BestCashier : Form
    {
        public BestCashier()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BestCashier_Load(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=AZZABI-NOUHA\SQLEXPRESS;Initial Catalog=new_toyboxDB;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select Firs_name from Cashier where id = (select IdCashier from Sales having sum(SaleRecipe)=(select max(*) from (select sum(SaleRecipe) from Sales group by IdCashier)))";
                cmd.Connection = con;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    String Name = reader.GetString(0);
                }
                reader.Close();

                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandText = "select Firs_name,Last_name, Tel_number from Cashier where Firs_name = " + Name;
                cmd1.Connection = con;
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    String Name = reader1.GetString(0);
                    String prenom = reader1.GetString(1);
                    String tel = reader1.GetString(2);
                }
                reader1.Close();
                con.Close();

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
        }
    }
}
