using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePolishNotation
{
    class ReversePolishNotation
    {
        /// <summary>
        /// Reverse Polish Notation
        /// Usage: ReversePolishNotation.exe '1 2 + 3 *'
        /// would execute: (1 + 2) * 3
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            if(args.Length != 1)
            {
                Console.WriteLine("[ReversePolishNotation] Usage:");
                Console.WriteLine("ReversePolishNotation.exe '1 2 + 3 *'");
                return;
            }

            String[] operationTokens = args[0].Split(' ');
            double result = 0.0;
            CustomStack storage = new CustomStack();
            for(int index = 0; index < operationTokens.Length; index++)
            {
                switch(operationTokens[index])
                {
                    case "+":
                        // Addition
                        if (storage.count > 1)
                        {
                            result = storage.pop() + storage.pop();
                            storage.push(result);
                        }
                        else
                        {
                            Console.WriteLine("[ReversePolishNotation] Error: String '{0}' contains errors - ErrorCode: NotEnoughStackItems", args[0]);
                            return;
                        }
                        break;
                    case "-":
                        // Substraction
                        if (storage.count > 1)
                        {
                            double temp = storage.pop();
                            result = storage.pop() - temp;
                            storage.push(result);
                        }
                        else
                        {
                            Console.WriteLine("[ReversePolishNotation] Error: String '{0}' contains errors - ErrorCode: NotEnoughStackItems", args[0]);
                            return;
                        }
                        break;
                    case "*":
                        // Multiplication
                        if (storage.count > 1)
                        {
                            result = storage.pop() * storage.pop();
                            storage.push(result);
                        }
                        else
                        {
                            Console.WriteLine("[ReversePolishNotation] Error: String '{0}' contains errors - ErrorCode: NotEnoughStackItems", args[0]);
                            return;
                        }
                        break;
                    case "/":
                        // Division
                        if(storage.count > 1)
                        {
                            double temp = storage.pop();
                            result = storage.pop() / temp;
                            storage.push(result);
                        }
                        else
                        {
                            Console.WriteLine("[ReversePolishNotation] Error: String '{0}' contains errors - ErrorCode: NotEnoughStackItems", args[0]);
                            return;
                        }
                        break;
                    default:
                        // It's a number
                        double value;
                        try
                        {
                            value = Convert.ToDouble(operationTokens[index]); // An implementation for this can be a good exercise!
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("[ReversePolishNotation] Error: Unable to convert to {0} to Double", 
                                operationTokens[index]);
                            return;
                        }

                        storage.push(value);
                        break;
                }
            }

            Console.WriteLine("[ReversePolishNotation] Operation Completed with {0} remaining items on the stack", storage.count);
            Console.WriteLine(storage.pop());
        }
    }
}
