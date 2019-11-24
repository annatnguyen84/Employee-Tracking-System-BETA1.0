using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // STEP 1: Select the SQL provider
using ETS.Entity; // use empHoirs

namespace ETS.Data
{
    public class EmpHoursDataAccess 
    {
        //ConnectionDataAccess start;
        SqlConnection conn;
        public void Insert(EmpHour empHrs)
        {
            //MAKE SURE SPELLING IS CORRECT within ""
            //STEP 2: Create, setup and open Connection object
            conn = new SqlConnection();
            //Setup
            conn.ConnectionString = @"Data Source=.;Initial Catalog=ETS_Database_1.0;Integrated Security=True";
            //open
            conn.Open();

            //start.Connect();

            // STEP 3: Create Command Obj
            SqlCommand cmd = new SqlCommand("sp_Insert_Employee_Hours", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@EmpID", empHrs.EmpID));
            cmd.Parameters.Add(new SqlParameter("@Date", empHrs.WorkDate));
            cmd.Parameters.Add(new SqlParameter("@Hours", empHrs.HoursWorked));
            


            // STEP 4: Execure the Cmd
            cmd.ExecuteNonQuery();

            // STEP 5: Handle Results

            // STEP 6: Close Connection
            conn.Close();
            //start.Disconnect();

        }
        public List<EmpHour> EmpHours() //find by Emp obj method
        {
                List<EmpHour> EmpList = new List<EmpHour>();
                //MAKE SURE SPELLING IS CORRECT within ""
                //STEP 2: Create, setup and open Connection object
                conn = new SqlConnection();
                //Setup
                conn.ConnectionString = @"Data Source=.;Initial Catalog=ETS_Database_1.0;Integrated Security=True";
                //open
                conn.Open();
                //create
                //start.Connect();
                // STEP 3: Create Command Obj
                SqlCommand cmd = new SqlCommand("sp_Select_EmpHours", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
               // cmd.Parameters.Add(new SqlParameter("@EmpID", EmpID));

                // STEP 4: Execure the Cmd
                SqlDataReader read = cmd.ExecuteReader();

                // STEP 5: Handle Results

                while (read.Read())
                {
                   
                    string FName = Convert.ToString(read["FirstName"]);
                    string LName = Convert.ToString(read["LastName"]);
                    int empID = Convert.ToInt32(read["EmpID"]);
                    DateTime WorkDate = Convert.ToDateTime(read["WorkDate"]);
                    int Hours = Convert.ToInt32(read["Hours"]);
                    EmpHour AllEmp = new EmpHour(empID, FName, LName, WorkDate, Hours);

                    EmpList.Add(AllEmp);
                }

                // STEP 6: Close Connection
                conn.Close();
                //start.Disconnect();
                // return the Emp OBJ
                return EmpList;
        }
        public List<EmpHour> EmpIDHours(int EmpID) //find by Emp obj method
        {
            List<EmpHour> EmpList = new List<EmpHour>();
            //MAKE SURE SPELLING IS CORRECT within ""
            //STEP 2: Create, setup and open Connection object
            conn = new SqlConnection();
            //Setup
            conn.ConnectionString = @"Data Source=.;Initial Catalog=ETS_Database_1.0;Integrated Security=True";
            //open
            conn.Open();
            //create
            //start.Connect();
            // STEP 3: Create Command Obj
            SqlCommand cmd = new SqlCommand("sp_Select_EmpHoursByEmpID", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@EmpID", EmpID));

            // STEP 4: Execure the Cmd
            SqlDataReader read = cmd.ExecuteReader();

            // STEP 5: Handle Results

            while (read.Read())
            {

                string FName = Convert.ToString(read["FirstName"]);
                string LName = Convert.ToString(read["LastName"]);
                int empID = Convert.ToInt32(read["EmpID"]);
                DateTime WorkDate = Convert.ToDateTime(read["WorkDate"]);
                int Hours = Convert.ToInt32(read["Hours"]);
                EmpHour AllEmp = new EmpHour(empID, FName, LName, WorkDate, Hours);

                EmpList.Add(AllEmp);
            }

            // STEP 6: Close Connection
            conn.Close();
            //start.Disconnect();
            // return the Emp OBJ
            return EmpList;
        }

    }
}