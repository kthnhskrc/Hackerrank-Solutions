using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubSets
{
    class Program
    {
        static List<int> subsets(int[] s, int target)
        {
            List<List<int>> mainList = new List<List<int>>();
            List<int> tempList = new List<int>();
            int total = 0;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    total = s[i] + s[j];
                    if(!(total > target))
                    {
                        if(total == target)
                        {
                            tempList.Add(s[i]);
                            tempList.Add(s[j]);
                            mainList.Add(tempList);
                        }
                        else if(total > target)
                        {

                        }
                    }
                }
            }

            return mainList;
        }


        static void Main(string[] args)
        {
            List<int> elements = new List<int>();
            int[] s = { 2, 4, 6, 10 };

            elements = subsets(s,16);

            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
