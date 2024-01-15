using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class SmallestDiff
    {
        public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
        {
            // Write your code here.
            
            if(arrayOne.Length ==0 || arrayTwo.Length==0)
            {
                return new int[] { };
            }

            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);

            

            int[] finaalarr = new int[2];

            int minsum = 99999;

            foreach (int i in arrayOne)
            {
                int tempmin = 9999;
                foreach (int j in arrayTwo)
                {
                    int sum = Math.Abs(i - j);

                    if (sum < tempmin)
                    {
                        tempmin = sum;

                        if(tempmin < minsum)
                        {
                            minsum = tempmin;

                            finaalarr[0] = i;
                            finaalarr[1] = j;
                        }
                                                
                        
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return finaalarr;
        }
    }
}
