using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPalindrome
{
    class LongestPalindrome
    {
        /// <summary>
        /// This program returns the longest palindrome substring
        /// in a string
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string line;
            if(args.Length != 1)
            {
                Console.WriteLine("[LongestPalindrome] Usage - LongestPalindrome.exe 'alla alsla' ");
                string tempLine = Console.ReadLine();
                line = tempLine;
            }
            else
            {
                line = args[0];
            }

            if(line.Length == 0)
            {
                Console.WriteLine("[LongestPalindrome] Longest Palindrome: [] in string []");
                return;
            }

            if(line.Length == 1)
            {
                Console.WriteLine("[LongestPalindrome] Longest Palindrome: [{0}] in string [{1}]",
                    line, line);
                return;
            }

            String longest = "" + line[0];
            for(int i = 1; i < line.Length; i++)
            {
                String temp = GetPalindrome(line, i);
                if(temp.Length > longest.Length)
                {
                    // We've got a new longest palindrome
                    longest = temp;
                    // Did we find the longest possible?
                    if(longest.Length == line.Length)
                    {
                        // Yes, this is the largest
                        i = line.Length;
                    }
                }
            }

            Console.WriteLine("[LongestPalindrome] Longest Palindrome: [{0}] in string [{1}]",
                longest, line);
            return;
        }

        static public string GetPalindrome(string word, int center)
        {
            // Non even palindrome i.e. alala
            int start = center - 1;
            int end = center + 1;
            while((start >= 0) && (end < word.Length) && (word[start] == word[end]))
            {
                start--;
                end++;
            }

            // Correct broken state
            start++;
            end--;

            // If found a palindrome store it
            int size = end - start;
            string temp = "";
            if(size > 0)
            {
                temp = word.Substring(start, size + 1);
            }

            // Even palindrome i.e. alla
            start = center;
            end = center + 1;
            while((start >= 0) && (end < word.Length) && (word[start] == word[end]))
            {
                start--;
                end++;
            }

            // Correct broken state
            start++;
            end--;
            // replace the palindrome word
            if((end - start) > size)
            {
                // We found a bigger palindrome
                temp = word.Substring(start, end - start + 1);
            }

            return temp;
        }
    }
}
