using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ProductSum
    {
        // Tip: You can use `el is IList<object>` to check whether an item is a list
        // or an integer.

       

        public static int ProductS(List<object> array, int depth=1)
        {
            int sum = 0;
            
            foreach (object item in array)
            {
                if (item is int)
                {
                    sum += (int)item;
                }
                else
                {
                    sum += ProductS((List<object>)item, depth + 1);
                }
            }

            return sum*depth;
        }
    }
}
