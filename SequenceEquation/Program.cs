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

    // Complete the permutationEquation function below.
    static int[] permutationEquation(int[] p)
    {
        int temp = 0;
        List<int> arr = new List<int>();

        for (int i = 0; i < p.Length; i++)
        {
            for (int j = i + 1; j < p.Length; j++)
            {
                if (p[j] == (i + 1))
                {
                    arr.Add(j);
                }
            }

        }

        return arr.ToArray();
    }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Convert.ToInt32(pTemp))
            ;
            int[] result = permutationEquation(p);

            textWriter.WriteLine(string.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
