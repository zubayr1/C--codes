using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class SortedSq
    {
        public static int[] SortedSquaredArray(int[] array)
        {
            // Write your code here.
            for(int i=0; i<array.Length; i++)
            {
                array[i] = array[i]* array[i];
            }
            Array.Sort(array);
            return array;
        }
    }
}
