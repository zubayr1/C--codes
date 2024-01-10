using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class NonConsChang
    {
        public int NonConstructibleChange(int[] coins)
        {
            // Write your code here.

            if(coins.Length == 0) return 1;
                       

            Array.Sort(coins);

            if (coins[0]>1)
            {
                return 1;
            }

            int prevsum = coins[0];
            for (int i = 1; i<coins.Length; i++)
            {
                if (coins[i] > prevsum+1)
                {
                    return prevsum + 1;
                }
                prevsum += coins[i];
            }
            return prevsum + 1;
        }

    }
}
