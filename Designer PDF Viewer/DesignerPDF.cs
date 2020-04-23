using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPDFViewer
{
    class DesignerPDF
    {
        static int designerPdfViewer(int[] h, string word)
        {
            List<char> letters = new List<char>();
            int biggest = 0, result = 0;

            for (char i = 'a'; i <= 'z'; i++)
            {
                letters.Add(i);
            }

            for (int j = 0; j < word.Length; j++)
            {
                for (int k = 0; k < letters.Count; k++)
                {
                    if (word[j] == letters[k])
                    {
                        biggest = h[k];
                        if (biggest > result)
                        {
                            result = biggest;
                            break;
                        }
                        else { break; }
                    }
                }
            }

            return result * word.Length;
        }

        static void Main(string[] args)
        {

            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
            ;
            string word = Console.ReadLine();

            int result = designerPdfViewer(h, word);

            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}
