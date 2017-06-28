using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication3
{
    public partial class Form1 : Form 
    {   
        
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        DataTable dt = new DataTable();
        
        public Form1()
        {
            InitializeComponent();    
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fillData();
            Addbttn.Enabled = false;
            RMVALLBttn.Enabled = false;
            dscnttxt.Text = "0";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                Addbttn.Enabled = false;
                

            }
            if(dataGridView1.Columns[e.ColumnIndex].Name == "Remove"){
                dataGridView1.Rows.RemoveAt(this.dataGridView1.Rows[e.RowIndex].Index);

            }

        }
        private void fillData()
        {
            
            string selectQuery = "SELECT * FROM sampleinventory.product ";
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void Addbttn_Click(object sender, EventArgs e)
        {
            string selectedpname;
            string selectedprice;
            string total;
            string valuewithoutdiscount;
            string selectedpcode;

            selectedpname = Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value);
            selectedpcode = Convert.ToString(dataGridView2.CurrentRow.Cells[0].Value);
            selectedprice = pricetxt.Text;
            valuewithoutdiscount = Convert.ToString(Convert.ToDouble(selectedprice)*Convert.ToDouble(quantitytxt.Text));
            total = Convert.ToString(Convert.ToDouble(valuewithoutdiscount) - ((Convert.ToDouble(dscnttxt.Text) / 100) * Convert.ToDouble(valuewithoutdiscount)));
            dataGridView1.Rows.Add(" ", selectedpcode, selectedpname, quantitytxt.Text, selectedprice, total );
            RMVALLBttn.Enabled = true;
            addPrice();

       
        }

        private void Totaltxt_TextChanged(object sender, EventArgs e)
        {
        }
        void addPrice()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
            }
            Totaltxt.Text = sum.ToString();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {           
        }

        private void quantitytxt_TextChanged(object sender, EventArgs e)
        {           
        }
    
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {/*
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[index];
            pnametxt.Text = selectedRow.Cells[1].Value.ToString();
            string selectedpcode;
            selectedpcode = Convert.ToString(dataGridView2.CurrentRow.Cells[0].Value);
            pcodetxt.Text = selectedpcode;
            pricetxt.Text = Convert.ToString(dataGridView2.CurrentRow.Cells[5].Value);*/
        }


        private void pnametxt_TextChanged(object sender, EventArgs e)
        {
            
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("name LIKE '{0}%'", pnametxt.Text);
                dataGridView2.DataSource = dv;
       
        }

        private void pcodetxt_TextChanged(object sender, EventArgs e)
        {
            
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("CONVERT(`product_code`, 'System.String') LIKE '{0}%'", pcodetxt.Text);
                dataGridView2.DataSource = dv;
        }

        private void pnametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            pcodetxt.Enabled = false;
            
        }

        private void pcodetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            pnametxt.Enabled = false;
        }

        private void CLRBttn_Click(object sender, EventArgs e)
        {
            pnametxt.Text = null;
            pcodetxt.Text = null;
            quantitytxt.Text = null;
            dscnttxt.Text = null;
            pricetxt.Text = null;
            pcodetxt.Enabled = true;
            pnametxt.Enabled = true;
            Addbttn.Enabled = false;
            //RMVALLBttn.Enabled = false;
                
        }

        private void RMVALLBttn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Totaltxt.Text = null;
        }

        private void dscnttxt_TextChanged(object sender, EventArgs e)
        {
            
            if (quantitytxt.Text == "0" && quantitytxt.Text == null && pnametxt.Text == null && pcodetxt.Text == null && dscnttxt.Text == null)
            {
                Addbttn.Enabled = false;
                MessageBox.Show("Quantity cannot be zero");
                pcodetxt.Text = null;
                pnametxt.Text = null;
                quantitytxt.Text = null;
                MessageBox.Show("p");

            }
            else
            {
                Addbttn.Enabled = true;
            }
        }

        private void MASBttn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; ++i)
            {
                string currentstock = "";
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT stock FROM sampleinventory.product WHERE product_code = '" + Convert.ToString(dataGridView1.Rows[i].Cells[1].Value) + "'";

                try
                {
                    connection.Open();
                    MySqlDataReader myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        currentstock = Convert.ToString(Convert.ToInt32(myReader.GetString("stock")));
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

      
                string newstock = Convert.ToString(Convert.ToInt32(currentstock) - Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value));
                string updatequery = "UPDATE sampleinventory.product SET stock = '" + newstock + "' WHERE name = '" + Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) + "' ";
                MySqlCommand cmdsampleinventory = new MySqlCommand(updatequery, connection);
                try
                {
                    connection.Open();
                    int myread2er = cmdsampleinventory.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            string details = "";
            for (int i = 0; i < dataGridView1.Rows.Count - 1; ++i)
            {
                string product_code = "";
                string product = "";
                string quantity = "";
                string price = "";
                string total = "";

                product_code = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                product = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                quantity = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
                price = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);
                total = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value);

                details += product_code + " " + product + " " + quantity + " " + price + " " + total + "/" ;
            }
            try
            {
                DateTime current = DateTime.Now;
                string date = "";
                string time = "";

                date = current.ToShortDateString();
                time = current.ToLongTimeString();
                connection.Open();
                string insertquery = "INSERT INTO sampleinventory.invoice VALUES (null,@details,@date,@time)";
                MySqlCommand command = new MySqlCommand(insertquery, connection);
                command.Parameters.AddWithValue("@details", details);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@time", time);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            

            Addbttn.Enabled = false;
        }

        private void Exitbttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            string name = "";
            string code = "";
            string price = ""; 
            foreach (DataGridViewRow row in dataGridView2.SelectedRows){

                name = Convert.ToString(row.Cells[1].Value);
                code = Convert.ToString(row.Cells[0].Value);
                price = Convert.ToString(row.Cells[5].Value);
                pnametxt.Text = name;
                pcodetxt.Text = code;
                pricetxt.Text = price;
            }

            
        }
     
    }
}
