using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace BeautifulDaysAtTheMovies
{


    class Solution
    {
        // Complete the beautifulDays function below.
        static int beautifulDays(int i, int j, int k)
        {
            decimal temp = 0;
            int counter = 0, reverseT = 0, reverse = 0, rem = 0;

            for (int t = i; t <= j; t++)
            {
                temp = t;
                reverseT = t;
                //Reverse loop
                while (reverseT != 0)
                {
                    rem = reverseT % 10;
                    reverse = reverse * 10 + rem;
                    reverseT /= 10;
                }

                temp = Math.Abs(temp - reverse) / k;

                if (!(temp % 1 > 0))
                {
                    counter++;
                }

                reverse = 0;
            }

            return counter;
        }

        static void Main(string[] args)
        {

            string[] ijk = Console.ReadLine().Split(' ');

            int i = Convert.ToInt32(ijk[0]);

            int j = Convert.ToInt32(ijk[1]);

            int k = Convert.ToInt32(ijk[2]);

            int result = beautifulDays(i, j, k);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }

}
