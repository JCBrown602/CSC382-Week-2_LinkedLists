/* CSC382 - Data Structures & Algorithms
 * 18 MAY, 2015 - Week 2
 * Jason Brown
 * 
 * Linked List - Using code from: http://channel9.msdn.com/Forums/TechOff/A-simple-and-pure-C-implementation-of-the-good-old-linked-list
 * Written by: Mauricio Feijo
 * Added find minimum and find maximum (and minor changes)
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

// Only need System!
using System;

namespace DblLinkedList
{
    public class MyLinkedList
    {
        /// <summary>
        /// Basic Node.
        /// <params>
        /// int NodeContent, Node Next, Node Prior
        /// </params>
        /// </summary>
        public class Node
        {
            public int NodeContent;
            public Node Next;
            public Node Prior;
        }

        private int size;
        public int Count
        {
            get
            {
                return (size - 1);
            }
        }

        /// <summary>
        /// The head of the list.
        /// </summary>
        private Node head;

        /// <summary>
        /// The current node
        /// </summary>
        private Node current;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public MyLinkedList()
        {
            size = 0;
            head = null;
        }

        /// <summary>
        /// Insert a new node to the linked list.
        /// </summary>
        /// <param name="newNode"></param>
        public void Insert(int newData)
        {
            size++;

            Node newNode = new Node()
            {
                NodeContent = newData
            };

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                current.Next = newNode;
                newNode.Prior = current;
            }

            current = newNode;
        }

        /// <summary>
        /// Vertically displays all nodes currently in the list.
        /// </summary>
        public void DisplayNodesVertical()
        {
            Node tempNode = head;

            while (tempNode != null)
            {
                Console.WriteLine(tempNode.NodeContent);
                tempNode = tempNode.Next;
            }
        }

        /// <summary>
        /// Horizontally displays all nodes currently in the list.
        /// </summary>
        public void DisplayNodesHorizontal()
        {
            Node tempNode = head;

            while (tempNode != null)
            {
                if (tempNode.Next == null)
                {
                    Console.Write(tempNode.NodeContent.ToString());
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(tempNode.NodeContent + ", ");
                }
                tempNode = tempNode.Next;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Searches for a certain node (needs to return a node!).
        /// </summary>
        public Node FindNode(int Index)
        {
            Node tempNode = head;
            Node findNode = null;
            int count = 0;

            while (tempNode != null)
            {
                if (count == (Index - 1))
                {
                    findNode = tempNode;
                    break;
                }
                count++;
                tempNode = tempNode.Next;
            }

            return findNode;
        }

        public bool DeleteNode(int Index)
        {
            if (Index == 1)
            {
                head = null;
                current = null;
                return true;
            }

            if (Index > 1 && Index <= size)
            {
                Node tempNode = head;

                Node lastNode = null;
                int count = 0;

                while (tempNode != null)
                {
                    if (count == Index - 1)
                    {
                        lastNode.Next = tempNode.Next;
                        return true;
                    }
                    count++;

                    lastNode = tempNode;
                    tempNode = tempNode.Next;
                }
            }

            return false;
        }

        public int MinimumNode()
        {
            Node tempNode = head;
            Node minNode = tempNode;
            int count = 0;

            while (tempNode != null)
            {
                //if (tempNode.Next == null)
                //{
                //    break;
                //}

                if (minNode.NodeContent > tempNode.NodeContent)
                {
                    minNode = tempNode;
                }
                count++;
                tempNode = tempNode.Next;
            }
            //minNode = tempNode;
            return minNode.NodeContent;
        }

        public int MaximumNode()
        {
            Node tempNode = head;
            Node minNode = tempNode;
            int count = 0;

            while (tempNode != null)
            {
                if (tempNode.Next == null)
                {
                    break;
                }

                if (minNode.NodeContent < tempNode.NodeContent)
                {
                    minNode = tempNode;
                }
                count++;
                tempNode = tempNode.Next;
            }
            //minNode = tempNode;
            return minNode.NodeContent;
        }

        /// <summary>
        /// Reverses the horizontal display of all nodes currently in the list.
        /// </summary>
        public void DisplayNodesReverseHorizontal()
        {
            Node tempNode = this.FindNode(Count);

            for (int counter = this.Count; counter > 0; counter--)
            {
                if (counter == 1)
                {
                    Console.Write(this.FindNode(counter).NodeContent);
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(this.FindNode(counter).NodeContent + ", ");
                }
            }
        }

        /// <summary>
        /// Sorts the list in ascending order.
        /// </summary>
        public void SortList()
        {            
            //Node tempNode = head;
            //Node nextNode = tempNode.Next;
            //int tempContent = tempNode.NodeContent;
                        
            //while (nextNode != null)
            //{
            //    if (tempNode.NodeContent < nextNode.NodeContent && nextNode != null)
            //    {
            //        tempNode = tempNode.Next;
            //    }
            //    else
            //    {
            //        tempContent = tempNode.Next.NodeContent;
            //        tempNode.Next.NodeContent = tempNode.NodeContent;
            //        tempNode.NodeContent = tempContent;
            //        tempNode = tempNode.Next;
            //    }
            //}
        }
    }
}
 