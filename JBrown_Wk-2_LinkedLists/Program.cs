/* CSC382 - Data Structures & Algorithms
 * 18 MAY, 2015 - Week 2
 * Jason Brown
 * 
 * Linked List
 * 
 * Implementation
 * Implement a templated doubly-linked list in C++.  Your linked list class should implement the following functionality:
 * 
 * Find(dataToFind) – returns a pointer to the node whose key matches dataToFind.
 * Insert(newData) – inserts a new node at the end of the list with a key equal to newData
 * Delete(delNode)- deletes the node that delNode points to from the list.
 * Minimum() – returns the minimum key in the list
 * Maximum() –returns the maximum key in the list
 * 
 * Your main program should instantiate, initialize and correctly demonstrate the functionality of the linked list.
 * 
 * Lab Report
 * In Word or a similar word processing program, write a Lab Report including the following sections:
 * Introduction – in your own words, describe the structure and operations of linked lists.
 * Programmer’s Guide  – Provide detailed documentation describing your implementation of linked lists. Describe the structure of the list class (class diagrams are awesome), and describe the meaning and operation of each of its member variables and methods. For each member function, give a usage example.
 * 
 * Submission
 * Submit a *.zip file containing your lab report and code project folder to the drop-box associated with this assignment.  Name the *.zip file with your Last Name, and the week.  For example, my submission file would be:
 * 
 * GordonWeek2.zip
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList_JBrown
{
    class Program
    {
        static void Main(string[] args)
        {
            int numNodes = 10;
            int itemToRemove = 0;
            Random randNum = new Random();
            List<int> myList = new List<int>();

            for (int count = 0; count < numNodes; count++)
            {
                myList.Add(randNum.Next(1, 100));
            }

            Console.WriteLine("******************");

            var s1 = Stopwatch.StartNew();

            myList.Sort();
            foreach (var item in myList)
            {
                Console.WriteLine(" Item Value: {0}", item);
            }
            s1.Stop();


            Console.WriteLine("******************");
            Console.WriteLine("> First element is: {0}", myList.ElementAt(0));
            Console.WriteLine("******************");

            itemToRemove = myList.ElementAt(0);
            myList.Remove(itemToRemove);
            Console.WriteLine("******************");
            Console.WriteLine("> First element is NOW: {0}", myList.ElementAt(0));
            Console.WriteLine("******************");

            Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) / numNodes).ToString("0.00 ns"));
            
            Console.WriteLine("******************");
            Console.WriteLine("> Sorted list: ");

            foreach (var item in myList)
            {
                Console.WriteLine(" Item Value: {0}", item);
            }
            Console.WriteLine("******************"); 

            Console.WriteLine("******************");
            Console.WriteLine("> Max element is: {0}", myList.Max());
            Console.WriteLine("******************");

            Console.WriteLine("******************");
            Console.WriteLine("> Min element is: {0}", myList.Min());
            Console.WriteLine("******************"); 
        }
    }
}


