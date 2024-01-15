using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class CaeserCipher
    {
        public static string CaesarCypherEncryptor(string str, int key)
        {
            // Write your code here.
            string newstr = "";
            
            foreach (char c in str)
            {
                var ch = (char)('a' + (c - 'a' + key)%26);

                newstr += ch;
            }

            
            return newstr;
        }
    }
}
