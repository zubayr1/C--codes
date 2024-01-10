using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class NthFib
    {
        public static int retNthFib(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return retNthFib(n - 1) + retNthFib(n - 2);
        }
        public static int GetNthFib(int n)
        {
            // Write your code here.
            n = n - 1;

            return retNthFib(n);


        }
    }
}
