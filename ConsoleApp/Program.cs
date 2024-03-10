using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FindMissingValue f = new FindMissingValue();

            Console.WriteLine(f.FindMissing(new List<int> { 1, 5, 7 }));
        }
    }
}