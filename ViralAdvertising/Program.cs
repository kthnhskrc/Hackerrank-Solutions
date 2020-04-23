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

    // Complete the viralAdvertising function below.
    static int viralAdvertising(int n)
    {
        int sum = 0, start = 5, result = 0;

        for (int i = 0; i < n; i++)
        {
            sum = (start / 2);
            result += sum;
            sum *= 3;
            start = sum;
        }

        return result;
    }

    static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine());

        int result = viralAdvertising(n);

        Console.WriteLine(result);

        Console.ReadKey();
    }
}
