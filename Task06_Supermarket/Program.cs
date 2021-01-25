using System;
using System.Collections.Generic;


namespace Task06_Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customers = new Queue<string>();

            while (true)
            {
                string rawComand = Console.ReadLine();

                if(rawComand.ToUpper() == "END")
                {
                    break;
                }

                if(rawComand.ToUpper() == "PAID")
                {
                    while (customers.Count > 0)
                    {
                        Console.WriteLine(customers.Dequeue());
                    }
                }
                else
                {
                    customers.Enqueue(rawComand);
                }
            }
            
            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
