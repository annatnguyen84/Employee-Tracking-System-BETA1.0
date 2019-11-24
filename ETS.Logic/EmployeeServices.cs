using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ETS.Entity;
using ETS.Data;

namespace ETS.Logic
{
   
    public class EmployeeServices
    {
        // Filed: create empDataAccess obj
        private EmployeeDataAccess dao;


        // Prop

        // Cons
        public EmployeeServices()
        {
            dao = new EmployeeDataAccess();
        }
        // Method to provide that emp has been added 
        public Status SavedEmp(Employee emp)
        {
            Status result = Status.Successfull;
            try
            {
                dao.Insert(emp);
            }
            catch 
            {
                result = Status.Unsuccessfull;
            }
            
            return result;
        }

        

        public StatusData<List<Employee>> ListDetails()
        {

            StatusData<List<Employee>> result = new StatusData<List<Employee>>();
            try
            {
                result.Data = dao.SelectListDetails();
                result.StatusResult = Status.Successfull;
               
            }
            catch 
            {
                result.StatusResult = Status.Unsuccessfull;
            }
            return result;
        }

        public StatusData<Employee> FindEmp(int ID)
        {
            StatusData<Employee> result = new StatusData<Employee>();
            try
            {
                result.Data = dao.FindByID(ID);
                result.StatusResult = Status.Successfull;
            }
            catch 
            {
                result.StatusResult = Status.Unsuccessfull;
            }
            return result;
        }
        public int GetEmpID()
        {
            int Found = 0;
            try
            {
                Found = dao.GetEmpID();
            }
            catch
            {

            }
            return Found;
        }
       
        public StatusData<Employee> FindEmailEmp(string Email)
        {
            StatusData<Employee> result = new StatusData<Employee>();
            try
            {
                result.Data = dao.FindByEmail(Email);
                result.StatusResult = Status.Successfull;
            }
            catch
            {
                result.StatusResult = Status.Unsuccessfull;
            }
            return result;
        }


        public Status UpdatedEmp(Employee EmpUpdate, int ID)
        {
            Employee OldEmp =  dao.FindByID(ID);
            Status result = Status.Successfull;
            try
            {
                if (OldEmp != null && OldEmp.EmpID == ID)
                {
                    dao.Update(EmpUpdate, ID);
                }
            }
            catch 
            {
                result = Status.Unsuccessfull;
            }
            
            return result;
        }

    }
}
