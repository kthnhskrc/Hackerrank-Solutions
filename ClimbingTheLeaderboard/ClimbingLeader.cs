using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimbingTheLeaderboard
{
    class ClimbingLeader
    {
        // Complete the climbingLeaderboard function below.
        static int[] climbingLeaderboard(int[] scores, int[] alice)
        {
            int counter = 1, temp = 0;
            temp = scores[0];
            int[] final = { };
            List<int> leaderBoard = new List<int>();
            List<int> aliceList = new List<int>();
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == temp)
                {
                    leaderBoard.Add(counter);
                }
                else if (scores[i] < temp)
                {
                    counter++;
                    leaderBoard.Add(counter);
                    temp = scores[i];
                }
            }

            for (int j = 0; j < alice.Length; j++)
            {
                for (int k = 0; k < scores.Length; k++)
                {
                    if (alice[j] >= scores[k])
                    {
                        aliceList.Add(leaderBoard[k]);
                        break;
                    }
                }
                if (aliceList.Count == 0)
                {
                    aliceList.Add(leaderBoard[leaderBoard.Count - 1] + 1);
                }
            }

            return final = aliceList.ToArray();
        }

        static void Main(string[] args)
        {

            int scoresCount = 7;       /* Convert.ToInt32(Console.ReadLine());*/

            int[] scores = { 100, 100, 50, 40, 40, 20, 10 };   /*Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))*/

            int aliceCount = 4; /*Convert.ToInt32(Console.ReadLine());*/

            int[] alice = { 5, 25, 50, 120 };/*Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp))*/

            int[] result = climbingLeaderboard(scores, alice);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
