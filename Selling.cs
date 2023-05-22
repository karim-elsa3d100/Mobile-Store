using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MobileStore
{
    public partial class Selling : Form
    {
        public Selling()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\c# projects\MobileStore\bin\Debug\MobileStoreDb.mdf"";Integrated Security=True;Connect Timeout=30");
       
        private void populate()
        {
            Con.Open();
            string query = "select Mbrand , Mmodel , Mprice from MobileTbl";
            SqlDataAdapter da=new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            MobileDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populateAccess()
        {
            Con.Open();
            string query = "select Abrand , Amodel , Aprice from AccessoriTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            AccessorieDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void insertbill()
        {
            if (BillidTb.Text == "" || ClientName.Text == "")
            {
                MessageBox.Show("Missing Information to this bill to table of Bells . You need to add the id of  this bill");
            }
            else
            {
                int am  =Convert.ToInt32(Amount.Text);
                try
                {
                    Con.Open();
                    string sql = "insert into BillTbl values(" + BillidTb.Text + ",'" + ClientName.Text + "' , "+am+" )";
                    SqlCommand cmd = new SqlCommand(sql, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Added Successfully");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sum_Bills()
        {
            Con.Open();
            string query= "select count(Amt) from BillTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query  , Con);
            DataTable dt = new DataTable(); 
            sda.Fill(dt);
            SellAmountBtl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void Sum_Total_Sells()
        {
            Con.Open();
            string query = "select sum(Amt) from BillTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sumTotSells.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void Selling_Load(object sender, EventArgs e)
        {
            populate();
            populateAccess();
            Sum_Bills();
            Sum_Total_Sells();
        }

        private void MobileDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductTb.Text = MobileDGV.SelectedRows[0].Cells[0].Value.ToString()+ MobileDGV.SelectedRows[0].Cells[1].Value.ToString();
            PriceTb.Text = MobileDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

      
        private void AccessorieDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductTb.Text = AccessorieDGV.SelectedRows[0].Cells[0].Value.ToString() + AccessorieDGV.SelectedRows[0].Cells[1].Value.ToString();
            PriceTb.Text = AccessorieDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        int totalamount = 0, n = 0;
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(QtyTb.Text=="" || PriceTb.Text=="")
            {
                MessageBox.Show("Enter The Quantity");
            }
            else
            {
                int total = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PriceTb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BILLDGV);
                newRow.Cells[0].Value = ++n;
                newRow.Cells[1].Value = ProductTb.Text;
                newRow.Cells[2].Value = PriceTb.Text;
                newRow.Cells[3].Value = QtyTb.Text;
                newRow.Cells[4].Value = total;
                BILLDGV.Rows.Add(newRow);
                totalamount += total;
                Amount.Text= totalamount.ToString();    
            }
        }

        int prodid, prodqty, prodprice, ttotal, pos = 60;

        private void BillidTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();    
            this.Hide();
        }

        string prodname;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Mobile Store",new Font("Centruy Gothic" , 12, FontStyle.Bold) , Brushes.Blue, new Point(80) );
            e.Graphics.DrawString("ID PRODUCt PRICE QUANTITY TOTAL", new Font("Centruy Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            

            foreach(DataGridViewRow row in BILLDGV.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                prodname = "" + row.Cells["Column2"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column4"].Value) ;
                ttotal = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + prodid, new Font("Centruy Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(26, pos));
                e.Graphics.DrawString("" + prodname, new Font("Centruy Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(45, pos));
                e.Graphics.DrawString("" + prodprice, new Font("Centruy Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(120, pos));
                e.Graphics.DrawString("" + prodqty, new Font("Centruy Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(170, pos));
                e.Graphics.DrawString("" + ttotal, new Font("Centruy Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(235, pos));
                pos += 20;
            }
            e.Graphics.DrawString("Grand Total: Rs" + totalamount, new Font("Centruy Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(50,pos+50));
            e.Graphics.DrawString("********* Mobile Store **********" , new Font("Centruy Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(10, pos + 85));
            BILLDGV.Rows.Clear();
            totalamount = 0;
            n = 0;
            insertbill();
            Sum_Bills();
            Sum_Total_Sells();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if(printPreviewDialog1.ShowDialog()== DialogResult.OK) 
            {
                printDocument1.Print();
               
            }
        }
    }
}
