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

using Aesthetics; // Custom class make console output more readable

namespace DblLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();
            int nodeContent = 0;
            int initNumNodes = 15; // Total nodes to generate randomly
            int ceilingNum = 100; // Maximum value for any given node

            SpacerClass s = new SpacerClass('+');

            MyLinkedList firstList = new MyLinkedList();

            for (int count = 0; count < initNumNodes; count++)
            {
                nodeContent = randNum.Next(1,ceilingNum);
                firstList.Insert(nodeContent);
            }

            Console.WriteLine("> Display the randomly generated nodes: ");
            firstList.DisplayNodes();
            s.showSpacer();

            Console.WriteLine("> Inserting the value '11' at the end: ");
            firstList.Insert("11");
            firstList.DisplayNodes();
            s.showSpacer();

            Console.WriteLine("> Inserting the value '99' at the end: ");
            firstList.Insert("99");
            firstList.DisplayNodes();
            s.showSpacer();

            Console.WriteLine("> Node inserted at index 17 (last node) is now: {0}", firstList.FindNode(17).NodeContent);
            s.showSpacer();

            Console.WriteLine("> Deleting Node at index 17: ");
            firstList.DeleteNode(17);
            firstList.DisplayNodes();
            s.showSpacer();

            Console.WriteLine("> The value at node 2 is: {0}", firstList.FindNode(2).NodeContent);
            s.showSpacer();


        }

    }
}


