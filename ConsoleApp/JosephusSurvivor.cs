using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    //  n  
    // [1, 2, 3, 4, 5, 6, 7] 
    // k = step
    // первый круг 
    // k = 3 
    // второй круг
    // k = 6
    // третий круг
    // k = 9


    internal class JosephusSurvivor
    {
        public int JosSurvivor(int n, int k)
        {
            int step = 0;

            // Creating a sequential list
            List<int> circle = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                circle.Add(i);
            }

            while (circle.Count > 1)
            {
                step += k;
                while (step > circle.Count)
                {
                    step -= circle.Count;
                }
                step--;
                circle.RemoveAt(step);
            }

            return circle[0];
        }
    }
}
