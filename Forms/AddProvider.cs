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
    
    public partial class AddProvider : Form
    {
        private static List<string> phoneList = null;
        public AddProvider()
        {
            InitializeComponent();
        }

        private void AddProvider_Load(object sender, EventArgs e)
        {
            chk_types.DataSource = Enum.GetValues(typeof(Classes.Toy.types));
            chk_types.ClearSelected();
            phoneList = new List<string>();
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Length == 0)
                MessageBox.Show("Name field is empty");
            else if(txt_mail.Text.Length==0)
                MessageBox.Show("E-mail field is empty");
            else if(txt_adress.Text.Length==0)
                MessageBox.Show("Adress field is empty");
            else if(chk_types.CheckedItems.Count==0)
                MessageBox.Show("No toy type selected");
            else if(phoneList.Count==0)
                MessageBox.Show("One or more phone number required");
            else
            {
                SqlConnection con = null;
                try
                {
                    con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
                    con.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "insert into [Provider](Name,Email,Adress) values(@Name,@Email,@Adress)";
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@Name", txt_name.Text);
                    cmd.Parameters.AddWithValue("@Email", txt_mail.Text);
                    cmd.Parameters.AddWithValue("@Adress", txt_adress.Text);
                    cmd.ExecuteNonQuery();


                    SqlCommand cmd4 = new SqlCommand();
                    cmd4.CommandText = "select Id from [Provider] order by Id desc";
                    cmd4.Connection = con;
                    SqlDataReader dr = cmd4.ExecuteReader();
                    if (dr.HasRows)
                        dr.Read();
                    int id_provider = dr.GetInt32(0);
                    dr.Close();
                    for (int i = 0; i < chk_types.CheckedItems.Count; i++)
                    {
                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.CommandText = "insert into [TypeProvider](IdProvider, ToyType) values(@IdProvider,@ToyType)";
                        cmd2.Connection = con;
                        cmd2.Parameters.AddWithValue("@IdProvider", id_provider);
                        cmd2.Parameters.AddWithValue("@ToyType", chk_types.CheckedItems[i].ToString());
                        cmd2.ExecuteNonQuery();
                    }

                    for (int i = 0; i < phoneList.Count; i++)
                    {
                        SqlCommand cmd3 = new SqlCommand();
                        cmd3.CommandText = "insert into [Tel_list](Id,Tel_number) values(@IdProvider, @Tel_number)";
                        cmd3.Connection = con;
                        cmd3.Parameters.AddWithValue("@IdProvider", id_provider);
                        cmd3.Parameters.AddWithValue("@Tel_Number", phoneList[i]);
                        cmd3.ExecuteNonQuery();
                    }


                    MessageBox.Show("The provider has been successfuly added");
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

        private void btn_addNumber_Click(object sender, EventArgs e)
        {
            if(txt_phoneNbr.Text.Length==0)
                MessageBox.Show("No number added");
            else if(txt_phoneNbr.Text.Length!=8)
                MessageBox.Show("Number should have exactly 8 figures");
            else if(int.TryParse(txt_phoneNbr.Text, out int number)==false)
                MessageBox.Show("Phone number should be only numeric");
            else
            {
                phoneList.Add(txt_phoneNbr.Text);
                List<string> phoneList2 = new List<string>();
                for (int i = 0; i < phoneList.Count; i++)
                    phoneList2.Add(phoneList[i]);
                listBox1.DataSource = phoneList2;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
