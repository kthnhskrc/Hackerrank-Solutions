using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeMessage
{
    class DecodeMessage
    {
        static List<string> calculate(string data)
        {
            Dictionary<int, char> letters = new Dictionary<int, char>();
            List<string> resultSet = new List<string>();

            int j = 0;
            string word = "";
            char result = ' ';

            //adding all letters to dictionary
            for (char i = 'A'; i <= 'Z'; i++)
            {
                j++;
                letters.Add(j, i);
            }

            //controls a data is valid or invalid and checks a value
            if (letters.ContainsKey(Convert.ToInt32(data)))
            {
                result = letters[Convert.ToInt32(data)];
                resultSet.Add(Convert.ToString(result));
            }

            //controls all elements of data as a key for find a value one by one.
            for (int i = 0; i < data.Length; i++)
            {
                if (letters.ContainsKey(Convert.ToInt32(Convert.ToString(data[i]))))
                {
                    word += letters[i + 1];
                }
                else
                {
                    return null;
                }
            }

            //add a word to arraylist
            resultSet.Add(word);

            return resultSet;
        }


        static void Main(string[] args)
        {
            List<string> arrItems = new List<string>();

            string data = "12";

            arrItems = calculate(data);

            //printing elements in result
            foreach (var item in arrItems)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}
