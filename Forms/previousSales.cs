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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace ToyStore.Forms
{
    public partial class previousSales : Form
    {
        public previousSales()
        {
            InitializeComponent();
        }

        List<Classes.Sale> sales = new List<Classes.Sale>();
        

        private void previousSales_Load(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Sales where IdCashier= " + Program.idCaissLoged;
                cmd.Connection = con;

                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Classes.Sale sale = new Classes.Sale();
                    sale.Id = reader.GetInt32(0);
                    sale.IdCashier = reader.GetInt32(1);
                    sale.Date = (DateTime)reader.GetDateTime(2);
                    sale.Somme = reader.GetDouble(3);
                    sale.Reciept = reader.GetString(4);

                    sales.Add(sale);
                }
                dataGridView1.DataSource = sales;
                dataGridView1.CurrentRow.Selected = false;
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

        private void btn_all_Click(object sender, EventArgs e)
        {
            this.previousSales_Load(sender, e);
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_facture_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count!=0)
            {
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    printDocument1.Print();
            }
            else
                MessageBox.Show("You mus select a row");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            String pdfPath = "";
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("You must select a row to show reciept");
            }
            else
            {
                int index = dataGridView1.CurrentRow.Index;
                int id_sale = (int)dataGridView1.Rows[index].Cells[0].Value;
                SqlConnection con = null;
                try
                {
                    con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
                    con.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "Select Reciept from Sales where IdSale =" + id_sale;
                    cmd.Connection = con;

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        pdfPath = reader.GetString(0);
                        reader.Close();
                        StringBuilder text = new StringBuilder();
                        using (PdfReader reader1 = new PdfReader(pdfPath))
                        {
                            for (int i = 1; i <= reader1.NumberOfPages; i++)
                            {
                                text.Append(PdfTextExtractor.GetTextFromPage(reader1, i));
                            }
                        }
                        e.Graphics.DrawString(((string)text.ToString()), new System.Drawing.Font("Arial", 20, FontStyle.Italic), Brushes.Black, new PointF(100, 100));
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

        

        private void btn_today_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                sales.Clear();
                con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Sales where IdCashier= " + Program.idCaissLoged + " and SaleDateTime between '" + DateTime.Today + "' AND '" + DateTime.Now +"'";
                cmd.Connection = con;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Classes.Sale sale = new Classes.Sale();
                    sale.Id = reader.GetInt32(0);
                    sale.IdCashier = reader.GetInt32(1);
                    sale.Date = (DateTime)reader.GetDateTime(2);
                    sale.Somme = reader.GetDouble(3);
                    sale.Reciept = reader.GetString(4);

                    sales.Add(sale);
                }
                if (sales.Count != 0)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.DataSource = sales;
                    dataGridView1.CurrentRow.Selected = false;
                }
                else
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
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

        private void btn_period_Click(object sender, EventArgs e)
        {
            
            if (dtp1.Value > DateTime.Today)
                MessageBox.Show("Start date should be older than today");
            else
            {
                sales.Clear();
                SqlConnection con = null;
                try
                {
                    con = new SqlConnection(@"Data Source=DESKTOP-60KLJAJ;Initial Catalog=toybosDB;Integrated Security=True;Pooling=False");
                    con.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select * from Sales where IdCashier= " + Program.idCaissLoged + " and SaleDateTime between '" + dtp1.Value + "' and '" + dtp2.Value + "'";
                    cmd.Connection = con;

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Classes.Sale sale = new Classes.Sale();
                        sale.Id = reader.GetInt32(0);
                        sale.IdCashier = reader.GetInt32(1);
                        sale.Date = (DateTime)reader.GetDateTime(2);
                        sale.Somme = reader.GetDouble(3);
                        sale.Reciept = reader.GetString(4);

                        sales.Add(sale);
                    }
                    if(sales.Count!=0)
                    {
                        dataGridView1.DataSource = null;
                        dataGridView1.Rows.Clear();
                        dataGridView1.DataSource = sales;
                        dataGridView1.CurrentRow.Selected = false;
                    }
                    else
                    {
                        dataGridView1.DataSource = null;
                        dataGridView1.Rows.Clear();
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
}
