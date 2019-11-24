using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ETS.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmpDetails_Click(object sender, EventArgs e)
        {
            EmployeeDetails ed = new EmployeeDetails();
            ed.ShowDialog();
        }

        private void btnManageDetails_Click(object sender, EventArgs e)
        {
            ManageEmpDetails med = new ManageEmpDetails();
            med.ShowDialog();
        }

        private void btnLogHours_Click(object sender, EventArgs e)
        {
            LogEmpHours log = new LogEmpHours();
            log.ShowDialog();
        }

      
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
