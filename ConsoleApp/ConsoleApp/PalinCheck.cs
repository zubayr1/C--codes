using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class PalinCheck
    {
        public static bool IsPalindrome(string str)
        {
            // Write your code here.

            if (str.Length==0)
                return false;

            string newstr = "";
            
            for(int i=str.Length-1; i>=0; i--)
            {
                newstr += str[i];
            }

            if(newstr==str)
            {
                return true;
            }
            
            return false;
        }
    }
}
