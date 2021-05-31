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
    public partial class SellCancel : Form
    {
        public SellCancel()
        {
            InitializeComponent();
        }

        List<Classes.Sale> sales = new List<Classes.Sale>();
        private void SellCancel_Load(object sender, EventArgs e)
        {
            sales.Clear();
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Sales";
                cmd.Connection = con;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Classes.Sale sale = new Classes.Sale();
                    sale.Id = reader.GetInt32(0);
                    sale.IdCashier = reader.GetInt32(1);
                    sale.Date = (DateTime)reader.GetDateTime(2);
                    sale.Somme = reader.GetDouble(3);
                    sale.Reciept = reader.GetString(4);

                    sales.Add(sale);
                }
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = sales;
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count==0)
            {
                MessageBox.Show("You must select a row first");
            }
            else
            {
                int index = dataGridView1.CurrentRow.Index;
                int id_sale = (int)dataGridView1.Rows[index].Cells[0].Value;
                SqlConnection con = null;
                try
                {
                    con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True");
                    con.Open();

                    SqlCommand cmd3 = new SqlCommand();
                    cmd3.CommandText = "select IdToy from ToysSold where IdSale=" + id_sale;
                    cmd3.Connection = con;
                    SqlDataReader reader = cmd3.ExecuteReader();

                    while(reader.Read())
                    {
                        SqlCommand cmd4 = new SqlCommand();
                        cmd4.CommandText = "select stock from Toys where Id = " + reader.GetInt32(0);
                        cmd4.Connection = con;
                        SqlDataReader reader1 = cmd4.ExecuteReader();
                        reader1.Read();
                        int stock = reader1.GetInt32(0);
                        reader1.Close();
                        stock = stock + 1;
                        SqlCommand cmd5 = new SqlCommand();
                        cmd5.CommandText = "Update Toys set Stock = " + stock;
                        cmd5.Connection = con;
                        cmd5.ExecuteNonQuery();
                    }
                    reader.Close();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "delete from [ToysSold] where IdSale =" + id_sale;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.CommandText = "delete from Sales where IdSale =" + id_sale;
                    cmd2.Connection = con;
                    cmd2.ExecuteNonQuery();

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.SellCancel_Load(sender, e);
                    if (con != null && con.State == ConnectionState.Open)
                        con.Close();
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
