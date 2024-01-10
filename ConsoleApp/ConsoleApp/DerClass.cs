using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class DerClass: AbsClass
    {
        public override string Name { get; set; }

        public override int returnVal()
        {
            return 0;
        }
    }
}
