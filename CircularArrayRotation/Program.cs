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

class Solution
{
    // Complete the circularArrayRotation function below.
    static int[] circularArrayRotation(int[] a, int k, int[] queries)
    {
        int temp = 0;
        k = (k % a.Length);
        int[] arrItems = new int[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            arrItems[((i + k) % a.Length)] = a[i];
        }

        for (int j = 0; j < queries.Length; j++)
        {
            temp = arrItems[queries[j]];
            queries[j] = temp;
        }

        return queries;
    }

    static void Main(string[] args)
    {

        string[] nkq = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nkq[0]);

        int k = Convert.ToInt32(nkq[1]);

        int q = Convert.ToInt32(nkq[2]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;

        int[] queries = new int[q];

        for (int i = 0; i < q; i++)
        {
            int queriesItem = Convert.ToInt32(Console.ReadLine());
            queries[i] = queriesItem;
        }

        int[] result = circularArrayRotation(a, k, queries);

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }
}
