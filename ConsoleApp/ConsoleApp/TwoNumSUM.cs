using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class TwoNumSUM
    {
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            // Write your code here.
            if(array == null || array.Length == 0)
            {
                return new int[0];
            }

            Array.Sort(array);

            int l = 0;
            int r = array.Length - 1;

            while(l < r)
            {
                if (array[l] + array[r] == targetSum)
                {
                    return new int[] { array[l], array[r] };
                }
                if (array[l] + array[r] < targetSum)
                {
                    l += 1;
                }
                if (array[l] + array[r] > targetSum)
                {
                    r -= 1;
                }
            }

            return new int[0];
        }
    }
}
