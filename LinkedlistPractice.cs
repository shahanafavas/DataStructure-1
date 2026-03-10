using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_1
{
   public  class LinkedlistPractice
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }
        }
        public Node head = null;
        public Node tail = null;

        public void addNode(int data)
        {
            Node newnode = new Node(data);
          if(head==null)
            {
                head = newnode;
                
            }
            else
            {
                tail.next = newnode;
            }
            tail = newnode;
        }
        public void disply()
        {
            Node temp = head;
            
            while(temp!=null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        public void insertAtBegning(int data)
        {
            Node newnode = new Node(data);
            if(head==null)
            {
                head = newnode;
                tail = newnode;
            }
            else
            {
                newnode.next = head;
                head = newnode;
            }
        }
        public void insertAtEnd(int data)
        {
            Node newnode = new Node(data);
            tail.next = newnode;
            tail = newnode;
        }

        public void deletenode(int data)
        {
            Node temp = head, prev = null;

            if(temp!=null && temp.data==data)
            {
                head = temp.next;
                return;
            }
            while(temp!=null && temp.data!=data)
            {
                prev = temp;
                temp = temp.next;
            }
            if(temp==null)
            {
                return;
            }
            prev.next = temp.next;
        }

        public void Insertatspecific(int data, int position)
        {
            Node newnode = new Node(data);
            if(position==1)
            {
                newnode.next = head;
                head = newnode;
                if(tail==null)
                {
                    tail = newnode;
                }
                return;
            }
            Node temp = head;
            for(int i=1;i<position-1;i++)
            {
                if (temp == null)
                {
                    Console.WriteLine("Position out of range");
                    return;
                }
                temp = temp.next;
            }
            newnode.next = temp.next;
            temp.next = newnode;

            if(newnode.next==null)
            {
                tail = newnode;
            }
        }
        public void kthelement(int k)
        {
            int count = 0;
            Node temp = head;
            if(temp!=null)
            {
                count++;
                temp = temp.next;
            }
            int position = count - k + 1;

            temp = head;
            for(int i=1;i<position;i++)
            {
                temp = temp.next;
            }
            Console.WriteLine(temp.data);
        }

        public void findmiddle()
        {
            Node slow = head;
            Node fast = head;
            while(fast!=null && fast.next!=null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            Console.WriteLine(slow.data);
        }
    }
}
