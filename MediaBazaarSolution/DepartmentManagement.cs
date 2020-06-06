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

namespace MediaBazaarSolution
{
    public partial class DepartmentManagement : Form
    {
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi400999;uid=dbi400999;password=Group6Project;");
        List<Product> allProducts = new List<Product>();
        List<Statistics> allEmployees = new List<Statistics>();
        public DepartmentManagement()
        {
            InitializeComponent();
            LoadProducts();
            LoadEmployees();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Delete Button
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
                    MessageBox.Show("Department Deleted");
                    for (int i = 0; i < lbCurrentDep.SelectedItems.Count; i++)
                    {
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM department WHERE departmentName = '" + lbCurrentDep.SelectedItem + "'", connection);
                        //lbCurrentDep.Items.Remove(lbCurrentDep.SelectedItems[i]);
                       
                        cmd.ExecuteNonQuery();
                    }
               }
                else
                {
                    MessageBox.Show("Delete Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
            ////LoadDepartments();
            lbCurrentDep.SelectedIndex = 0;
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
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
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO department (departmentName) VALUES (@departmentName)", connection);
                    cmd.Parameters.AddWithValue("@departmentName", Convert.ToString(tbDepartmentName.Text));
                    lbCurrentDep.Items.Add(tbDepartmentName.Text);
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
        }
        void LoadDepartments()
        {
            lbCurrentDep.Items.Clear();
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
                            lbCurrentDep.Items.Add(reader.GetString("departmentName"));

                        }
                    }
                }
            }
            lbCurrentDep.SelectedIndex = 0;
        }
        private void DepartmentManagement_Load(object sender, EventArgs e)
        {
            LoadDepartments();
        }

        void LoadProducts()
        {
            //lvProducts_Dep.Items.Clear();
            string sql = $"SELECT productName, numberInStock, Price, departmentName FROM product";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                allProducts.Add(new Product(Convert.ToString(dr[0]), Convert.ToInt32(dr[1]), Convert.ToDouble(dr[2]), dr[3].ToString()));
            }
            conn.Close();
        }
        void RefreshProducts(string departmentName)
        {
            lvProducts_Dep.Items.Clear();
            string depName = departmentName;    
            for (int i = 0; i < allProducts.Count; i++)
            {
                if (allProducts[i].DepartmentName == depName)
                {
                    string[] row = allProducts[i].GetDetails();
                    lvProducts_Dep.Items.Add(allProducts[i].Name.ToString()).SubItems.AddRange(row);
                }
            }
        }

        void LoadEmployees() 
        {
            //lvEmployees_Dep.Items.Clear();
            allEmployees.Clear();
            string sql = "SELECT employeeID, firstName, lastName, position, departmentName FROM employee;";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                allEmployees.Add(new Statistics(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString()));
            }
            conn.Close();
        }
        void RefreshEmployees(string departmentName)
        {
            lvEmployees_Dep.Items.Clear();
            string depName = departmentName;
            for (int i = 0; i < allEmployees.Count; i++)
            {
                if (allEmployees[i].department == depName)
                {
                    string[] row = allEmployees[i].GetDetails();
                    lvEmployees_Dep.Items.Add(allEmployees[i].firstName.ToString()).SubItems.AddRange(row);
                }
                //lvStats.Items.Add(stats[i].id.ToString()).SubItems.AddRange(row);
            }
        }

        private void lbCurrentDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbCurrentDep.SelectedIndex;
            string departmentName = lbCurrentDep.SelectedItem.ToString();
            RefreshProducts(departmentName);
            RefreshEmployees(departmentName);
        }
    }
}
