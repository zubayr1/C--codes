using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            LinkedList linkedList = new LinkedList();
            linkedList.addNode(00);
            linkedList.addNode(10);
            linkedList.addNode(20);
            linkedList.addNode(30);
            linkedList.addNode(40);
            linkedList.addNode(50);
            linkedList.addNode(60);

            Console.WriteLine("Linked List elements:");
            linkedList.displayList();

            /*int removedinit = linkedList.removeNode(0);

            Console.WriteLine($"removed {removedinit}");*/

            /*int removed = linkedList.removeNode(5);

            Console.WriteLine($"removed {removed}");

            Console.WriteLine("Linked List elements:");
            linkedList.displayList();*/
        }


    }
    

}
