using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ETS.Entity;
using ETS.Logic;

namespace ETS.View
{
    public partial class ManageEmpDetails : Form
    {
        public ManageEmpDetails()
        {
            InitializeComponent();
        }
        private void btnSearchByID_Click(object sender, EventArgs e)
        {
            // Get the id from txtEmpID
            int ID = int.Parse(MtxtEmpID.Text);
            // call FindEmployee method 


            // call the service
            EmployeeServices serv = new EmployeeServices();
            StatusData<Employee> findEmp = serv.FindEmp(ID);
            //Dispaly output 
            if (findEmp.Data == null)
            {
                MessageBox.Show("Not Found");
            }
            else
            {
                MtxtFName.Text = findEmp.Data.FName;
                MtxtLName.Text = findEmp.Data.LName;
                MtxtEmail.Text = findEmp.Data.Email;
                MtxtPhone.Text = findEmp.Data.Phone;
                MdtpDOB.Value = findEmp.Data.DOB.ToLocalTime();
            }

        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(MtxtEmpID.Text);
            Employee emp = new Employee();
            emp.FName = MtxtFName.Text;
            emp.LName = MtxtLName.Text;
            emp.Email = MtxtEmail.Text;
            emp.DOB = MdtpDOB.Value;
            emp.Phone = MtxtPhone.Text;

            // call the service
            EmployeeServices serv = new EmployeeServices();
            Status result = serv.UpdatedEmp(emp,ID);

            // check if detials have been saved
            if (result == Status.Unsuccessfull)
            {
                MessageBox.Show("Employee detials have not updated!");
            }
            else if (result == Status.Successfull)
            {
                MessageBox.Show("Employee record are updated");
            }

            lvEmpList.Items.Clear();
           // EmployeeServices serv = new EmployeeServices();
            StatusData<List<Employee>> List = serv.ListDetails();


            foreach (Employee empList in List.Data)
            {
                lvEmpList.Items.Add(new ListViewItem(new string[] { empList.EmpID.ToString(), empList.FName + " " + empList.LName, empList.Email.ToString() }));
            }

        }

        
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageEmpDetails_Load(object sender, EventArgs e)
        {
            EmployeeServices serv = new EmployeeServices();
            StatusData<List<Employee>> result = serv.ListDetails();

            lvEmpList.Items.Clear();
            foreach (Employee emp in result.Data)
            {
                
                lvEmpList.Items.Add(new ListViewItem(new string[] { emp.EmpID.ToString(), emp.FName + " " + emp.LName, emp.Email.ToString() }));
            }
           
        }

        private void btnSearchEmail_Click(object sender, EventArgs e)
        {
          
            string Email = MtxtEmail.Text;
            // call FindEmployee method 


            // call the service
            EmployeeServices serv = new EmployeeServices();
            StatusData<Employee> findEmailEmp = serv.FindEmailEmp(Email);

            //Dispaly output 
            if (findEmailEmp.Data == null)
            {
                MessageBox.Show("Not Found");
            }
            else
            {
                MtxtEmpID.Text = findEmailEmp.Data.EmpID.ToString();
                MtxtFName.Text = findEmailEmp.Data.FName;
                MtxtLName.Text = findEmailEmp.Data.LName;
                MtxtPhone.Text = findEmailEmp.Data.Phone;
                MdtpDOB.Value = findEmailEmp.Data.DOB.ToLocalTime();
            }
        }

        private void MtxtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!RegularExpression.EmailValidation(MtxtEmail.Text.ToString()))
            {
                var message = MessageBox.Show("Please enter a valid Email Address", "Error", MessageBoxButtons.RetryCancel,
                                 MessageBoxIcon.Error);
                if (message == DialogResult.Retry)
                {
                    MtxtEmail.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void MtxtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (!RegularExpression.PhoneValidation(MtxtPhone.Text.ToString()))
            {
                var message = MessageBox.Show("Please enter a valid Number in Sequence of (00)0000-0000 or 0000 000 000 or 0000000000", "Error", MessageBoxButtons.RetryCancel,
                                 MessageBoxIcon.Error);
                if (message == DialogResult.Retry)
                {
                    MtxtPhone.SelectAll();
                    e.Cancel = true;
                }
            }
        }

       
    }
}