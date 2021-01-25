using System;
using System.Collections.Generic;

namespace Task08_Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsPassNumber = int.Parse(Console.ReadLine());
            Queue<string> carsOnCrossroad = new Queue<string>();
            int passCarsCount = 0;

            while (true)
            {
                string rawData = Console.ReadLine();

                if(rawData.ToUpper() == "END")
                {
                    break;
                }

                if(rawData.ToUpper() == "GREEN")
                {
                    for (int i = 1; i <= carsPassNumber; i++)
                    {
                        if(carsOnCrossroad.Count > 0)
                        {
                            Console.WriteLine($"{carsOnCrossroad.Dequeue()} passed!");
                            passCarsCount++;
                        }
                    }
                }
                else
                {
                    carsOnCrossroad.Enqueue(rawData);
                }
            }
            
            Console.WriteLine($"{passCarsCount} cars passed the crossroads.");
        }
    }
}
