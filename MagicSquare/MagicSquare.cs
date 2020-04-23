using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicSquare
{
    class MagicSquare
    {
        static int formingMagicSquare(int[][] s)
        {
            int[] arrItems = {
             8,1,6,
             3,5,7,
             4,9,2,
             6,1,8,
             7,5,3,
             2,9,4,
             4,9,2,
             3,5,7,
             8,1,6,
             2,9,4,
             7,5,3,
             6,1,8,
             8,3,4,
             1,5,9,
             6,7,2,
             4,3,8,
             9,5,1,
             2,7,6,
             6,7,2,
             1,5,9,
             8,3,4,
             2,7,6,
             9,5,1,
             4,3,8
            };

            int counter = 1, temp = 0, value = 0;
            List<List<int>> magicSquares = new List<List<int>>();
            List<int> valueSet = new List<int>();
            List<int> row = new List<int>();

            for (int i = 0; i < arrItems.Length; i++)
            {
                row.Add(arrItems[i]);
                temp++;
                if (temp % 3 == 0)
                {
                    magicSquares.Add(row);
                    row = new List<int>();
                    temp = 0;
                    if ((i + 1) % 9 == 0)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                value += Math.Abs((magicSquares[j][k]) - (s[j][k]));
                            }
                        }
                        //create magicSquares list again
                        magicSquares = new List<List<int>>();
                        valueSet.Add(value);
                        value = 0;
                        counter++;
                    }
                }

            }

            return valueSet.Min();

        }


        static void Main(string[] args)
        {

            int[][] s = new int[3][];

            s[0] = new int[] { 4, 9, 2 };
            s[1] = new int[] { 3, 5, 7 };
            s[2] = new int[] { 8, 1, 5 };


            Console.WriteLine(formingMagicSquare(s));



            Console.ReadLine();
        }
    }
}
