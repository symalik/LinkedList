using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    public class MyLinkedList
    {
        public ListNode Head { get; set; }


        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            

        }
            

        /** Get the val of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            ListNode current = Head;

            if (Head == null)
            {
                return -1;
            }
  
            int counter = 0;
            do
            {
                if (counter == index)
                {
                    return (current.val);
                }

                current = current.next;
                counter++;

            } while (current != null);

            return -1;
        }

        /** Add a node of val val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            ListNode newNode = new ListNode();
            newNode.val = val;
            newNode.next = Head;
            Head = newNode;

        }

        /** Append a node of val val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            if (Head == null)
            {
                Head = new ListNode();
                return;
            }
            ListNode current = Head;
            while (current.next != null)
            {
                current = current.next;
            }

            ListNode newNode = new ListNode();
            newNode.val = val;
            current.next = newNode;
        }

        /** Add a node of val val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
         {
            ListNode newNode = new ListNode();
            newNode.val = val;

            if (Head == null)
            {
                Head = newNode;
                newNode.val = val;
                return;
            }

            ListNode current = Head;
            int counter = 0;

            while (current != null)
            {
                if (counter == 0) //Handle when index = 0;
                {
                    Head = newNode;
                    newNode.next = current;
                }
                if (counter == index - 1)
                {
                    
                    newNode.next = current.next;
                    current.next = newNode;
                    //return;
                }

                counter++;
                current = current.next;
            }
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            int counter = 0;
            if (Head == null) return; //If List is empty then return
            if (counter == index) //If the data we want to delete is at the Head
            {
                Head = Head.next;
                return;
            }

            ListNode current = Head;
            ListNode previous = null;
            while (current.next != null)
            {
                if (counter == index)
                {
                    //current.next = current.next.next;
                    previous.next = current.next;
                    return;
                }
                counter++;
                previous = current;
                current = current.next;
            }

            previous.next = null; //remove last node

        }



        //Displaying for Test purpose do not need to add to LeetCode
        public void displayList()
        {
            Console.WriteLine("List (first -- last) ");
            ListNode current = Head;
            while (current != null)
            {
                Console.WriteLine("<" + current.val + ">");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
