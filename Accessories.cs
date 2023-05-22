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
    public partial class Accessories : Form
    {
        public Accessories()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\c# projects\MobileStore\bin\Debug\MobileStoreDb.mdf"";Integrated Security=True;Connect Timeout=30");
      
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Accessories_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void populate()
        {
            Con.Open();
            string query = "select *from AccessoriTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            AccessorieDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (AidTb.Text == "" || AbrandTb.Text == "" || AmodelTb.Text == "" || ApriceTb.Text == "" || AstockTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string sql = "insert into AccessoriTbl values(" + AidTb.Text + ",'" + AbrandTb.Text + "' , '" + AmodelTb.Text + "'  , "+ AstockTb.Text +" , " + ApriceTb.Text +")";
                    SqlCommand cmd = new SqlCommand(sql, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Accessory Added Successfully");
                    Con.Close();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AidTb.Text = "";
            AbrandTb.Text = "";
            AmodelTb.Text = "";
            ApriceTb.Text = "";
            AstockTb.Text = "";
        }

        

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (AidTb.Text == "")
            {
                MessageBox.Show("Enter the Accessorie Id to be Deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from AccessoriTbl where AId= " + AidTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Accessorie deleted");
                    Con.Close();
                    populate();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (AidTb.Text == "" || AbrandTb.Text == "" || AmodelTb.Text == "" || ApriceTb.Text == "" || AstockTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string sql = "update AccessoriTbl set Abrand = '" + AbrandTb.Text + "' , AModel= '" + AmodelTb.Text + "' , APrice=" + ApriceTb.Text + ", AStock=" + AstockTb.Text + " where AId="+AidTb.Text+";";
                    SqlCommand cmd = new SqlCommand(sql, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Accessorie Updated Successfully");
                    Con.Close();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void AccessorieDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AidTb.Text = AccessorieDGV.SelectedRows[0].Cells[0].Value.ToString();
            AbrandTb.Text = AccessorieDGV.SelectedRows[0].Cells[1].Value.ToString();
            AmodelTb.Text = AccessorieDGV.SelectedRows[0].Cells[2].Value.ToString();
            AstockTb.Text = AccessorieDGV.SelectedRows[0].Cells[3].Value.ToString();
            ApriceTb.Text = AccessorieDGV.SelectedRows[0].Cells[4].Value.ToString();
           
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.Show();
            this.Hide();
        }
    }
}
