using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.LinkedList.SinglyLinkedList
{
    internal class LinkedListImplementation
    {
        private LinkedList linkedList = new LinkedList();

        public void PrintStatus()
        {
            Console.WriteLine("Singly Linked List Implementation");
            Console.WriteLine("Is it empty? " + linkedList.Empty);
            Console.WriteLine("Count: " + linkedList.Count);

            linkedList.Add("Test1");
            linkedList.Add("Test2");
            linkedList.Add(1, "Test3");

            linkedList.Remove(1);

            linkedList.Clear();


            // Add and check index
            linkedList.Add("Hello");
            bool containsHello = linkedList.Contains("Hello");
            Console.WriteLine("Contains Hello: " + containsHello);

            bool containsTest = linkedList.Contains("Test");
            Console.WriteLine("Contains Test: " + containsTest);

            linkedList.Get(2);

            object test2 = linkedList[2];
        }
    }
}
