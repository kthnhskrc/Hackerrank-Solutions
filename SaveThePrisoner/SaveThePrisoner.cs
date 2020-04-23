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

class SaveThePrisoner
{

    // Complete the saveThePrisoner function below.
    static int saveThePrisoner(int prisoner, int sweet, int chair)
    {

        int result = 0;

        int rem = sweet % prisoner;

        if (rem == 0)
        {
            if (chair == 1)
            {
                return prisoner;
            }
            else
            {
                return chair - 1;
            }
        }

        result = rem + chair - 1;

        if (result > prisoner)
        {
            result -= prisoner;
        }

        return result;
    }

    static void Main(string[] args)
    {

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] nms = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nms[0]);

            int m = Convert.ToInt32(nms[1]);

            int s = Convert.ToInt32(nms[2]);

            int result = saveThePrisoner(n, m, s);

            Console.WriteLine(result);

            Console.ReadKey();
        }

    }
}
