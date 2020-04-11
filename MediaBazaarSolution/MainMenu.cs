using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarSolution
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnEmployeeManage_Click(object sender, EventArgs e)
        {
            EmployeeManagement employeeManagement = new EmployeeManagement();
            employeeManagement.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stocks stocks = new Stocks();
            stocks.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DepartmentManagement departmentManagement = new DepartmentManagement();
            departmentManagement.Show();

        }
    }
}
