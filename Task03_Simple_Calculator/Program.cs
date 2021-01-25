using System;
using System.Collections.Generic;
using System.Linq;

namespace Task03_Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mathStringInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            Stack<string> mathStack = new Stack<string>();
            foreach (string element in mathStringInput.Reverse())
            {
                mathStack.Push(element.ToString());
            }

            while (mathStack.Count > 1)
            {
                int firstNumber = int.Parse(mathStack.Pop());
                string operation = mathStack.Pop();
                int secondNumber = int.Parse(mathStack.Pop());

                int result = 0;
                if(operation == "+")
                {
                    result = firstNumber + secondNumber;
                }
                
                if(operation == "-")
                {
                    result = firstNumber - secondNumber;
                }

                mathStack.Push(result.ToString());
            }
            
            Console.WriteLine(mathStack.Pop());
        }
    }
}
