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
    public partial class ToyList : Form
    {
        public ToyList()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToyList_Load(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Toys";
                cmd.Connection = con;


                SqlDataReader reader = cmd.ExecuteReader();
                List<Classes.Toy> lstToys = new List<Classes.Toy>();
                while (reader.Read())
                {
                    Classes.Toy toy = new Classes.Toy();
                    toy.Id = reader.GetInt32(0);
                    toy.Name = reader.GetString(1);
                    toy.Type = reader.GetString(2);
                    toy.MaxAge = reader.GetInt32(3);
                    toy.MinAge = reader.GetInt32(4);
                    //toy.Image = reader.GetString(5);
                    toy.Price = reader.GetDouble(6);
                    toy.IdProvider = reader.GetInt32(7);
                    toy.Stock = reader.GetInt32(8);
                    toy.Description = reader.GetString(9);

                    lstToys.Add(toy);
                }
                reader.Close();
                con.Close();
                dataGridView1.DataSource = lstToys;

                dataGridView1.Columns[0].Width = 30;
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[2].Width = 70;
                dataGridView1.Columns[3].Width = 50;
                dataGridView1.Columns[4].Width = 50;
                dataGridView1.Columns[5].Width = 50;
                dataGridView1.Columns[6].Width = 70;
                dataGridView1.Columns[7].Width = 60;
                dataGridView1.Columns[8].Visible = false;
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
            int index = dataGridView1.CurrentRow.Index;
            int id_toy = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select Photo, Description from Toys where Id = " + id_toy;
                cmd.Connection = con;


                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    img_toy.SizeMode = PictureBoxSizeMode.StretchImage;
                    img_toy.ImageLocation = reader.GetString(0);
                    if (reader.GetString(1).Length != 0)
                        txt_descr.Text = reader.GetString(1);
                    else txt_descr.Text = "No discription";
                }
                reader.Close();
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
