using System;
using System.Collections.Generic;
using System.Linq;

namespace Task02_Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialNumber = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> stackForSum = new Stack<int>();
            
            foreach (int element in initialNumber)
            {
                stackForSum.Push(element);
            }

            while (true)
            {
                string[] rawComand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(rawComand[0].ToUpper() == "END")
                {
                    break;
                }

                if(rawComand[0].ToUpper() == "ADD")
                {
                    stackForSum.Push(int.Parse(rawComand[1]));
                    stackForSum.Push(int.Parse(rawComand[2]));
                }

                if ((rawComand[0].ToUpper() == "REMOVE") && (int.Parse(rawComand[1]) < stackForSum.Count))
                {
                    for (int i = 1; i <= int.Parse(rawComand[1]); i++)
                    {
                        stackForSum.Pop();
                    }
                }
            }

            Console.WriteLine($"Sum: {stackForSum.Sum()}");
        }
    }
}
