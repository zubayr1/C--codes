using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ValidateSubsq
    {
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            // Write your code here.
            if(array == null || array.Count< sequence.Count )
            {
                return false;
            }

            int count = -1;

            bool found = false;

            foreach( int val in sequence)
            {
                found = false;
                for (int i=count+1; i<array.Count; i++)
                {
                    if (array[i] == val )
                    {
                        count = i;
                        found = true;
                        break;
                    }
                    
                }

                if(!found)
                {
                    return false;
                }
                

            }

            return true;
        }
    }
}
