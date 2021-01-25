using System;
using System.Collections.Generic;

namespace Task01_Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            Stack<char> reverseStringStack = new Stack<char>();

            for (int i = 0; i <= inputString.Length - 1 ; i++)
            {
                reverseStringStack.Push(inputString[i]);
            }

            //int stackSize = reverseStringStack.Count;

            while (reverseStringStack.Count > 0)
            {
                Console.Write(reverseStringStack.Pop());
            }
            
            
            
            //Console.WriteLine("Hello World!");
        }
    }
}
