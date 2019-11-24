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
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            

            // connect input fields 
            Employee emp = new Employee();
            try
            {
                emp.FName = txtFName.Text;
                errorProvider1.SetError(txtLName, "");
            }
            catch 
            {
                MessageBox.Show("Must provide First Name");
            }
            try
            {
                emp.LName = txtLName.Text;
                errorProvider2.SetError(txtLName, "");
            }
            catch
            {
                MessageBox.Show("Must provide Last Name");
            }
            try
            {
                emp.Email = txtEmail.Text;
                errorProvider3.SetError(txtEmail, "");
            }
            catch
            {
                MessageBox.Show("Must provide Email");
            }
            try
            {
                emp.Phone = txtPhone.Text;
                errorProvider4.SetError(txtPhone, "");
            }
            catch
            {
                MessageBox.Show("Must provide Phone Number");
            }
            emp.DOB = dtpDOB.Value;
            
            

            // call the service
            EmployeeServices serv = new EmployeeServices();
         
            Status result = serv.SavedEmp(emp);
            // check if detials have been saved
            if (result == Status.Unsuccessfull)
            {
                MessageBox.Show("Employee detials NOT saved!");
            }
            else if (result == Status.Successfull)
            {
                MessageBox.Show($"Employee record has been created!\n\n" +
                                $"To Add a new Employee please click on clear, otherwise please return back to main screen.");
            
            }
            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtFName.Text = default;
            txtLName.Text = default;
            txtEmail.Text = default;
            txtPhone.Text = default;

            EmployeeServices serv = new EmployeeServices();
            int NextID = serv.GetEmpID();
            lblEmpID.Text = NextID.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            EmployeeServices serv = new EmployeeServices();
            int NextID = serv.GetEmpID();
            lblEmpID.Text = NextID.ToString();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!RegularExpression.EmailValidation(txtEmail.Text.ToString()))
            {
                var message = MessageBox.Show("Please enter a vlaid Email Address", "Error", MessageBoxButtons.RetryCancel,
                                 MessageBoxIcon.Error);
                if (message == DialogResult.Retry)
                {
                    txtEmail.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (!RegularExpression.PhoneValidation(txtPhone.Text.ToString()))
            {
                var message = MessageBox.Show("Please enter a vlaid Number in Sequence of (00)0000-0000 or 0000 000 000 or 0000000000", "Error", MessageBoxButtons.RetryCancel,
                                 MessageBoxIcon.Error);
                if (message == DialogResult.Retry)
                {
                    txtPhone.SelectAll();
                    e.Cancel = true;
                }
            }
        }
    }
}
