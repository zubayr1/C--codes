using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public abstract class AbsClass
    {
        public abstract string Name { get; set; }

        public abstract int returnVal();
        
        public void logclass()
        {
            Console.WriteLine("abstract class");
        }


    }
}
