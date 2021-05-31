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
    public partial class DeleteProvider : Form
    {
        public DeleteProvider()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteProvider_Load(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Provider";
                cmd.Connection = con;


                SqlDataReader reader = cmd.ExecuteReader();
                List<Classes.Provider> lstProvider = new List<Classes.Provider>();
                while (reader.Read())
                {
                    Classes.Provider prov = new Classes.Provider();
                    prov.Id = reader.GetInt32(0);
                    prov.Name = reader.GetString(1);
                    prov.Email = reader.GetString(2);
                    prov.Adress = reader.GetString(3);

                    lstProvider.Add(prov);
                }
                reader.Close();
                con.Close();
                dataGridView1.DataSource = lstProvider;
                dataGridView1.ClearSelection();
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
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True");
                con.Open();
                int index = dataGridView1.CurrentRow.Index;
                int id_prov = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
                if (id_prov == -1)
                    MessageBox.Show("Yous must select a row to delete!");
                else
                {
                    DialogResult confirmation = MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmation == DialogResult.Yes)
                    {
                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.CommandText = "delete from Tel_list where Id =" + id_prov;
                        cmd2.Connection = con;
                        cmd2.ExecuteNonQuery();

                        SqlCommand cmd3 = new SqlCommand();
                        cmd3.CommandText = "delete from TypeProvider where IdProvider =" + id_prov;
                        cmd3.Connection = con;
                        cmd3.ExecuteNonQuery();

                        SqlCommand cmd4 = new SqlCommand();
                        cmd4.CommandText = "delete from Toys where Provider =" + id_prov;
                        cmd4.Connection = con;
                        cmd4.ExecuteNonQuery();

                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "delete from Provider where Id=" + id_prov;
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Provider deleted successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.DeleteProvider_Load(sender, e);
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }
        }
    }
}
