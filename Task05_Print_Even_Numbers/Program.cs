using System;
using System.Collections.Generic;
using System.Linq;

namespace Task05_Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> numbersQueue = new Queue<int>();

            foreach (int element in numbers)
            {
                numbersQueue.Enqueue(element);
            }

            while (numbersQueue.Count > 0)
            {
                int nextNumber = numbersQueue.Dequeue();
                if(nextNumber % 2 == 0)
                {
                    Console.Write(nextNumber);
                    if(numbersQueue.Count > 0)
                    {
                        Console.Write(", ");
                    }
                }
            }
        }
    }
}
