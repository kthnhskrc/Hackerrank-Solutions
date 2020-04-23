using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            int temp = 0;
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            for (int i = 0; i < n; i++)
            {
                if (i >= (n - i))
                {
                    i = n;
                    break;
                }

                temp = arr[i];
                arr[i] = arr[(n - 1) - i];
                arr[(n - 1) - i] = temp;
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
