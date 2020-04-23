using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    class Program
    {
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double result = 0, result2 = 0, result3 = 0;
            result = meal_cost;
            result2 = Convert.ToDouble(meal_cost % tip_percent);
            result3 = Convert.ToDouble(meal_cost % tax_percent);
        }
        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);
        }
    }
}
