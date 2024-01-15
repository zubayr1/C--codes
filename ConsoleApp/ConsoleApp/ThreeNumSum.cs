using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ThreeNumSum
    {
        public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
        {
            // Write your code here.
            Array.Sort(array);

            
            List<int[]> finallis = new List<int[]>();

            if(array.Length < 2) { return new List<int[]>(); }


            for(int cs=0; cs<array.Length-2; cs++)
            {
                var l = cs+1;
                var r = array.Length - 1;

                while(l<r)
                {
                    if (array[l] + array[cs] + array[r] == targetSum)
                    {
                        int[] arr = { array[cs], array[l], array[r] };

                        finallis.Add(arr);

                        l += 1;

                        r -= 1;
                                                
                    }
                    else if (array[l] + array[cs] + array[r] > targetSum)
                    {
                        r -= 1;                      
                    }
                    else
                    {
                        l += 1;
                    }
                }


            }

          

            return finallis;
        }
    }
}
