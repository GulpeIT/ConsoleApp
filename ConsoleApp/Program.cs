using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Find_Missing_Value f = new Find_Missing_Value();

            Console.WriteLine(f.FindMissing(new List<int> { 1, 3, 5, 9}));
        }
    }
}