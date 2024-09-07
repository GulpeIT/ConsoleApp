using System.Data.Common;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            JosephusSurvivor js = new JosephusSurvivor();

            Console.WriteLine(js.JosSurvivor(7, 3));
            Console.Read();
        }
    }
}