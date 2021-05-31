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
    public partial class ProviderList : Form
    {
        public ProviderList()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProviderList_Load(object sender, EventArgs e)
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
                dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
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

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True");
                con.Open();

                int index = dataGridView1.CurrentRow.Index;
                int id_prov = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());

                //phone list fill
                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandText = "select * from Tel_list where Id ="+id_prov;
                cmd2.Connection = con;

                SqlDataReader reader2 = cmd2.ExecuteReader();
                List<string> PhoneNum = new List<string>();
                while (reader2.Read())
                {
                    PhoneNum.Add(reader2.GetString(1));
                }
                reader2.Close();
                listBox1.DataSource = PhoneNum;

                //toy types fill
                SqlCommand cmd3 = new SqlCommand();
                cmd3.CommandText = "select * from TypeProvider where IdProvider ="+id_prov;
                cmd3.Connection = con;

                SqlDataReader reader3 = cmd3.ExecuteReader();
                List<string> ToyType = new List<string>();
                while (reader3.Read())
                {
                    ToyType.Add(reader3.GetString(1));
                }
                reader3.Close();
                listBox2.DataSource = ToyType;
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
