using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverseWord
{
    class StringReverseWord
    {
        /// <summary>
        /// Similar project to String Reverse for string reversal
        /// but it now reverses only the words in the string delimited 
        /// by a given character
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char separator;
            String reversal;

            if((args.Length != 2) && (args.Length != 1))
            {
                // Interactive mode
                Console.WriteLine("[StringReverseWord] Usage StringReverseWord.exe ' ' 'My String'");
                Console.Write("Enter separator character: ");
                String temp = Console.ReadLine();

                // This is a fix to detect empty strings '' has no 0 index apparently
                if(temp == String.Empty)
                {
                    Console.WriteLine("[StringReverseWord] Error: Separator must be a character!");
                    return;
                }

                separator = temp[0];
                Console.Write("Enter test string: ");
                reversal = Console.ReadLine();
            }
            else if(args.Length == 2)
            {
                // Programmatic mode
                separator = args[0][0];
                reversal = args[1];
            } 
            else 
            {
                // Programmatic mode using default separator ' '
                separator = ' ';
                reversal = args[0];

            }

            // Traverse the string forwards
            int startWord = 0;
            for(int index = 0; index < reversal.Length; index++)
            {
                // Do we found the character separator?
                if(reversal[index] == separator)
                {
                    // Print the word backwards, note the ternary operator ? to avoid edge conditions
                    for(int backIndex = (index == 0)? 0 : index - 1; backIndex >= startWord; backIndex--)
                    {
                        Console.Write(reversal[backIndex]);
                    }

                    // Add the separator character at the end
                    Console.Write(separator);
                    // Update startWord index 
                    startWord = index + 1;
                }
            }

            // Print the remaining items, AND condition prevents in case reversal is empty (edge case)
            for (int backIndex = (reversal.Length == 0) ? 0 : reversal.Length - 1; (backIndex >= startWord) && (reversal.Length > 0); backIndex-- )
            {
                Console.Write(reversal[backIndex]);
            }

            // Add a return carriage
            Console.WriteLine("");
        }
    }
}
