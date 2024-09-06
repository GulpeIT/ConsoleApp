using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


// ✔️ Выполнено ✔️

/*
 An Arithmetic Progression is defined as one in which there is a constant difference between the consecutive terms of a given series of numbers.
You are provided with consecutive elements of an Arithmetic Progression.
There is however one hitch: exactly one term from the original series is missing from the set of numbers which have been given to you. 
The rest of the given series is the same as the original AP. Find the missing term.
You have to write a function that receives a list, list size will always be at least 3 numbers. The missing term will never be the first or last one.
*/

/*
Example
                                 2  2  4     2
                                0  1  2     3  4
Kata.FindMissing(new List<int> {1, 3, 5, x, 9, 11}) => 7


                                 4     2
                                0     1  2
Kata.FindMissing(new List<int> {1, x, 5, 7}) => 3
*/

namespace ConsoleApp
{
    internal class Find_Missing_Value
    {
        public int FindMissing(List<int> list)
        {
            for (int i = 0; i < list.Count;)
            {
                int difference = list[i + 1] - list[i]; // 5 - 1 = 4 | разница между первым и поледним членом
                
                i++;

                if (list[i] + difference != list[i + 1])
                {
                    return list[i - 1] + (list[i + 1] - list[i]);
                }
            }

            return 0;
        }
    }
}
