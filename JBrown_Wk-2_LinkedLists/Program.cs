/* CSC382 - Data Structures & Algorithms
 * 18 MAY, 2015 - Week 2
 * Jason Brown
 * 
 * Linked List
 * 
 * Driver program to demonstrate features.
 * 
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DblLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectTitle = "\t Linked Lists - Week 2 - CSC382 - Jason Brown";
            Random randNum = new Random();
            int nodeContent = 0;
            int initNumNodes = 15; // Total nodes to generate randomly
            int ceilingNum = 100; // Maximum value for any given node
            int floorNum = 12; // Maximum value for any given node

            // SpacerClass s = new SpacerClass('+');
            // 's' object allows for a spacer bar, header, and a clear screen method
            Aesthetics.SpacerClass s = new Aesthetics.SpacerClass();

            // Create a new linked list - null at the moment
            MyLinkedList firstList = new MyLinkedList();

            // Populate the list with pseudo random numbers
            for (int count = 0; count < initNumNodes; count++)
            {
                nodeContent = randNum.Next(floorNum, ceilingNum);
                firstList.Insert(nodeContent);
            }

            // Shows a title at the top
            s.DisplayHeader('_', projectTitle);

            Console.WriteLine("> Display the randomly generated nodes: ");
            s.ShowSpacer();
            firstList.DisplayNodesVertical();
            s.ShowSpacer();
            s.ClearScreen('_', projectTitle);

            Console.WriteLine("> Inserting the value '11' at the end: ");
            s.ShowSpacer();
            firstList.Insert(11);
            firstList.DisplayNodesHorizontal();
            s.ShowSpacer();
            s.ClearScreen('_', projectTitle);

            Console.WriteLine("> Inserting the value '99' at the end: ");
            s.ShowSpacer();
            firstList.Insert(99);
            firstList.DisplayNodesHorizontal();
            s.ShowSpacer();
            s.ClearScreen('_', projectTitle);

            Console.WriteLine("> Node inserted at index 17 (last node) is now: {0}", firstList.FindNode(17).NodeContent);
            s.ShowSpacer();
            firstList.DisplayNodesHorizontal();
            s.ClearScreen('_', projectTitle);

            Console.WriteLine("> Deleting Node at index 17: ");
            firstList.DeleteNode(17);
            s.ShowSpacer();
            firstList.DisplayNodesHorizontal();
            s.ShowSpacer();
            s.ClearScreen('_', projectTitle);

            firstList.DisplayNodesHorizontal();

            s.ShowSpacer();
            Console.WriteLine("> The value at node 2 is: {0}", firstList.FindNode(2).NodeContent);
            s.ShowSpacer();

            Console.WriteLine("> The minimum value is: {0}", firstList.MinimumNode());
            s.ShowSpacer();

            Console.WriteLine("> The maximum value is: {0}", firstList.MaximumNode());
            s.ShowSpacer();

            Console.WriteLine("> The size of the list is: {0}", firstList.Count);
            s.ShowSpacer();

            Console.WriteLine("> The last node of the list is: {0}", firstList.FindNode(firstList.Count).NodeContent);
            s.ShowSpacer();

            Console.WriteLine("> Reverse the list: ");
            Console.WriteLine();
            firstList.DisplayNodesReverseHorizontal();
            s.ShowSpacer();
            Console.WriteLine("> Press any key...");
            s.ClearScreen('_', projectTitle);

            Console.WriteLine("\n> Thanks!\n");
            Console.WriteLine("> Press any key...");
            s.ClearScreen('=', projectTitle);

            //projectTitle = "\t Sorting - Ascending";
            //s.ClearScreen('_', projectTitle);
            //firstList.SortList(ref firstList);
            ////firstList.Insert(0);
            //firstList.DisplayNodesReverseHorizontal();
            //s.ShowSpacer();

            //firstList.SortList(ref firstList);
            //firstList.DisplayNodesReverseHorizontal();
            //s.ShowSpacer();
            
        }

    }
}


