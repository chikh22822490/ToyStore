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
    public partial class AddToy : Form
    {

        public AddToy()
        {
            InitializeComponent();
        }

        private void AddToy_Load(object sender, EventArgs e)
        {
            List<string> lstTypes = new List<string>();
            foreach (var item in Enum.GetValues(typeof(Classes.Toy.types)))
            {
                lstTypes.Add(item.ToString());
            }
            lstTypes.Sort();
            cmb_types.DataSource = lstTypes;
            cmb_types.SelectedIndex = -1;
            cmb_types.SelectedIndexChanged += Cmb_types_SelectedIndexChanged;
        }

        private void Cmb_types_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> lstProv = new List<string>();
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select Name from provider where Id in (select IdProvider from TypeProvider where ToyType = '" +cmb_types.SelectedItem+"')";
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btn_imagePath_Click(object sender, EventArgs e)
        {
            string filePath;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\user\\desktop";
            openFileDialog.Filter= "Image files (*.jpg, *.jpeg, *.bmp, *.png, *.ico) | *.jpg; *.jpeg; *.bmp; *.png; *.ico";
            openFileDialog.ShowDialog();
            filePath = openFileDialog.FileName;
            txt_imagePath.Text = filePath;
        }

        private void btn_addToy_Click(object sender, EventArgs e)
        {
            if(txt_name.Text.Length==0)
                MessageBox.Show("Name is missing");
            else if(minAge.Value==0||maxAge.Value==0)
                MessageBox.Show("Age range is required");
            else if(txt_price.Text.Length==0)
                MessageBox.Show("Price is missing");
            else if(float.TryParse(txt_price.Text, out float price)==false)
                MessageBox.Show("Price field should be numeric");
            else if(float.Parse(txt_price.Text)<=0)
                MessageBox.Show("Price should be > 0");
            else if(cmb_types.SelectedIndex==-1)
                MessageBox.Show("Type is missing");
            else if(cmb_provider.SelectedIndex==-1)
                MessageBox.Show("Provider is missing");
            else if(txt_imagePath.Text.Length==0)
                MessageBox.Show("Image is missing");
            else
            {
                SqlConnection con = null;
                try
                {
                    con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True");
                    con.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "insert into [Toys](Name,Type,MaxAge,MinAge,Photo,Price,Provider,Stock,Description) values(@name,@type,@max,@min,@photo,@price,@providerId,@stock,@descr)";
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@name", txt_name.Text);
                    cmd.Parameters.AddWithValue("@type", cmb_types.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@max", int.Parse(maxAge.Value.ToString()));
                    cmd.Parameters.AddWithValue("@min", int.Parse(minAge.Value.ToString()));
                    cmd.Parameters.AddWithValue("@photo", txt_imagePath.Text);
                    cmd.Parameters.AddWithValue("@price", float.Parse(txt_price.Text));
                    cmd.Parameters.AddWithValue("@stock", input_stock.Value);
                    if (txt_description.Text.Length != 0)
                        cmd.Parameters.AddWithValue("@descr", txt_description.Text);
                    else
                        cmd.Parameters.AddWithValue("@descr", "");


                    string providerName = cmb_provider.Text;
                    SqlCommand cmd2 = new SqlCommand();

                    //cmd2.CommandText = "select Id from Provider where Name = " + providerName;
                    cmd2.CommandText = "select * from Provider";
                    cmd2.Connection = con;
                    SqlDataReader reader = cmd2.ExecuteReader();
                    int id_prov=0;
                    while (reader.Read())
                    {
                        if (reader.GetString(1) == cmb_provider.Text)
                            id_prov = reader.GetInt32(0);
                    }
                    cmd.Parameters.AddWithValue("@providerId", id_prov);
                    reader.Close();
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("toy added");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (con != null && con.State == ConnectionState.Open)
                        con.Close();
                    this.Close();
                }
            }
        }
    }
}