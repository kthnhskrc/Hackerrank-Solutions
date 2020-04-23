using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickingNumbers
{
    class PickingNumbers
    {
        static int pickingNumbers(List<int> a)
        {
            //4 6 5 3 3 1
            int counter = 1, minusCounter = 1, result = 0;
            for (int i = 0; i < a.Count; i++)
            {
                counter = 1;
                minusCounter = 1;
                for (var j = i + 1; j < a.Count; j++)
                {
                    if (a[i] - a[j] == 1)
                    {
                        counter++;
                    }
                    else if (a[i] - a[j] == -1)
                    {
                        minusCounter++;
                    }
                    else if (a[i] - a[j] == 0)
                    {
                        counter++;
                        minusCounter++;
                    }

                }

                if (counter > minusCounter)
                {
                    if (counter > result)
                    {
                        result = counter;
                    }
                }
                else if (minusCounter > counter)
                {
                    if (minusCounter > result)
                    {
                        result = minusCounter;
                    }
                }
                else if (minusCounter == counter)
                {
                    if (minusCounter > result)
                    {
                        result = minusCounter;
                    }
                }
            }

            return result;
        }
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = pickingNumbers(a);

            Console.WriteLine(result);

            Console.ReadKey();
        }

    }
}

