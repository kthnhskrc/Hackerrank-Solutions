using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRecurringCharacter
{
    class RecurringChar
    {
        static string findRecurring(string data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[i] == data[j])
                    {
                        return Convert.ToString(data[i]);
                    }
                }
            }

            return null;
        }

        static void Main(string[] args)
        {

            string data = "BCABA";
            Console.WriteLine(findRecurring(data));

            Console.ReadLine();
        }
    }
}
