using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class TournamentWinr
    {
        public string TournamentWinner(
            List<List<string>> competitions, List<int> results
          )
        {
            // Write your code here.
            Dictionary<string, int> leaderboard = new Dictionary<string, int>();

            int count = 0;
            foreach(List<string> comp in competitions)
            {
                if (results[count] ==0)
                {
                    if (leaderboard.ContainsKey(comp[1]))
                    {
                        leaderboard[comp[1]]++;
                    }
                    else 
                    { 
                        leaderboard[comp[1]]=1; 
                    }
                }
                if (results[count] == 1)
                {
                    if (leaderboard.ContainsKey(comp[0]))
                    {
                        leaderboard[comp[0]]++;
                    }
                    else
                    {
                        leaderboard[comp[0]] = 1;
                    }
                }
                count += 1;
            }

            
            int max = 0;

            string maxcompetetor = "";

            foreach(var key in leaderboard.Keys) 
            {
                if (leaderboard[key]>max)
                {
                    max = leaderboard[key];
                    maxcompetetor = key;
                }
            }

            return maxcompetetor;
        }
    }
}
