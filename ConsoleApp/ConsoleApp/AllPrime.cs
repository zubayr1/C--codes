using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class AllPrime
    {
        public static List<int> WriteAllPrime(int end)
        {

            List<int> prime = new List<int>();


            for(int i=2; i<end; i++)
            {
                int count = 0;
                for(int j=2; j<=i/2; j++)
                {
                    if (i%j == 0)
                    {
                        count += 1;
                    }
                }

                if(count==0)
                {
                    prime.Add(i);
                }
                count = 0;
            }

            return prime;
        }
    }
}
