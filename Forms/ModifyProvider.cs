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
    public partial class ModifyProvider : Form
    {
        public ModifyProvider()
        {
            InitializeComponent();
        }

        private void ModifyProvider_Load(object sender, EventArgs e)
        {
            dgv_provider.ClearSelection();
            list_num.SelectedIndex = -1;
            list_type.SelectedIndex = -1;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
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

                dgv_provider.DataSource = lstProvider;
                dgv_provider.CurrentRow.Selected = false;
                dgv_provider.ClearSelection();
                dgv_provider.SelectionChanged += Dgv_provider_SelectionChanged;
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

            List<string> lstTypes = new List<string>();
            foreach (var item in Enum.GetValues(typeof(Classes.Toy.types)))
            {
                lstTypes.Add(item.ToString());
            }
            lstTypes.Sort();

            cmb_types.DataSource = lstTypes;
        }

        private void Dgv_provider_SelectionChanged(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
                con.Open();

                int index = dgv_provider.CurrentRow.Index;
                int id_prov = int.Parse(dgv_provider.Rows[index].Cells[0].Value.ToString());

                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandText = "select * from Tel_list where Id =" + id_prov;
                cmd2.Connection = con;

                SqlDataReader reader2 = cmd2.ExecuteReader();
                List<string> PhoneNum = new List<string>();
                while (reader2.Read())
                {
                    PhoneNum.Add(reader2.GetString(1));
                }
                reader2.Close();
                list_num.DataSource = PhoneNum;

                SqlCommand cmd3 = new SqlCommand();
                cmd3.CommandText = "select * from TypeProvider where IdProvider =" + id_prov;
                cmd3.Connection = con;

                SqlDataReader reader3 = cmd3.ExecuteReader();
                List<string> ToyType = new List<string>();
                while (reader3.Read())
                {
                    ToyType.Add(reader3.GetString(1));
                }
                reader3.Close();
                list_type.DataSource = ToyType;

                SqlCommand cmd4 = new SqlCommand();
                cmd4.CommandText = "select * from Provider where Id =" + id_prov;
                cmd4.Connection = con;
                SqlDataReader reader4 = cmd4.ExecuteReader();
                if (reader4.Read())
                {

                    txt_name.Text = reader4.GetString(1);
                    txt_mail.Text = reader4.GetString(2);
                    txt_adress.Text = reader4.GetString(3);

                }
                reader4.Close();

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

        private void list_num_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_num.Text = list_num.SelectedItem.ToString();
        }

        private void list_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_types.Text = list_type.SelectedItem.ToString();
        }

        private void btn_modif_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            int index = dgv_provider.CurrentRow.Index;
            int id_pro = int.Parse(dgv_provider.Rows[index].Cells[0].Value.ToString());


            if (txt_name.Text.Length == 0)
                MessageBox.Show("Name field is empty");
            else if (txt_mail.Text.Length == 0)
                MessageBox.Show("E-mail field is empty");
            else if (txt_adress.Text.Length == 0)
                MessageBox.Show("Adress field is empty");

            else
            {
                DialogResult R = MessageBox.Show("Are you sure you want to modify the Provider?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (R == DialogResult.Yes)
                {

                    try
                    {
                        con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = " UPDATE Provider SET Name=@nom ,Email=@mail ,Adress=@adress where Id=" + id_pro;
                        cmd.Parameters.AddWithValue("@nom", txt_name.Text);
                        cmd.Parameters.AddWithValue("@mail", txt_mail.Text);
                        cmd.Parameters.AddWithValue("@adress", txt_adress.Text);
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();


                        try
                        {
                            con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
                            con.Open();

                            SqlCommand cmd3 = new SqlCommand();
                            cmd3.CommandText = "select * from Provider";
                            cmd3.Connection = con;


                            SqlDataReader reader = cmd3.ExecuteReader();
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
                            dgv_provider.DataSource = lstProvider;
                            dgv_provider.ClearSelection();
                            dgv_provider.SelectionChanged += Dgv_provider_SelectionChanged;
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
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                else
                {
                    MessageBox.Show("modification is canceled", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_modiflist_Click(object sender, EventArgs e)
        {
            int index = dgv_provider.CurrentRow.Index;
            int id_pro = int.Parse(dgv_provider.Rows[index].Cells[0].Value.ToString());
            SqlConnection con = null;
            String num2 = list_num.SelectedItem.ToString();
            String type2 = list_type.SelectedItem.ToString();

            if (txt_num.Text.Length == 0)
                MessageBox.Show("No number added");
            else if (txt_num.Text.Length != 8)
            {
                MessageBox.Show("Number should have exactly 8 figures");
                txt_num.Clear();
            }
            else if (int.TryParse(txt_num.Text, out int number) == false)
            {
                MessageBox.Show("Phone number should be only numeric");
                txt_num.Clear();
            }

            else
            {
                DialogResult R = MessageBox.Show("Are you sure you want to modify the phone number", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (R == DialogResult.Yes)
                {
                    try
                    {
                        con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
                        con.Open();
                        SqlCommand cmd1 = new SqlCommand();
                        cmd1.CommandText = " UPDATE Tel_list SET Tel_number=@num where Tel_number=@oldnum";
                        cmd1.Parameters.AddWithValue("@num", txt_num);
                        cmd1.Parameters.AddWithValue("oldnum", num2);
                        cmd1.Connection = con;
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("phone number modified");
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }

                    finally
                    {
                        if (con != null && con.State == ConnectionState.Open)
                            con.Close();
                    }

                }

                else
                { MessageBox.Show("modification is canceled", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

                DialogResult R1 = MessageBox.Show("Are you sure you want to modify the toy type", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (R1 == DialogResult.Yes)

                    try
                    {
                        con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
                        con.Open();
                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.CommandText = " UPDATE TypeProvider SET ToyType=@type where ToyType=@oldtype and IdProvider=@id";
                        cmd2.Parameters.AddWithValue("@type", cmb_types.SelectedItem);
                        cmd2.Parameters.AddWithValue("@oldtype", type2);
                        cmd2.Parameters.AddWithValue("@id", id_pro);
                        cmd2.Connection = con;
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Toy type modified");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }

                    finally
                    {
                        if (con != null && con.State == ConnectionState.Open)
                            con.Close();
                    }
                else
                { MessageBox.Show("modification is canceled", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }

        private void btn_supplist_Click(object sender, EventArgs e)
        {
            int j = list_num.Items.Count;
            int i = list_type.Items.Count;
            int index = dgv_provider.CurrentRow.Index;
            int id_pro = int.Parse(dgv_provider.Rows[index].Cells[0].Value.ToString());
            SqlConnection con = null;
            String num2 = list_num.SelectedItem.ToString();

            if (j > 1)
            {
                DialogResult R = MessageBox.Show("Are you sure you want to Delete the phone number?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (R == DialogResult.Yes)
                {
                    try
                    {
                        con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
                        con.Open();
                        SqlCommand cmd4 = new SqlCommand();
                        cmd4.CommandText = "DELETE FROM Tel_list where Tel_number=@num and Id=@id";
                        cmd4.Parameters.AddWithValue("@num", num2);
                        cmd4.Parameters.AddWithValue("@id", id_pro);
                        cmd4.Connection = con;
                        cmd4.ExecuteNonQuery();
                        MessageBox.Show("phone number deleted");

                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }

                    finally
                    {
                        if (con != null && con.State == ConnectionState.Open)
                            con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("modification is canceled", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_num.Clear();
                }
            }
            else if (txt_num.Text.Length == 0)
            {
                MessageBox.Show("you cannot delete the phone number if you have only one");
                txt_num.Clear();
            }

            if (i > 1)
            {
                DialogResult R = MessageBox.Show("Are you sure you want to Delete the toy type?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (R == DialogResult.Yes)
                    try
                    {
                        con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
                        con.Open();
                        SqlCommand cmd4 = new SqlCommand();
                        cmd4.CommandText = "DELETE FROM TypeProvider where IdProvider=@id and ToyType=@type";
                        cmd4.Parameters.AddWithValue("@type", cmb_types.SelectedItem);
                        cmd4.Parameters.AddWithValue("@id", id_pro);
                        cmd4.Connection = con;
                        cmd4.ExecuteNonQuery();
                        MessageBox.Show("Toy Type deleted");

                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }

                    finally
                    {
                        if (con != null && con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            else
            {
                MessageBox.Show("modification is canceled", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_types.SelectedIndex = -1;
            }
        }

        private void btn_ajoutlist_Click(object sender, EventArgs e)
        {
            int index = dgv_provider.CurrentRow.Index;
            int id_pro = int.Parse(dgv_provider.Rows[index].Cells[0].Value.ToString());
            String new_num = txt_num.Text;
            String new_type = cmb_types.SelectedItem.ToString();
            SqlConnection con = null;

            DialogResult R = MessageBox.Show("Are you sure you want to add the phone number?", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (R == DialogResult.Yes)
            {
                if (txt_num.Text.Length == 0)
                    MessageBox.Show("No number added");
                else if (txt_num.Text.Length != 8)
                {
                    MessageBox.Show("Number should have exactly 8 figures");
                    txt_num.Clear();
                }
                else if (int.TryParse(txt_num.Text, out int number) == false)
                {
                    MessageBox.Show("Phone number should be only numeric");
                    txt_num.Clear();
                }
                else
                {
                    try
                    {
                        con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "INSERT INTO Tel_list (Id, Tel_number) VALUES (@id, @num)";
                        cmd.Parameters.AddWithValue("@num", new_num);
                        cmd.Parameters.AddWithValue("@id", id_pro);
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("phone number added");

                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }

                    finally
                    {
                        // this.ModifyProvider_Load(sender, e);
                        if (con != null && con.State == ConnectionState.Open)
                            con.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show("modification is canceled", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_num.Clear();
            }


            DialogResult R2 = MessageBox.Show("Are you sure you want to add the toy type?", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (R2 == DialogResult.Yes)
                try
                {
                    con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO TypeProvider (IdProvider, ToyType) VALUES (@id, @type)";
                    cmd.Parameters.AddWithValue("@type", new_type);
                    cmd.Parameters.AddWithValue("@id", id_pro);
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Toy type added");

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

                finally
                {
                    if (con != null && con.State == ConnectionState.Open)
                        con.Close();
                }

            else
            {
                MessageBox.Show("modification is canceled", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_types.SelectedIndex = -1;
            }

        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
