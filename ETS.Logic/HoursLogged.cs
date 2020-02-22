using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ETS.Entity;
using ETS.Data;

namespace ETS.Logic
{
   
    public class HoursLogged
    {
        // Field: create EmpHoursDataAccess Obj
        private EmpHoursDataAccess dao;

        // Props

        // Cons
        public HoursLogged()
        {
            dao = new EmpHoursDataAccess();
        }

        // Method to return Logged status
        public Status HrsLogged(EmpHour hrs)
        {
            Status result = Status.Successfull;
            try
            {
                dao.Insert(hrs);
            }
            catch
            {
                result = Status.Unsuccessfull;
            }
            return result;
        }

        public StatusData<List<EmpHour>> EmpHoursList()

        {
            StatusData<List<EmpHour>> result = new StatusData<List<EmpHour>>();
            try
            {
                result.Data = dao.EmpHours();
                result.StatusResult = Status.Successfull;            
            }
            catch 
            {
                result.StatusResult = Status.Unsuccessfull;
            }
            return result;

        }
        public StatusData<List<EmpHour>> EmpIDHours(int ID)
        {
            StatusData<List<EmpHour>> result = new StatusData<List<EmpHour>>();
            try
            {
                result.Data = dao.EmpIDHours(ID);
                result.StatusResult = Status.Successfull;               
            }
            catch
            {
                result.StatusResult = Status.Unsuccessfull;
            }
            return result;
        }
    }
}
