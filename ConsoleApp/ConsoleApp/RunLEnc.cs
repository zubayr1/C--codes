using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class RunLEnc
    {
        public string RunLengthEncoding(string str)
        {
            // Write your code here.
            int count = 0;
            char curr = str[0];

            string finalstr = "";

            str =str.Substring(1);
                        

            foreach (char c in str)
            {
                if (c != curr)
                {                    
                    count++;
                    

                    while(count>9)
                    {
                        count = count - 9;
                        string tempval = "9" + curr;
                        finalstr += tempval;
                    }


                    string val = count.ToString() + curr;
                    finalstr += val;
                    curr = c;
                    count = 0;
                }
                else
                {
                    count += 1;
                }
            }

            count++;
            while (count > 9)
            {
                count = count - 9;
                string tempval = "9" + curr;
                finalstr += tempval;
            }

            string val1 = count.ToString() + curr;
            finalstr += val1;

            return finalstr;
        }
    }
}
