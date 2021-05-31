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
    public partial class ClientSpace : Form
    {
        private List<string> typeFilter = new List<string>();
        private int minAgeFilter = 0;
        private int maxAgeFilter = 0;
        private double minPriceFilter = 0;
        private double maxPriceFilter = 0;
        private int ageMin = 0;
        private int ageMax = 0;
        private double priceMax = 0;
         
        public ClientSpace()
        {
            InitializeComponent();
        }

        private void ClientSpace_Load(object sender, EventArgs e)
        {
            typeFilter.Clear();
            SqlConnection con = null;
            try
            {
                foreach (var item in Enum.GetValues(typeof(Classes.Toy.types)))
                {
                    typeFilter.Add(item.ToString());
                }
                typeFilter.Sort();
                checkedListBox1.DataSource = typeFilter;
                con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select Min(MinAge), Max(MaxAge), Min(Price), Max(Price) from Toys";
                cmd.Connection = con;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    minAgeFilter = reader.GetInt32(0);
                    maxAgeFilter = reader.GetInt32(1);
                    minPriceFilter = reader.GetDouble(2);
                    maxPriceFilter = reader.GetDouble(3);
                    if (minPriceFilter % 1 != 0)
                    {
                        minPriceFilter = minPriceFilter - (1 - (minPriceFilter % 1));
                    }
                    if (maxPriceFilter % 1 != 0)
                    {
                        maxPriceFilter = maxPriceFilter + (1 - (maxPriceFilter % 1));
                    }
                }
                reader.Close();
                in_maxAge.Maximum = maxAgeFilter;
                in_maxAge.Value = maxAgeFilter;
                ageMax = maxAgeFilter;
                in_minAge.Minimum = minAgeFilter;
                in_minAge.Value = minAgeFilter;
                ageMin = minAgeFilter;
                priceMax = maxPriceFilter;
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
            showAllToys();
        }

        private void showAllToys()
        {
            toy_list.Controls.Clear();
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
                con.Open();

                for(int j=0; j<typeFilter.Count;j++)
                {
                    SqlCommand cmd3 = new SqlCommand();
                    cmd3.CommandText = "Insert into filtreType (type) Values ( @type)";
                    cmd3.Connection = con;
                    cmd3.Parameters.AddWithValue("@type", typeFilter[j]);
                    cmd3.ExecuteNonQuery();
                }


                
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select Name, Type , MaxAge, MinAge, Photo, Price, Stock, Description from Toys where (Type in ( select * from filtreType)) and (MinAge >= " + minAgeFilter + ") and (MaxAge<=" + maxAgeFilter + ")  and ( Price between " + minPriceFilter + " and " + maxPriceFilter + ")";
                cmd.Connection = con;

                
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Catalog cat = new Catalog();
                    cat.Name = reader.GetString(0);
                    cat.Type = reader.GetString(1);
                    cat.MinAge = reader.GetInt32(3).ToString();
                    cat.MaxAge = reader.GetInt32(2).ToString();
                    cat.Image = Image.FromFile(reader.GetString(4));
                    cat.Price = reader.GetDouble(5).ToString();
                    cat.Description = reader.GetString(7);
                    if (reader.GetInt32(6) == 0)
                    {
                        cat.lblStock.ForeColor = Color.Red;
                        cat.lblStock.Text = "Sold out";
                    }
                    else
                    {
                        cat.lblStock.ForeColor = Color.Green;
                        cat.lblStock.Text = "In stock";
                    }
                    toy_list.Controls.Add(cat);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "delete from filtreType";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            checkedListBox1.DataSource = null;
            checkedListBox1.Items.Clear();
            rdb_price1.Checked = false;
            rdb_price2.Checked = false;
            rdb_price3.Checked = false;
            rdb_price4.Checked = false;
            this.ClientSpace_Load(sender,e);
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            if(checkedListBox1.CheckedItems.Count!=0)
            {
                typeFilter.Clear();
                for(int i=0;i<checkedListBox1.CheckedItems.Count;i++)
                {
                    typeFilter.Add(checkedListBox1.CheckedItems[i].ToString());
                }
            }

            if (in_minAge.Value != ageMin)
                minAgeFilter = (int)in_minAge.Value;
            else
                minAgeFilter = ageMin;

            if (in_maxAge.Value != ageMax)
                maxAgeFilter = (int)in_maxAge.Value;
            else
                maxAgeFilter = ageMax;

            if(rdb_price1.Checked==true)
            {
                minPriceFilter = 0;
                maxPriceFilter = 20;
            }
            else if(rdb_price2.Checked ==true)
            {
                minPriceFilter = 21;
                maxPriceFilter = 50;
            }
            else if(rdb_price3.Checked==true)
            {
                minPriceFilter = 51;
                maxPriceFilter = 100;
            }
            else if(rdb_price4.Checked==true)
            {
                minPriceFilter = 101;
                maxPriceFilter = priceMax;
            }
            else
            {
                minPriceFilter = 0;
                maxPriceFilter = priceMax;
            }

            showAllToys();
        }
    }
}
