using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        class ListNode
        {
            public Object data;   // Custom data types
            public ListNode next; // 'Pointer' to the next item in the list

            // Class constructor
            public ListNode(Object data)
            {
                this.data = data;
            }
        }

        class LinkedListType
        {
            private ListNode head; // 'Pointer' to the head

            // *** List of Methods ***
            public OP_CODE AddAtEnd(Object data)
            {
                ListNode nData = new ListNode(data); // Create a new node and store the data
                nData.next = null;
                
                // Corner case: The list is empty
                if(this.head == null)
                {
                    this.head = nData; // Save the data in the head
                    return OP_CODE.SUCCESS;
                }
                else
                {
                    ListNode cursor = this.head; // Point to the beginning of this list
                    
                    while(cursor.next != null) // Traverse the list 
                    {
                        cursor = cursor.next;
                    }

                    cursor.next = nData;
                    return OP_CODE.SUCCESS;
                }
            }

            // TODO: Implement remaining methods
        }

        static void Main(string[] args)
        {
            // TODO: Complete usage
            if (args.Length == 0)
            {
                // Show help
                Console.WriteLine("> [LinkedList] - Usage:");
                Console.WriteLine("LinkedList.exe add ");
            }
            Console.WriteLine("Hello World");
        }

        enum OP_CODE
        {
            SUCCESS = 0,
            UNEXPECTED_END
        };
    }
}

/*
 *     CHANGE LOG
 * 1 - Initial version
*/