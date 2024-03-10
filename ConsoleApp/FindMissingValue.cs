using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


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

Операция с 4
int temp = |1 - 5| (4)

1 + 4 ?= 5 | true;
5 + 4 ?= 7 | false;

Операция с 2
int temp = |5 - 7| (2)

1 + 2 ?= 3 | false;
5 + 2 ?= 7 | true;


*/

namespace ConsoleApp
{
    internal class FindMissingValue
    {
        public int FindMissing(List<int> list)
        {
            int difference = 0;
            int definition = 0;


            for (int i = 0; i < list.ToArray().Length - 1; i++)
            {
                difference = list[i + 1] - list[i];


            }

            return 0;
        }
    }
}
