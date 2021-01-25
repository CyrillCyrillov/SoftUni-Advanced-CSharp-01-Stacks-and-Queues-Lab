using System;
using System.Collections.Generic;

namespace Task04_Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string arithmeticExpression = Console.ReadLine();
            Stack<int> indexBrackets = new Stack<int>();
            int startIndex = 0;

            for (int i = 0; i <= arithmeticExpression.Length - 1; i++)
            {
                if(arithmeticExpression[i] == '(')
                {
                    indexBrackets.Push(i);
                }

                if(arithmeticExpression[i] == ')')
                {
                    startIndex = indexBrackets.Pop();
                    //string substring = arithmeticExpression.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(arithmeticExpression.Substring(startIndex, i - startIndex + 1));
                }
            }
        }
    }
}
