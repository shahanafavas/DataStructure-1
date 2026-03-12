using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_1
{
   public  class DoubleLinkedList
    {
        public class Node
        {
           public int data ;
           public Node next;
            public Node prev;

            public Node(int data)
            {
                this.data = data;
            }
        }
        public Node head ;
        public Node tail ;

        public void Addnode(int data)
        {
            Node newnode = new Node(data);
            if(head==null)
            {
                head = newnode;
            }
            else
            {
                tail.next = newnode;
                newnode.prev = tail;
            }
            tail = newnode;
        }
        public void display()
        {
            Node temp = head;
            while(temp!=null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        public void displayReverse()
        {
            Console.WriteLine("reverse:");
            Node temp = tail;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.prev;
            }
        }
        public void delete(int data)
        {
            Node temp = head;
            if(temp!=null && temp.data==data)
            {
              
                
                    head = temp.next;
                    head.prev = null;
               
            }
            while(temp!=null&& temp.data!=data)
            {
                temp = temp.next;
            }
            if(temp.prev!=null)
            {
                temp.prev.next = temp.next;
            }
           if(temp.next!=null)
            {
                temp.next.prev = temp.prev;
            }
        }

        public void Findmiddle()
        {
            Node slow = head;
            Node fast = head;

            while(fast!=null && fast.next!=null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            Console.WriteLine("middle element is:"+slow.data);
        }
    }
}
