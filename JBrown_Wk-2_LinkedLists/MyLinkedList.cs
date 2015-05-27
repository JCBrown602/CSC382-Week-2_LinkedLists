using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DblLinkedList
{
    public class MyLinkedList
    {
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
                return size;
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
            }

            current = newNode;
        }

        /// <summary>
        /// Displays all nodes currently in the list.
        /// </summary>
        public void DisplayNodes()
        {
            Node tempNode = head;

            while (tempNode != null)
            {
                Console.WriteLine(tempNode.NodeContent);
                tempNode = tempNode.Next;
            }
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
                if (tempNode.Next == null)
                {
                    break;
                }

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




    }
}
 