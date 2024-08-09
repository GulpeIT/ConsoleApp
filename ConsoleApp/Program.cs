using System.Globalization;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {


            ValidPhoneNumber phone = new ValidPhoneNumber();
            Console.WriteLine(phone.IsValidPhoneNumber("(123) 456-7890"));
        }
    }
}