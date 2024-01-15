using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{

    class Node
    {
        public int data;
        public Node next;
        public Node(int data) 
        {
            this.data = data;
            next = null;
        }
    }

    public class LinkedList
    {
        private Node head;
        private Node p;

        public LinkedList()
        {
            head = null;
            p = head;
        }
        public void addNode(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                p = head;
            }
            else
            {
                p.next = newNode;
                p = newNode;
            }
        }

        public int removeNode(int position)
        {
            Node q = head;
            int index = 0;

            if(position == 0)
            {
                head = q.next;

                q.next = null;

                return q.data;
            }

            while(index< position - 1 && q.next != null)
            {
                
                q = q.next;
                
                index += 1;
                
            }
            Node r = q.next;
            q.next = r.next;
            r.next = null;

            return q.data;
        }


        public LinkedList removeDuplicated()
        {
            if (head==null || head.next == null)
            {
                return head;
            }
        }

        public void displayList()
        {
            Node q = head;

            while (q!= null)
            {
                Console.WriteLine(q.data);
                q = q.next;
                                
            }
        }


    }
}
