using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ValidPhoneNumber
    {
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length >= 15) return false;
            Regex r = new Regex(@"\(\d{3}\)\s\d{3}-\d{4}");
            return r.IsMatch(phoneNumber) ? true : false;
        }
    }
}
