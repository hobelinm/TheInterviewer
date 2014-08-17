using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePolishNotation
{
    /// <summary>
    /// Node Class used by the stack structure
    /// </summary>
    class Node
    {
        public double value { get; set; }
        public Node prev { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Node()
        {
            this.value = 0.0;
        }

        /// <summary>
        /// Constructor with a given value
        /// </summary>
        /// <param name="value"></param>
        public Node(double value)
        {
            this.value = value;
        }

        /// <summary>
        /// Full constructor that specifies values for all the members
        /// </summary>
        /// <param name="value"></param>
        /// <param name="prev"></param>
        public Node(double value, Node prev)
        {
            this.value = value;
            this.prev = prev;
        }
    }

    /// <summary>
    /// Creates a stack with two elements space
    /// </summary>
    class CustomStack
    {
        public int count { get; set; }
        private Node head = null;
        private Node top = null;

        public CustomStack()
        {
            this.count = 0;
        }

        // push, pop, peek, count
        public void push(double value)
        {
            if (head == null)
            {
                head = new Node(value, null);
                top = head;
                this.count++;
            }
            else
            {
                Node item = new Node(value, top);
                top = item;
                this.count++;
            }
        }

        public double pop()
        {
            if(top != null)
            {
                double topValue = top.value;
                top = top.prev;
                count--;
                return topValue;
            }
            else
            {
                return 0.0;
            }
        }

        public double peek()
        {
            if(top != null)
            {
                return top.value;
            }
            else
            {
                return 0.0;
            }
        }
    }
}
