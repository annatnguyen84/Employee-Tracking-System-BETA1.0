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
    public partial class LogEmpHours : Form
    {
        public LogEmpHours()
        {
            InitializeComponent();
        }

        private void btnLogHrs_Click(object sender, EventArgs e)
        {

            int EmpID = int.Parse(txtEmpID.Text);
            DateTime WorkDate = dtpWorkDate.Value;
            int HoursWorked = int.Parse(txtHours.Text);
            EmpHour eh = new EmpHour(EmpID, WorkDate, HoursWorked);
            // call HoursLogged

            HoursLogged hl = new HoursLogged();
            Status result = hl.HrsLogged(eh);

            // message to say saved or not
            switch (result)
            {
                case Status.Successfull:
                    MessageBox.Show($"Hours logged Successfully");
                    break;
                case Status.Unsuccessfull:
                    MessageBox.Show($"Hours NOT logged!");
                    break;
            }

            
            StatusData<List<EmpHour>> List = hl.EmpHoursList();
            lvEmpHours.Items.Clear();
            foreach (EmpHour emp in List.Data)
            {
                lvEmpHours.Items.Add(new ListViewItem(new string[] { emp.EmpID.ToString(), $"{emp.FName} {emp.LName}", emp.WorkDate.ToString(), emp.HoursWorked.ToString() }));
            }
        }
        

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogEmpHours_Load(object sender, EventArgs e)
        {
            HoursLogged hl = new HoursLogged();
            StatusData<List<EmpHour>> result = hl.EmpHoursList();
            lvEmpHours.Items.Clear();
            foreach (EmpHour emp in result.Data)
            {
                lvEmpHours.Items.Add(new ListViewItem(new string[] { emp.EmpID.ToString(), $"{emp.FName} {emp.LName}", emp.WorkDate.ToString(), emp.HoursWorked.ToString() }));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lvEmpHours.Items.Clear();
            int ID = int.Parse(txtEmpID.Text);
            HoursLogged hl = new HoursLogged();
            StatusData<List<EmpHour>> result = hl.EmpIDHours(ID);
            foreach (EmpHour emp in result.Data)
            {
                lvEmpHours.Items.Add(new ListViewItem(new string[] { emp.EmpID.ToString(), $"{emp.FName} {emp.LName}", emp.WorkDate.ToString(), emp.HoursWorked.ToString() }));
            }

        }

    }
}
