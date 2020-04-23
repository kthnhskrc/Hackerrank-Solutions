using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparetheTriplets
{
    class Triplets
    {
        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            //return array
            List<int> list = new List<int>();
            int x = 0, y = 0;

            for (int i = 0; i < a.size(); i++)
            {
                if (a.get(i) > b.get(i))
                {
                    x++;
                }
                else if (a.get(i) < b.get(i))
                {
                    y++;
                }

            }

            list.add(x);
            list.add(y);
            return list;
        }

        public static void main(String[] args) throws IOException
        {
            BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String[] aItems = bufferedReader.readLine().replaceAll("\\s+$", "").split(" ");

        List<int> a = new List<int>();

        for (int i = 0; i< 3; i++) {
            int aItem = int.parseInt(aItems[i]);
        a.add(aItem);
        }

    String[] bItems = bufferedReader.readLine().replaceAll("\\s+$", "").split(" ");

    List<int> b = new List<>();

        for (int i = 0; i< 3; i++) {
            int bItem = int.parseInt(bItems[i]);
    b.add(bItem);
        }

List<int> result = compareTriplets(a, b);

        for (int i = 0; i<result.size(); i++) {
            bufferedWriter.write(String.valueOf(result.get(i)));

            if (i != result.size() - 1) {
                bufferedWriter.write(" ");
            }
        }

        bufferedWriter.newLine();

        bufferedReader.close();
        bufferedWriter.close();
    }
    }

