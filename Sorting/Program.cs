using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int temp = 0, swapNumber = 0;
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        // Write Your Code Here
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                    swapNumber++;
                }
            }

            if (swapNumber == 0)
            {
                break;
            }
        }

        foreach (var item in a)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Array is sorted in "+swapNumber+" swaps.\nFirst element: "+a[0]+"\nLast element: "+a[a.Length-1]);

        Console.ReadKey();
    }
}
