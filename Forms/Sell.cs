using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyStore.Forms
{
    public partial class Sell : Form
    {
        List<Classes.Toy> cart = new List<Classes.Toy>();

        public Sell()
        {
            InitializeComponent();
        }

        private void Sell_Load(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Toys where Stock >" + 0;
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

                dataGridView1.DataSource = lstToys;

                dataGridView1.CurrentRow.Selected = false;
                dataGridView1.ClearSelection();

                dataGridView1.Columns[0].Width = 30;
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[2].Width = 70;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Width = 50;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Width = 60;
                dataGridView1.Columns[8].Visible = false;
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count!=0)
            {
                int index=dataGridView1.CurrentRow.Index;
                int id_toy = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
                SqlConnection con = null;
                try
                {
                    con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True");
                    con.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select * from Toys where id = " + id_toy;
                    cmd.Connection = con;


                    SqlDataReader reader = cmd.ExecuteReader();
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

                        cart.Add(toy);
                    }
                    reader.Close();
                    con.Close();

                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = cart;

                    dataGridView2.Columns[0].Width = 30;
                    dataGridView2.Columns[1].Width = 100;
                    dataGridView2.Columns[2].Visible = false;
                    dataGridView2.Columns[3].Visible = false;
                    dataGridView2.Columns[4].Visible = false;
                    dataGridView2.Columns[5].Width = 50;
                    dataGridView2.Columns[6].Visible = false;
                    dataGridView2.Columns[7].Visible = false;
                    dataGridView2.Columns[8].Visible = false;
                    dataGridView2.ClearSelection();
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
            else
                MessageBox.Show("You should select a toy to add to cart");
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            int index = dataGridView2.CurrentRow.Index;
            int id_toy = int.Parse(dataGridView2.Rows[index].Cells[0].Value.ToString());
            cart.Remove(cart[index]);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = cart;

            dataGridView2.Columns[0].Width = 30;
            dataGridView2.Columns[1].Width = 100;
            dataGridView2.Columns[2].Visible = false;
            dataGridView2.Columns[3].Visible = false;
            dataGridView2.Columns[4].Visible = false;
            dataGridView2.Columns[5].Width = 50;
            dataGridView2.Columns[6].Visible = false;
            dataGridView2.Columns[7].Visible = false;
            dataGridView2.Columns[8].Visible = false;
            dataGridView2.ClearSelection();
        }

        private void createFacture(DataGridView dgv,string filePath,DateTime date,double somme)
        {
            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
            Document fact = new Document();
            PdfWriter writer = PdfWriter.GetInstance(fact, fs);
            fact.Open();
            fact.Add(new Paragraph("Date : " + date.ToString()));
            fact.Add(new Paragraph("\n\n"));
            fact.Add(new Paragraph("ID                    Name                    Price\n"));
            for (int i = 0; i < dgv.RowCount; i++)
            {
                for (int j = 0; j < dgv.Rows[i].Cells[0].Value.ToString().Length; j++)
                fact.Add(new Paragraph(dgv.Rows[i].Cells[0].Value.ToString()+ "                    " + dgv.Rows[i].Cells[1].Value.ToString()+ "                    " + dgv.Rows[i].Cells[5].Value.ToString()));
            }
            fact.Add(new Paragraph("                                       Total: "+somme));
            fact.Close();
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            double somme=0;
            string nbrFact = "";
            DateTime now = DateTime.Now;
            string factPath = "";
            if (dataGridView2.RowCount == 0)
                MessageBox.Show("You should select a toy to the cart");
            else
            {
                SqlConnection con = null;
                try
                {

                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        somme = somme + (double)dataGridView2.Rows[i].Cells[5].Value;
                    }
                    con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True");
                    con.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "insert into [Sales](IdCashier, SaleDateTime, SaleRecipe, Reciept) values (@idCaiss,@date,@somme,@facture)";
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@idCaiss",Program.idCaissLoged);
                    cmd.Parameters.AddWithValue("@date", now);
                    cmd.Parameters.AddWithValue("@somme", somme);
                    cmd.Parameters.AddWithValue("@facture", factPath);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.CommandText = "select max(IdSale) from Sales";
                    cmd2.Connection = con;
                    SqlDataReader reader = cmd2.ExecuteReader();
                    reader.Read();
                    nbrFact = reader.GetInt32(0).ToString();
                    reader.Close();

                    factPath = "C:\\Users\\chikh\\Desktop\\projet c#\\ToyStore\\Factures\\Facture" + nbrFact + ".pdf";

                    SqlCommand cmd3 = new SqlCommand();
                    cmd3.CommandText = "Update Sales set Reciept ='"+factPath+"'  where IdSale = "+nbrFact;
                    cmd3.Connection = con;
                    cmd3.ExecuteNonQuery();

                    minimizeStock(dataGridView2,somme);
                    toySale(dataGridView2);


                    MessageBox.Show("Sale is successful");
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
                createFacture(dataGridView2,factPath,now,somme);
            }
        }

        private void minimizeStock(DataGridView dgv, double somme)
        {
            int id_toy=0;
            int stock = 0;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True");
                con.Open();
                
                
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    id_toy = (int)dgv.Rows[i].Cells[0].Value;

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select Stock from Toys where Id = " + id_toy;
                    cmd.Connection = con;
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    stock = reader.GetInt32(0);
                    stock = stock - 1;
                    reader.Close();
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.CommandText = "update Toys set Stock = '" + stock + "' where Id = " + id_toy;
                    cmd2.Connection = con;
                    cmd2.ExecuteNonQuery();
                }
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

        private void toySale(DataGridView dgv)
        {
            int id_toy = 0;
            int id_sale = 0;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True");
                con.Open();
               

                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandText = "select max(IdSale) from Sales";
                cmd2.Connection = con;

                SqlDataReader reader = cmd2.ExecuteReader();
                reader.Read();
                id_sale = reader.GetInt32(0);
                reader.Close();

               
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    id_toy = (int)dgv.Rows[i].Cells[0].Value;

                    /*SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select Stock from Toys where Id = " + id_toy;
                    cmd.Connection = con;
                    SqlDataReader reader2 = cmd.ExecuteReader();
                    reader2.Read();
                    id_toy = reader2.GetInt32(0);
                    reader2.Close();*/

                    SqlCommand cmd3 = new SqlCommand();
                    cmd3.CommandText = "Insert into ToysSold(IdToy,IdSale) values (" + id_toy + "," + id_sale + ")";
                    cmd3.Connection = con;
                    cmd3.ExecuteNonQuery();
                }
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
