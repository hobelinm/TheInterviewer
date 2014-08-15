using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    class StringReverse
    {
        /// <summary>
        /// This code reverse a string 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            String reversal;
            // Interactive or automatic solution
            if(args.Length != 1)
            {
                Console.WriteLine("[StringReverse] Usage: StringReverse.exe 'My String'");
                Console.Write("Enter a string to reverse: ");
                reversal = Console.ReadLine();
            }
            else
            {
                reversal = args[0];
            }

            for(int index = reversal.Length - 1; index >= 0; index--)
            {
                Console.Write(reversal[index]);
            }

            Console.WriteLine("");
        }
    }
}
