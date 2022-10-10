using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stackParentheses = new Stack<char>();
            bool isSuccess = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{' || input[i] == '[' || input[i] == '(')
                {
                    stackParentheses.Push(input[i]);
                    continue;
                }
 
                if (stackParentheses.Count == 0)
                {
                    isSuccess = false;
                    break;
                }

                if (input[i] == '}' && stackParentheses.Peek() == '{'
                    || input[i] == ']' && stackParentheses.Peek() == '['
                    || input[i] == ')' && stackParentheses.Peek() == '(')
                {
                    stackParentheses.Pop();
                }
                else
                {
                    isSuccess = false;
                    break;
                }
            }

            if (isSuccess == true)
            {
                Console.WriteLine("Is valid");
            }
            else
            {
                Console.WriteLine("Not valid");
            }
        }
    }
}
