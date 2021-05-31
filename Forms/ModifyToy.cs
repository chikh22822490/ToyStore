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
    public partial class ModifyToy : Form
    {
        public ModifyToy()
        {
            InitializeComponent();
        }

        private void ModifyToy_Load(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                List<string> lstTypes = new List<string>();
                foreach (var item in Enum.GetValues(typeof(Classes.Toy.types)))
                {
                    lstTypes.Add(item.ToString());
                }
                lstTypes.Sort();
                cmb_type.DataSource = lstTypes;

                con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
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
                    toy.Price = reader.GetDouble(6);
                    toy.IdProvider = reader.GetInt32(7);
                    toy.Stock = reader.GetInt32(8);
                    toy.Description = reader.GetString(9);

                    lstToys.Add(toy);

                }
                reader.Close();

                dGV_toys.DataSource = lstToys;

                dGV_toys.CurrentRow.Selected = false;
                dGV_toys.ClearSelection();

                dGV_toys.SelectionChanged += DGV_toys_SelectionChanged;
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

        private void DGV_toys_SelectionChanged(object sender, EventArgs e)
        {
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
                con.Open();
                int index = dGV_toys.CurrentRow.Index;
                int id_toy = int.Parse(dGV_toys.Rows[index].Cells[0].Value.ToString());

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Toys where Id = " + id_toy;
                cmd.Connection = con;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    pic_img.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic_img.ImageLocation = reader.GetString(5);
                    if (reader.GetString(9).Length != 0)
                    { 
                        txt_desc.Text = reader.GetString(9); 
                    }
                    else 
                    { 
                        txt_desc.Text = "No discription"; 
                    }

                    txt_nom.Text = reader.GetString(1);
                    txt_prix.Text = reader.GetDouble(6).ToString();
                    cmb_type.Text = reader.GetString(2);
                    txt_stock.Text = reader.GetInt32(8).ToString();
                    txt_min.Value = reader.GetInt32(4);
                    txt_max.Value = reader.GetInt32(3);

                }
                reader.Close();

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

        private void bt_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_modif_Click(object sender, EventArgs e)
        {
            int index = dGV_toys.CurrentRow.Index;
            int id_toy = int.Parse(dGV_toys.Rows[index].Cells[0].Value.ToString());

            if (txt_nom.Text.Length == 0)
                MessageBox.Show("Name is missing");
            else if (int.Parse(txt_min.Text) <= 0 || int.Parse(txt_max.Text) <= 0)
                MessageBox.Show("Age range is required");
            else if (txt_prix.Text.Length == 0)
                MessageBox.Show("Price is missing");
            else if (float.TryParse(txt_prix.Text, out float price) == false)
                MessageBox.Show("Price field should be numeric");
            else if (float.Parse(txt_prix.Text) <= 0)
                MessageBox.Show("Price should be > 0");

            else
            {
                DialogResult R = MessageBox.Show("Are you sure you want to modify the toy?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (R == DialogResult.Yes)
                {
                    SqlConnection con = null;
                    try
                    {
                        con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
                        con.Open();

                        SqlCommand cmd1 = new SqlCommand();
                        cmd1.CommandText = "select Id from Provider where Name = '" + cmb_provider.SelectedItem.ToString() + "'";
                        cmd1.Connection = con;
                        SqlDataReader reader1 = cmd1.ExecuteReader();
                        int fourni = -1;
                        if (reader1.Read())
                        {
                            fourni = reader1.GetInt32(0);

                        }
                        reader1.Close();
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = " UPDATE Toys SET Name=@nom ,Type=@type ,MaxAge=@max ,MinAge=@min ,Photo=@photo , Price=@prix , Provider =@fourni ,Stock=@stock ,Description=@Desc where Id=" + id_toy;
                        cmd.Parameters.AddWithValue("@nom", txt_nom);
                        cmd.Parameters.AddWithValue("@type", cmb_type.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@max", txt_max.Value);
                        cmd.Parameters.AddWithValue("@min", txt_min.Value);
                        cmd.Parameters.AddWithValue("@photo", txt_image.Text);
                        cmd.Parameters.AddWithValue("@prix", double.Parse(txt_prix.Text));
                        cmd.Parameters.AddWithValue("@fourni", fourni);
                        cmd.Parameters.AddWithValue("@stock", txt_stock.Value);
                        cmd.Parameters.AddWithValue("@Desc", txt_desc.Text);

                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        this.ModifyToy_Load(sender, e);
                        if (con != null && con.State == ConnectionState.Open)
                            con.Close();
                    }


                }
                else
                {
                    MessageBox.Show("modification is canceled", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\user\\desktop";
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.bmp, *.png, *.ico) | *.jpg; *.jpeg; *.bmp; *.png; *.ico";
            openFileDialog.ShowDialog();
            filePath = openFileDialog.FileName;
            txt_image.Text = filePath;
        }

        private void cmb_provider_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> lstProv = new List<string>();
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select Name from provider where Id in (select IdProvider from TypeProvider where ToyType = '" + cmb_type.SelectedItem.ToString() + "')";
                cmd.Connection = con;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lstProv.Add(reader.GetString(0));
                }
                reader.Close();
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

            lstProv.Sort();

            cmb_provider.DataSource = lstProv;
            cmb_provider.SelectedIndex = -1;
        }
    }
}
