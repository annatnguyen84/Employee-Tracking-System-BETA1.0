using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.Entity
{
    public class Employee 
    {
        // Fields & Properties
        public int EmpID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        // Null Cons
        public Employee()
        {

        }
        public Employee(int EmpID)
        {
            this.EmpID = EmpID;
        }
        public Employee(int EmpID, string FName, string LName)
        {
            this.EmpID = EmpID;
            this.FName = FName;
            this.LName = LName;
            this.Email = Email;
            this.DOB = DOB;
            this.Phone = Phone;
           
        }

        //Methods
        public string FullName()
        { 
            return $"{FName} {LName}";
        }
        
        public override bool Equals(object obj)
        {

            return this.FullName().Equals(((Employee)obj).FullName());

        }
        public int CompareTo(Employee emp)
        {
            return this.FullName().CompareTo(emp.FullName());
        }
    }
}
