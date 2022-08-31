using Constructors_ListView.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructors_ListView.GUI
{
    public partial class FormEmployee : Form
    {

        public FormEmployee()
        {
            InitializeComponent();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonList_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxEmpId.Text == "")
                MessageBox.Show("You must fill employeeID textbox");
            else
            {
                Employee emp = EmployeeIO.SearchRecord(Convert.ToInt32(textBoxEmpId.Text));
                string[] row = { emp.EmployeeId.ToString(), emp.FirstName, emp.LastName };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                textBoxEmpId.Clear();
                textBoxFirstName.Clear();
                textBoxLastName.Clear();
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxEmpId.Text == "")
                MessageBox.Show("You must fill employeeID textbox");
            else
            {
                Employee emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(textBoxEmpId.Text);
                emp.FirstName = textBoxFirstName.Text;
                emp.LastName = textBoxLastName.Text;
                EmployeeIO.SaveRecord(emp);
                textBoxEmpId.Clear();
                textBoxFirstName.Clear();
                textBoxLastName.Clear();
            }
        }
    }
}
