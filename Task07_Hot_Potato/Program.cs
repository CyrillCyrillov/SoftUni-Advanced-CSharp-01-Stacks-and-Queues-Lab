using System;
using System.Collections.Generic;
using System.Linq;

namespace Task07_Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNames = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            Queue<string> names = new Queue<string>();
            foreach (string name in inputNames)
            {
                names.Enqueue(name);
            }

            int countNumber = int.Parse(Console.ReadLine());

            while (names.Count > 1)
            {
                for (int i = 1; i < countNumber; i++)
                {
                    names.Enqueue(names.Dequeue());
                }

                Console.WriteLine($"Removed {names.Dequeue()}");
            }
            
            
            Console.WriteLine($"Last is {names.Dequeue()}");
        }
    }
}
