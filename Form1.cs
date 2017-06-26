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
            //fillCombo();
            
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fillData();
            Addbttn.Enabled = false;
            RMVALLBttn.Enabled = false;
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
            
    
            //MySqlCommand cmd;
            string selectQuery = "SELECT * FROM sampleinventory.inventory_tb ";
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            //cmd = new MySqlCommand(selectQuery, connection);
            //adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;


        }

        private void Addbttn_Click(object sender, EventArgs e)
        {
            string selectedpname;
            string selectedprice;
            string total;
            string valuewithoutdiscount;
            selectedpname = Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value);
            selectedprice = Convert.ToString(dataGridView2.CurrentRow.Cells[3].Value);
            valuewithoutdiscount = Convert.ToString(Convert.ToDouble(selectedprice)*Convert.ToDouble(quantitytxt.Text));
            total = Convert.ToString(Convert.ToDouble(valuewithoutdiscount) - ((Convert.ToDouble(dscnttxt.Text) / 100) * Convert.ToDouble(valuewithoutdiscount)));
            dataGridView1.Rows.Add(" ", selectedpname, quantitytxt.Text, selectedprice, total );
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
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
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
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[index];
            pnametxt.Text = selectedRow.Cells[1].Value.ToString();
            string selectedpcode;
            selectedpcode = Convert.ToString(dataGridView2.CurrentRow.Cells[0].Value);
            pcodetxt.Text = selectedpcode;
        }


        private void pnametxt_TextChanged(object sender, EventArgs e)
        {
            
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("product LIKE '{0}%'", pnametxt.Text);
                dataGridView2.DataSource = dv;
                
            
        }

        private void pcodetxt_TextChanged(object sender, EventArgs e)
        {
            
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("CONVERT(`Product Code`, 'System.String') LIKE '{0}%'", pcodetxt.Text);
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
            Application.Exit();
        }

        

       
        /*string getTotal()
        {
            int val = 0;
            string value;
            val = (Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value)) * (Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value));
            value = val.ToString();
            return value;
        }*/
        

        
    }
}
