using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient; // STEP 1: Select the SQL provider
using ETS.Entity; // use Employee
using System.Data;
using System.Windows.Forms;

namespace ETS.Data
{
    public class EmployeeDataAccess
    {
        SqlConnection conn;
        //ConnectionDataAccess start;
        public void Insert(Employee emp)
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
            SqlCommand cmd = new SqlCommand("sp_Insert_Employee", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@FName", emp.FName));
            cmd.Parameters.Add(new SqlParameter("@LName", emp.LName));
            cmd.Parameters.Add(new SqlParameter("@Email", emp.Email));
            cmd.Parameters.Add(new SqlParameter("@DOB", emp.DOB));
            cmd.Parameters.Add(new SqlParameter("@Phone", emp.Phone));


            // STEP 4: Execure the Cmd
            cmd.ExecuteNonQuery();

            // STEP 5: Handle Results

            // STEP 6: Close Connection
            conn.Close();
            
            //start.Disconnect();
            
        }

        
        public int GetEmpID()
        {
            int NewID = 0;
            //MAKE SURE SPELLING IS CORRECT within ""
            //STEP 2: Create, setup and open Connection object
            //create
            conn = new SqlConnection();
            //Setup
            conn.ConnectionString = @"Data Source=.;Initial Catalog=ETS_Database_1.0;Integrated Security=True";
            //open
            conn.Open();
            //start.Connect();
            // STEP 3: Create Command Obj
            SqlCommand cmd = new SqlCommand("sp_Return_Next_EmpID", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            // STEP 4: Execure the Cmd
            SqlDataReader reader = cmd.ExecuteReader();

            // STEP 5: Handle Results
            if (reader.Read())
            {
                NewID = Convert.ToInt32(reader["NextEmpNum"]);
            }
            // STEP 6: Close Connection
            conn.Close();
            
            //start.Disconnect();
            return NewID;
        }
        public Employee FindByID(int ID) //find by Emp obj method
        {
            Employee findEmp = null;
            //MAKE SURE SPELLING IS CORRECT within ""
            //STEP 2: Create, setup and open Connection object
            conn = new SqlConnection();
            //Setup
            conn.ConnectionString = @"Data Source=.;Initial Catalog=ETS_Database_1.0;Integrated Security=True";
            //open
            conn.Open();

            //start.Connect();
            // STEP 3: Create Command Obj
            SqlCommand cmd = new SqlCommand("sp_Select_EmpByID", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@EmpID", ID)); // use ARRGUMENT 

            // STEP 4: Execure the Cmd
            SqlDataReader read = cmd.ExecuteReader();
            // STEP 5: Handle Results
            if (read.Read())
            {
                findEmp = new Employee();
                findEmp.EmpID = Convert.ToInt32(read["EmpID"]);
                findEmp.FName = Convert.ToString(read["FirstName"]);
                findEmp.LName = Convert.ToString(read["LastName"]);
                findEmp.Email = Convert.ToString(read["Email"]);
                findEmp.DOB = Convert.ToDateTime(read["DOB"]);
                findEmp.Phone = Convert.ToString(read["Phone"]);
                
            }

            // STEP 6: Close Connection
            conn.Close();
            
            //start.Disconnect();
            // return the Emp OBJ
            return findEmp;
        }
        public Employee FindByEmail(string Email) //find by Emp obj method
        {
            Employee findEmpEmail = null;
            //MAKE SURE SPELLING IS CORRECT within ""
            //STEP 2: Create, setup and open Connection object
            conn = new SqlConnection();
            //Setup
            conn.ConnectionString = @"Data Source=.;Initial Catalog=ETS_Database_1.0;Integrated Security=True";
            //open
            conn.Open();
            // start.Connect();
            // STEP 3: Create Command Obj
            SqlCommand cmd = new SqlCommand("sp_Select_EmpByEmail", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Email", Email)); // use ARRGUMENT 

            // STEP 4: Execure the Cmd
            SqlDataReader read = cmd.ExecuteReader();
            // STEP 5: Handle Results
            if (read.Read())
            {
                findEmpEmail = new Employee();
                findEmpEmail.EmpID = Convert.ToInt32(read["EmpID"]);
                findEmpEmail.FName = Convert.ToString(read["FirstName"]);
                findEmpEmail.LName = Convert.ToString(read["LastName"]);
                findEmpEmail.DOB = Convert.ToDateTime(read["DOB"]);
                findEmpEmail.Phone = Convert.ToString(read["Phone"]);
                
            }

            // STEP 6: Close Connection
            conn.Close();
            //start.Disconnect();
            // return the Emp OBJ
            return findEmpEmail;
        }
        public void Update(Employee NewEmp, int ID)
        {
            Employee update = FindByID(ID);

            //MAKE SURE SPELLING IS CORRECT within ""
            //STEP 2: Create, setup and open Connection object
            conn = new SqlConnection();
            //Setup
            conn.ConnectionString = @"Data Source=.;Initial Catalog=ETS_Database_1.0;Integrated Security=True";
            //open
            conn.Open();
            //start.Connect();
            // STEP 3: Create Command Obj
            SqlCommand cmd = new SqlCommand("sp_Update_Employee", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@EmpID", ID)); // use ARRGUMENT 

            cmd.Parameters.Add(new SqlParameter("@FName", NewEmp.FName));
            cmd.Parameters.Add(new SqlParameter("@LName", NewEmp.LName));
            cmd.Parameters.Add(new SqlParameter("@Email", NewEmp.Email));
            cmd.Parameters.Add(new SqlParameter("@DOB", NewEmp.DOB));
            cmd.Parameters.Add(new SqlParameter("@Phone", NewEmp.Phone));


            // STEP 4: Execure the Cmd
            cmd.ExecuteNonQuery();

            // STEP 5: Handle Results


            // STEP 6: Close Connection

            conn.Close();
            //start.Disconnect();
        }
        public List<Employee> SelectListDetails() //find by Emp obj method
        {
            List<Employee> EmpList = new List<Employee>();
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
            SqlCommand cmd = new SqlCommand("sp_Select_Employees", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            
            // STEP 4: Execure the Cmd
            SqlDataReader read = cmd.ExecuteReader();

            // STEP 5: Handle Results
       
            while (read.Read())
            {
                Employee AllEmp = new Employee();
                AllEmp.EmpID = Convert.ToInt32(read["EmpID"]);
                AllEmp.FName = Convert.ToString(read["FirstName"]);
                AllEmp.LName = Convert.ToString(read["LastName"]);
                AllEmp.Email = Convert.ToString(read["Email"]);
                

                EmpList.Add(AllEmp);
            }

            // STEP 6: Close Connection
            conn.Close();
            //start.Disconnect();
            // return the Emp OBJ
            return EmpList;
        }

        public List<EmpHour> SelectAll()
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
            SqlCommand cmd = new SqlCommand("sp_AllEmp_Summary", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // STEP 4: Execure the Cmd
            SqlDataReader read = cmd.ExecuteReader();

            // STEP 5: Handle Results

            while (read.Read())
            {
                Employee emp = new Employee();
                emp.FName = Convert.ToString(read["FirstName"]);
                emp.LName = Convert.ToString(read["LastName"]);
                emp.Email = Convert.ToString(read["Email"]);
                emp.DOB = Convert.ToDateTime(read["DOB"]);
                emp.Phone = Convert.ToString(read["Phone"]);
                int EmpID = Convert.ToInt32(read["EmpID"]);
                DateTime WorkDate = Convert.ToDateTime(read["WorkDate"]);
                int Hours = Convert.ToInt32(read["Hours"]);
                EmpHour AllEmp = new EmpHour(EmpID,  WorkDate, Hours);
                
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
