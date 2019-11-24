using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.Logic
{
    public class RegularExpression
    {
        public static bool EmailValidation(string Email)
        {
            bool result = true;
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!rEmail.IsMatch(Email))
            {
                result = false;
            }
            return result;
        }

        public static bool PhoneValidation(string Phone)
        {
            bool result = true;
            System.Text.RegularExpressions.Regex rPhone = new System.Text.RegularExpressions.Regex(@"^(((\(\d{2}\) ?)|(\d{2}-))?\d{4}-\d{4}$)|((\d{2})\d{8}$)|(\d{4} \d{3} \d{3}$)");
            if (!rPhone.IsMatch(Phone))
            {
                result = false;
            }
            return result;
        }


    }
}
