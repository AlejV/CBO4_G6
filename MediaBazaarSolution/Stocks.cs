using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Globalization;


namespace MediaBazaarSolution
{
    public partial class Stocks : Form
    {
        MySqlConnection ctc = new MySqlConnection("server=studmysql01.fhict.local;database=dbi400999;uid=dbi400999;password=Group6Project;");
        List<Product> allProducts = new List<Product>(); 
        public Stocks()
        {
            InitializeComponent();
            LoadAllStocks();

        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            var connectionString = "Server=studmysql01.fhict.local;Uid=dbi400999;Database=dbi400999;Pwd=Group6Project;";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT departmentName FROM department";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        //Iterate through the rows and add it to the combobox's items
                        while (reader.Read())
                        {
                            cbProdDepartment.Items.Add(reader.GetString("departmentName"));
                            cbCurrDep.Items.Add(reader.GetString("departmentName"));
                            //cbxDepartment_Shifts.Items.Add(reader.GetString("departmentName"));
                        }
                    }
                }
            }
        }

        void LoadAllStocks()
        {
            lvAllProducts.Items.Clear();
            allProducts.Clear();
            string sql = "SELECT productName, numberInStock, price, departmentName FROM product;";
            MySqlCommand cmd = new MySqlCommand(sql, this.ctc);
            ctc.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                allProducts.Add(new Product(dr[0].ToString(), Convert.ToInt32(dr[1]), Convert.ToDouble(dr[2]), dr[3].ToString()));
            }
            for (int i = 0; i < allProducts.Count; i++)
            {
                string[] row = allProducts[i].GetDetails();
                lvAllProducts.Items.Add(allProducts[i].Name.ToString()).SubItems.AddRange(row);
                //lvStats.Items.Add(stats[i].id.ToString()).SubItems.AddRange(row);
            }
            ctc.Close();
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddProd_Click(object sender, EventArgs e)
        {
                MySqlConnection connection;
                string connectionString;
                connectionString = "Server=studmysql01.fhict.local;Uid=dbi400999;Database=dbi400999;Pwd=Group6Project;";
                connection = new MySqlConnection(connectionString);


                try
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        MessageBox.Show("Data entered succesfully.");
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO product (productName, numberInStock, price, departmentName) VALUES (@productName, @numberInStock, @price, @departmentName)", connection);
                        
                        cmd.Parameters.AddWithValue("@productName", Convert.ToString(tbProdName.Text));
                        cmd.Parameters.AddWithValue("@numberInStock", 0);
                        cmd.Parameters.AddWithValue("@price", Convert.ToDouble(tbProdPrice.Text));
                        cmd.Parameters.AddWithValue("@departmentName", Convert.ToString(cbProdDepartment.SelectedItem));
                        string[] row = { tbProdName.Text, "0", Convert.ToString(tbProdPrice.Text) };
                        var listViewItem = new ListViewItem(row);
                        lvAllProducts.Items.Add(listViewItem);
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                connection.Close();
                LoadAllStocks();
                //LoadStats();
            
        }

        private void LvAllProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadInsertTextboxes();
        }

        private void btnRemoveProd_Click(object sender, EventArgs e)
        {
            
            int index;
            index = lvAllProducts.FocusedItem.Index;

            string sql = $"DELETE FROM product WHERE productName ='{allProducts[index].Name};'";
            MySqlCommand cmd = new MySqlCommand(sql, this.ctc);
            //cmd.Parameters.AddWithValue("@productName", allProducts[index].Name); 
            ctc.Open();
            cmd.ExecuteNonQuery();
            ctc.Close();
            lvAllProducts.Items.Clear();
            LoadAllStocks();
            MessageBox.Show($"Product named {allProducts[index].Name} removed");

            //LoadStats();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index;
            index = lvAllProducts.FocusedItem.Index;

            //int employeeId = Convert.ToInt32(tbInsEmployeeID.Text);
            string productName = tbCurrName.Text;
            double price = Convert.ToDouble(tbCurrPrice.Text);
            int quantity = Convert.ToInt32(tbCurrQuantity.Text);

            MySqlConnection connection;
            string connectionString;
            connectionString = "Server=studmysql01.fhict.local;Uid=dbi400999;Database=dbi400999;Pwd=Group6Project;";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand($"UPDATE product SET productName = @productName, numberInStock = @numberInStock, price = @Price, departmentName = @departmentName WHERE productName = {allProducts[index].Name}", connection);
                    cmd.Parameters.AddWithValue("@productName", Convert.ToString(tbCurrName.Text));
                    cmd.Parameters.AddWithValue("@numberInStock", Convert.ToString(tbCurrQuantity.Text));
                    cmd.Parameters.AddWithValue("@price", Convert.ToString(tbCurrPrice.Text));
                    cmd.Parameters.AddWithValue("@productName", Convert.ToString(tbCurrName.Text));
                    cmd.Parameters.AddWithValue("@departmentName", Convert.ToString(cbCurrDep.SelectedItem));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
            LoadAllStocks();
        }


       /*void LoadInsertTextboxes() // method that loads info into the "edit info" textboxes
        {
            int index;
            index = lvAllProducts.FocusedItem.Index;

            string sql = $"SELECT productName, numberInStock, Price, departmentName FROM product WHERE productName={allProducts[index].Name};";
            MySqlCommand cmd = new MySqlCommand(sql, this.ctc);
            ctc.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                
                tbCurrName.Text = dr[0].ToString();
                tbCurrQuantity.Text = dr[1].ToString();
                tbCurrPrice.Text = dr[2].ToString();
                cbCurrDep.Text = dr[3].ToString();
               
                //allEmployees.Add(new Statistics(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString()));
            }
            ctc.Close();

        }
        */

    }
}
