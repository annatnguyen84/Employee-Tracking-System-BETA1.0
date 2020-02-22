using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.Entity
{
    public class EmpHour : Employee
    {
        // Fields & Prop
        
        public DateTime WorkDate { get; set; }
        public int HoursWorked { get; set; }

        // Null Cons
        public EmpHour()
        {

        }
        public EmpHour(int EmpID, DateTime WorkDate, int Hours) : base(EmpID)
        {
            this.WorkDate = WorkDate;
            this.HoursWorked = Hours;
        }
        public EmpHour(int EmpID, string FName, string LName, DateTime WorkDate, int Hours) : base(EmpID, FName, LName)
        {
            this.WorkDate = WorkDate;
            this.HoursWorked = Hours;
        }

        // Methods
    }
}
