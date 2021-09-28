using System;

namespace LinkedListsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running the program does nothing!");

            MyLinkedList myList = new MyLinkedList();

            myList.AddAtHead(1);
            myList.AddAtTail(3);
            myList.AddAtIndex(1, 2);
            Console.WriteLine("Current List: ");
            myList.displayList();
            Console.WriteLine("Return item: " + myList.Get(1));


            myList.AddAtHead(40);
            myList.AddAtHead(30);
            myList.AddAtHead(20);
            myList.displayList();

            Console.WriteLine("Add 100 to the Tail");
            myList.AddAtTail(50);
            myList.displayList();

            Console.WriteLine("Add 1 to the Head");
            myList.AddAtHead(10);
            myList.displayList();

            Console.WriteLine("Grabbing Index Value: " + myList.Get(2));
            Console.WriteLine();
            
            myList.DeleteAtIndex(5);
            Console.WriteLine("Deleting xTh Item - New List ");
            myList.displayList();

        }
    }
}
