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

namespace StreamingMusicService
{
    
    public partial class EmployeeManagement : Form
    {
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi400999;uid=dbi400999;password=Group6Project;");
        List<Statistics> stats = new List<Statistics>(); // this is is the list only with position "Employee"
        List<Statistics> allEmployees = new List<Statistics>(); //this is the list with all the people in the shop
        List<WorkerFullInfo> fullInfoList = new List<WorkerFullInfo>(); //this list is needed for the insert function
        public EmployeeManagement()
        {
            InitializeComponent();
            this.MinimumSize = new Size(400, 300);
            // Initialize required object
        }


        void Delete()
        {
            int id = 69;
            string sql = $"DELETE FROM product WHERE productID= {id};";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            //cmd.Parameters.AddWithValue("@userId", id); //int id = Convert.ToInt32(tbxId.Text);
            conn.Open();
            int effectedRows = cmd.ExecuteNonQuery();
            conn.Close();
        }
        void LoadStatsOld()
        {
            stats.Clear();
            string sql = "SELECT employeeID, firstName, position, departmentName FROM employee;";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                allEmployees.Add(new Statistics(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString()));
            }
            for (int i = 0; i < stats.Count; i++)
            {
                string[] row = stats[i].GetDetails();
                if (stats[i].position == "Employee")
                {
                    lvStats.Items.Add(stats[i].id.ToString()).SubItems.AddRange(row);

                }
                //lvStats.Items.Add(stats[i].id.ToString()).SubItems.AddRange(row);
            }
            conn.Close();
        } //this can be removed
        void LoadStats()
        {
            stats.Clear();
            lvStats.Items.Clear();
            for (int i = 0; i < allEmployees.Count; i++)
            {
                //string[] row = allEmployees[i].GetDetails();
                if (allEmployees[i].position == "Employee")
                {
                    stats.Add(new Statistics(allEmployees[i].id, allEmployees[i].firstName, allEmployees[i].position, allEmployees[i].department));
                }
                //lvStats.Items.Add(stats[i].id.ToString()).SubItems.AddRange(row);
            }
            for (int i = 0; i < stats.Count; i++)
            {
                string[] row = stats[i].GetDetails();
                lvStats.Items.Add(stats[i].id.ToString()).SubItems.AddRange(row);
            }
        }
        void LoadAllEmployees()
        {
            lvAllEmployees.Items.Clear();
            allEmployees.Clear();
            string sql = "SELECT employeeID, firstName, position, departmentName FROM employee;";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                allEmployees.Add(new Statistics(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString()));
            }
            for (int i = 0; i < allEmployees.Count; i++)
            {
                string[] row = allEmployees[i].GetDetails();
                    lvAllEmployees.Items.Add(allEmployees[i].id.ToString()).SubItems.AddRange(row); 
                //lvStats.Items.Add(stats[i].id.ToString()).SubItems.AddRange(row);
            }
            conn.Close();
        }
        private void btnUpdateShifts_Click(object sender, EventArgs e)
        {

        }
        
        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Manager");
            comboBox1.Items.Add("Administrator");
            comboBox1.Items.Add("Employee");
            cbxInsPosition.Items.Add("Manager");
            cbxInsPosition.Items.Add("Administrator");
            cbxInsPosition.Items.Add("Employee");

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
                            comboBox10.Items.Add(reader.GetString("departmentName"));
                            comboBox2.Items.Add(reader.GetString("departmentName"));

                        }
                    }
                }
            }

            //var connectionString = "Server=studmysql01.fhict.local;Uid=dbi400999;Database=dbi400999;Pwd=Group6Project;";
            //using (var connection = new MySqlConnection(connectionString))
            //{
            //    connection.Open();
            //    var query = "SELECT departmentName FROM department";
            //    using (var command = new MySqlCommand(query, connection))
            //    {
            //        using (var reader = command.ExecuteReader())
            //        {
            //            //Iterate through the rows and add it to the combobox's items
            //            while (reader.Read())
            //            {
            //                comboBox2.Items.Add(reader.GetString("departmentName"));
            //                cbxInsDepartment.Items.Add(reader.GetString("departmentName"));
            //            }
            //        }
            //    }
            //}
            LoadAllEmployees();
            LoadStats();
            try
            {
                MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi400999;uid=dbi400999;password=Group6Project;");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            for (int i = 0; i < 5; i++)
            {
                string[] row = {"Ivan","Petur","Zdravko"};
                lvMorning.Items.Add("25-06-2000").SubItems.AddRange(row);
            }
            /*BackColor = Color.FromArgb(255, 224, 192);
            lbUsers.Items.Clear();
            lbUsers.Items.AddRange(Soundcloud.GetUsers().ToArray());
            lblYourFavs.Text = "Please select a user from the Users list.";
            lblAvailable.Text = "No user selected";*/
        }  //Form1_Load !!!
        
        private void btnAddEmployee_Click(object sender, EventArgs e)
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
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO employee (employeeID, firstName, lastName, dateOfBirth, phone, address, contactFirstName, contactPhone, salary, position, departmentName) VALUES (@employeeID, @firstName, @lastName, @dateOfBirth, @phone, @address, @contactFirstName, @contactPhone, @salary, @position, @departmentName)", connection);
                    cmd.Parameters.AddWithValue("@employeeID", Convert.ToInt32(tbEmployeeID.Text));
                    cmd.Parameters.AddWithValue("@firstName", Convert.ToString(tbUsername.Text));
                    cmd.Parameters.AddWithValue("@lastName", Convert.ToString(tbLastName.Text));
                    cmd.Parameters.AddWithValue("@dateOfBirth", Convert.ToDateTime(dateTimePicker1.Value));
                    cmd.Parameters.AddWithValue("@phone", Convert.ToString(tbTel.Text));
                    cmd.Parameters.AddWithValue("@address", Convert.ToString(richTextBox1.Text));
                    cmd.Parameters.AddWithValue("@contactFirstName", Convert.ToString(tbContactName.Text));
                    cmd.Parameters.AddWithValue("@contactPhone", Convert.ToString(tbContactPhone.Text));
                    cmd.Parameters.AddWithValue("@salary", Convert.ToDecimal(tbSalary.Text));
                    cmd.Parameters.AddWithValue("@position", Convert.ToString(comboBox1.SelectedItem));
                    cmd.Parameters.AddWithValue("@departmentName", Convert.ToString(comboBox2.SelectedItem));
                    string[] row = { tbEmployeeID.Text, tbUsername.Text, Convert.ToString(comboBox1.SelectedItem), Convert.ToString(comboBox2.SelectedItem) };
                    var listViewItem = new ListViewItem(row);
                    lvAllEmployees.Items.Add(listViewItem);
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
            LoadAllEmployees();
            LoadStats();
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            //variables
            int index;
            index = lvAllEmployees.FocusedItem.Index;

            //function
            MessageBox.Show(index.ToString());
            MessageBox.Show(allEmployees[index].id.ToString());
            string sql = $"DELETE FROM employee WHERE employeeID={allEmployees[index].id};";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            //cmd.Parameters.AddWithValue("@userId", id); //int id = Convert.ToInt32(tbxId.Text);
            conn.Open();
            int effectedRows = cmd.ExecuteNonQuery();
            conn.Close();
            lvAllEmployees.Items.Clear();
            LoadAllEmployees();
            LoadStats();
        }

        private void btnConfirmChanges_Click(object sender, EventArgs e)
        {

            int index;
            index = lvAllEmployees.FocusedItem.Index;

            int employeeId = Convert.ToInt32(tbInsEmployeeID.Text);
            string firstName = tbInsFirstName.Text;
            string lastName = tbInsLastName.Text;
            DateTime birthDate = Convert.ToDateTime(dateTimePickerIns.Value);
            string telNumber = tbInsTelNumber.Text;
            string address = tbInsAddress.Text;
            string contactName = tbInsContactName.Text;
            string contactPhone = tbInsContactPhone.Text;
            double salary = Convert.ToDouble(tbInsSalary.Text);
            string position = cbxInsPosition.Text;
            string department = cbxInsDepartment.Text;

            MySqlConnection connection;
            string connectionString;
            connectionString = "Server=studmysql01.fhict.local;Uid=dbi400999;Database=dbi400999;Pwd=Group6Project;";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand($"UPDATE employee SET employeeID = @employeeID, firstName = @firstName, lastName = @lastName, dateOfBirth = @dateOfBirth, phone = @phone, address = @address, contactFirstName = @contactFirstName, contactPhone = @contactPhone, salary = @salary, position = @position, departmentName = @departmentName WHERE employeeID = {allEmployees[index].id}", connection);
                    cmd.Parameters.AddWithValue("@employeeID", Convert.ToInt32(tbInsEmployeeID.Text));
                    cmd.Parameters.AddWithValue("@firstName", Convert.ToString(tbInsFirstName.Text));
                    cmd.Parameters.AddWithValue("@lastName", Convert.ToString(tbInsLastName.Text));
                    cmd.Parameters.AddWithValue("@dateOfBirth", Convert.ToDateTime(dateTimePickerIns.Value));
                    cmd.Parameters.AddWithValue("@phone", Convert.ToString(tbInsTelNumber.Text));
                    cmd.Parameters.AddWithValue("@address", Convert.ToString(tbInsAddress.Text));
                    cmd.Parameters.AddWithValue("@contactFirstName", Convert.ToString(tbInsContactName.Text));
                    cmd.Parameters.AddWithValue("@contactPhone", Convert.ToString(tbInsContactPhone.Text));
                    cmd.Parameters.AddWithValue("@salary", Convert.ToDecimal(tbInsSalary.Text));
                    cmd.Parameters.AddWithValue("@position", Convert.ToString(cbxInsPosition.SelectedItem));
                    cmd.Parameters.AddWithValue("@departmentName", Convert.ToString(cbxInsDepartment.SelectedItem));
                    cmd.ExecuteNonQuery();

                    //string sql = $"UPDATE employee SET employeeID = {employeeId}, firstName = '{firstName}', lastName = '{lastName}' WHERE employeeID= {allEmployees[index].id};";
                    //MySqlCommand cmd = new MySqlCommand(sql, this.conn);
                    ////cmd.Parameters.AddWithValue("@userId", id); //int id = Convert.ToInt32(tbxId.Text);
                    //conn.Open();
                    //int effectedRows = cmd.ExecuteNonQuery();
                    //conn.Close();

                    //if (cmd.ExecuteNonQuery() == 1)
                    //{
                    //    MessageBox.Show("Information Edited Successfully!");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Can't edit information.");
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
            //string sql = $"UPDATE employee SET lastName = '{lastName}' WHERE employeeID= {allEmployees[index].id};";
            //MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            ////cmd.Parameters.AddWithValue("@userId", id); //int id = Convert.ToInt32(tbxId.Text);
            //conn.Open();
            //int effectedRows = cmd.ExecuteNonQuery();
            //conn.Close();
            LoadAllEmployees();
            LoadStats();
        }

        //switch case with all the months
        string CheckMonth()
        {
            string month = cbxMonth.Text;
            string toReturn = "";
            switch (month)
            {
                case "January":
                    toReturn = "2020-01-01' AND '2020-01-31";
                    break;
                case "February":
                    toReturn = "2020-02-01' AND '2020-02-29";
                    break;
                case "March":
                    toReturn = "2020-03-01' AND '2020-03-31";
                    break;
                case "April":
                    toReturn = "2020-04-01' AND '2020-04-30";
                    break;
                case "May":
                    toReturn = "2020-05-01' AND '2020-05-31";
                    break;
                case "June":
                    toReturn = "2020-06-01' AND '2020-06-30";
                    break;
                case "July":
                    toReturn = "2020-07-01' AND '2020-07-31";
                    break;
                case "August":
                    toReturn = "2020-08-01' AND '2020-08-31";
                    break;
                case "September":
                    toReturn = "2020-09-01' AND '2020-09-30";
                    break;
                case "October":
                    toReturn = "2020-10-01' AND '2020-10-31";
                    break;
                case "November":
                    toReturn = "2020-11-01' AND '2020-11-30";
                    break;
                case "December":
                    toReturn = "2020-12-01' AND '2020-12-31";
                    break;
            }
            return toReturn;
        }

        //void method for updating the statistics list
        void UpdateStatistics() 
        {
            //variables
            int index;
            index = lvStats.FocusedItem.Index;
            string firstName = stats[index].firstName;
            string department = stats[index].department;
            List<int> morningCount = new List<int>();
            List<int> afternoonCount = new List<int>();
            List<int> eveningCount = new List<int>(); //I made these List,I dk why, they should be int
            int salary = 0;
            int workedHours;
            int payroll;

            //morning shift counter
            string sql = $"SELECT COUNT(*) FROM morningshifts WHERE {department}='{firstName}' AND date BETWEEN '{CheckMonth()}';";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                morningCount.Add(Convert.ToInt32(dr[0]));
            }
            conn.Close();

            //afternoon shift counter
            string sqlB = $"SELECT COUNT(*) FROM afternoonshifts WHERE {department}='{firstName}' AND date BETWEEN '{CheckMonth()}';";
            MySqlCommand cmdB = new MySqlCommand(sqlB, this.conn);
            conn.Open();
            MySqlDataReader drB = cmdB.ExecuteReader();
            while (drB.Read())
            {
                afternoonCount.Add(Convert.ToInt32(drB[0]));
            }
            conn.Close();

            //evening shift counter
            string sqlC = $"SELECT COUNT(*) FROM eveningshifts WHERE {department}='{firstName}' AND date BETWEEN '{CheckMonth()}';";
            MySqlCommand cmdC = new MySqlCommand(sqlC, this.conn);
            conn.Open();
            MySqlDataReader drC = cmdC.ExecuteReader();
            while (drC.Read())
            {
                eveningCount.Add(Convert.ToInt32(drC[0]));
            }
            conn.Close();

            //The number of shifts per selected month Morning, Evening, Afternoon, 
            lblMorning.Text = morningCount[0].ToString();
            lblAfternoon.Text = afternoonCount[0].ToString();
            lblEvening.Text = eveningCount[0].ToString();

            //Favourite shift
            if (morningCount[0] > afternoonCount[0] && morningCount[0] > eveningCount[0])
            {
                lblFavShift.Text = "Morning";
                lblFavShift.ForeColor = Color.Gold;
            }
            else if (afternoonCount[0] > morningCount[0] && afternoonCount[0] > eveningCount[0])
            {
                lblFavShift.Text = "Afternoon";
                lblFavShift.ForeColor = Color.Orange;
            }
            else if (eveningCount[0] > morningCount[0] && eveningCount[0] > afternoonCount[0])
            {
                lblFavShift.Text = "Evening";
                lblFavShift.ForeColor = Color.OrangeRed;
            }
            else if (eveningCount[0] == morningCount[0])
            {
                lblFavShift.Text = "Evening \nor Morning";
                lblFavShift.ForeColor = Color.Orange;
            }
            else if (eveningCount[0] == afternoonCount[0])
            {
                lblFavShift.Text = "Evening \nor Afternoon";
                lblFavShift.ForeColor = Color.Orange;
            }
            else if (morningCount[0] == afternoonCount[0])
            {
                lblFavShift.Text = "Morning \nor Afternoon";
                lblFavShift.ForeColor = Color.Orange;
            }
            //payroll
            string sqlpayroll = $"SELECT salary FROM employee WHERE firstName='{firstName}';";
            MySqlCommand cmdpayroll = new MySqlCommand(sqlpayroll, this.conn);
            conn.Open();
            MySqlDataReader drpayroll = cmdpayroll.ExecuteReader();
            while (drpayroll.Read())
            {
                salary = Convert.ToInt32(drpayroll[0]);
            }
            //MessageBox.Show(salary.ToString(), "salary");
            conn.Close();

            workedHours = Convert.ToInt32(morningCount[0]) + Convert.ToInt32(afternoonCount[0]) + Convert.ToInt32(eveningCount[0]);
            //MessageBox.Show(workedHours.ToString(), "worked hours");

            payroll = salary * workedHours;
            lblPayroll.Text = payroll.ToString() + "€";
            lblWorkedHours.Text = workedHours.ToString() + " hours";
            if (workedHours == 0)
            {
                lblFavShift.Text = "-";
                lblFavShift.ForeColor = Color.Red;
            }
        }

        //updates the stats when changing people from the list
        private void lvStats_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatistics();
        }

        //updates the stats when changing month from the ComboBox
        private void cbxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatistics();

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
        void LoadInsertTextboxes() // method that loads info into the "edit info" textboxes
        {
            int index;
            index = lvAllEmployees.FocusedItem.Index;

            string sql = $"SELECT employeeID, firstName, lastName, dateOfBirth, phone, address, contactFirstName, contactPhone, salary, position, departmentName FROM employee WHERE employeeID={allEmployees[index].id};";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                tbInsEmployeeID.Text = dr[0].ToString();
                tbInsFirstName.Text = dr[1].ToString();
                tbInsLastName.Text = dr[2].ToString();
                dateTimePickerIns.Text = dr[3].ToString();
                tbInsTelNumber.Text = dr[4].ToString();
                tbInsAddress.Text = dr[5].ToString();
                tbInsContactName.Text = dr[6].ToString();
                tbInsContactPhone.Text = dr[7].ToString();
                tbInsSalary.Text = dr[8].ToString();
                cbxInsPosition.Text = dr[9].ToString();
                cbxInsDepartment.Text = dr[10].ToString();
                //allEmployees.Add(new Statistics(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString()));
            }
            conn.Close();

        }
        private void lvAllEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInsertTextboxes();
        }
    }
}
