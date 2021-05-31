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
    public partial class Subscription : Form
    {
        public Subscription()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {

            bool added = false;

            if(txt_mail.Text.Length==0)
                MessageBox.Show("E-mail adress is missing");
            else
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(txt_mail.Text);
                    SqlConnection con = null;
                    try
                    {
                        con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True");
                        con.Open();

                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "select * from Mail_list where Email = '" + txt_mail.Text + "'";
                        cmd.Connection = con;

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (!reader.HasRows)
                        {
                            SqlCommand cmd2 = new SqlCommand();
                            cmd2.CommandText = "Insert into [Mail_list] values (@mail)";
                            cmd2.Connection = con;

                            cmd2.Parameters.AddWithValue("@mail", txt_mail.Text);
                            cmd2.ExecuteNonQuery();
                            added = true;
                        }
                        else
                            MessageBox.Show("This E-mail already exists");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if(added == true)
                        {
                            if (con != null && con.State == ConnectionState.Open)
                                con.Close();
                            this.Close();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("E-mail adress given invalid");
                }
            }
        }
    }
}
