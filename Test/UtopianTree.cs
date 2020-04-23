﻿using System.CodeDom.Compiler;
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

class UtopianTree
{

    // Complete the utopianTree function below.
    static int utopianTree(int n)
    {
        int height = 1;

        for (int i = 0; i < n; i++)
        {
            if (i % 2 != 0)
            {
                height++;
            }
            else
            {
                height *= 2;
            }
        }

        return height;
    }

    static void Main(string[] args)
    {

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = utopianTree(n);

            Console.WriteLine(result);

        }



        Console.ReadKey();
    }
}
