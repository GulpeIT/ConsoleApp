using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// ✔️ Выполненно ✔️

namespace ConsoleApp
{
    

    public class Deadfish
    {
        public int[] Parse(string data)
        {
            int value = 0;
            List<int> values = new List<int>();

            for (int i = 0; i < data.Length; i++)
            {
                switch (data[i])
                {
                    case 'i':
                        value += 1;
                        break;

                    case 's':
                        value = (int)MathF.Pow(value, 2.0f);
                        break;

                    case 'd':
                        value -= 1;
                        break;

                    case 'o':
                        values.Add(value);
                        break;

                    default: break;
                }
            }
            return values.ToArray();
        }
        
    } 
}
