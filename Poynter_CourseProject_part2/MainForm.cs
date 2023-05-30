using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poynter_CourseProject_part2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        

        private void addButton_Click(object sender, EventArgs e)
        {
            // add item to the employy listbox
            inputForm frmInput = new inputForm();

            using (frmInput)
            {
                DialogResult result = frmInput.ShowDialog();

                // see if input form was cancelled
                if (result == DialogResult.Cancel)
                    return;

                // get users input and create employee object

                string fName = frmInput.firstNameTextBox.Text;
                string lName = frmInput.lastNameTextBox.Text;
                string ssn = frmInput.SSNTextBox.Text;
                string date = frmInput.hireDateText.Text;
                DateTime hireDate = DateTime.Parse(date);
                string healthIns = frmInput.HealthInsuranceTextBox.Text;
                int lifeIns = int.Parse(frmInput.LifeInsuranceTextBox.Text);
                int vacation = int.Parse(frmInput.VacationDaysTextBox.Text);
                Benefits ben = new Benefits(healthIns, lifeIns, vacation);

                Employee emp = new Employee(fName, lName, ssn, hireDate, ben);

                // add the emp obj to employee listbox
                EmployeeListBox.Items.Add(emp);

                //write all data to file
                WriteEmpsToFile();
            }
        }

        private void WriteEmpsToFile()
        {
            string filename = "Employees.csv";

            StreamWriter sw = new StreamWriter(filename);
            foreach (Employee emp in EmployeeListBox.Items) 
            { 
                sw.WriteLine(emp.FirstName + ',' +  emp.LastName + ',' + emp.SSN + ',' + emp.HireDate.ToShortDateString() + "," + emp.BenefitsEmp.HealthInsurance + ',' + emp.BenefitsEmp.LifeInsurance + ',' + emp.BenefitsEmp.Vacation);
            }

            sw.Close();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // remove the selected item from the employee listbox
            int itemNumber = EmployeeListBox.SelectedIndex;

            if (itemNumber > -1)
            {
                EmployeeListBox.Items.RemoveAt(itemNumber);
                WriteEmpsToFile();
            }
            else
            {
                MessageBox.Show("Please select employee to remove.");
            }

        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // clear the employee listbox
            EmployeeListBox.Items.Clear();

            // read emps from file
            string filename = "Employees.csv";
            StreamReader sr = new StreamReader(filename);

            while (sr.Peek() > -1)
            {
                string line = sr.ReadLine();
                string[] parts = line.Split(',');
                string firstName = parts[0];
                string lastName = parts[1];
                string ssn = parts[2];
                DateTime hireDate = DateTime.Parse(parts[3]);
                string healthIns = parts[4];
                int lifeIns = int.Parse(parts[5]);
                int vacation = int.Parse(parts[6]);

                Benefits ben = new Benefits (healthIns, lifeIns, vacation);
                Employee emp = new Employee(firstName, lastName, ssn, hireDate, ben);
                EmployeeListBox.Items.Add(emp);
            }
            sr.Close();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing paychecks for all employees...");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void EmployeeListBox_DoubleClick(object sender, EventArgs e)
        {
            //get selected employee object
            Employee emp = EmployeeListBox.SelectedItem as Employee;

            // show the input/update form with the employee info
            inputForm frmUpdate = new inputForm();

            frmUpdate.firstNameTextBox.Text = emp.FirstName;
            frmUpdate.lastNameTextBox.Text = emp.LastName;
            frmUpdate.SSNTextBox.Text = emp.SSN;
            frmUpdate.hireDateText.Text = emp.HireDate.ToShortDateString();
            frmUpdate.HealthInsuranceTextBox.Text = emp.BenefitsEmp.HealthInsurance;
            frmUpdate.LifeInsuranceTextBox.Text = emp.BenefitsEmp.LifeInsurance.ToString();
            frmUpdate.VacationDaysTextBox.Text = emp.BenefitsEmp.Vacation.ToString();

            DialogResult result = frmUpdate.ShowDialog();

            // if cancelled stop method

            if (result == DialogResult.Cancel)
            {
                return;
            }

            // delete the selected obj

            int position = EmployeeListBox.SelectedIndex;
            EmployeeListBox.Items.RemoveAt(position);

            // create new emp using the updated info

            Employee newEmp = new Employee();
            newEmp.FirstName = frmUpdate.firstNameTextBox.Text;
            newEmp.LastName = frmUpdate.lastNameTextBox.Text;
            newEmp.SSN = frmUpdate.SSNTextBox.Text;
            newEmp.HireDate = DateTime.Parse(frmUpdate.hireDateText.Text);
            newEmp.BenefitsEmp.HealthInsurance = frmUpdate.HealthInsuranceTextBox.Text;
            newEmp.BenefitsEmp.LifeInsurance = int.Parse(frmUpdate.LifeInsuranceTextBox.Text);
            newEmp.BenefitsEmp.Vacation = int.Parse(frmUpdate.VacationDaysTextBox.Text);

            // add new employee to listbox
            EmployeeListBox.Items.Add(newEmp);
        }
    }
}
