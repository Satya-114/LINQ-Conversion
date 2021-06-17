using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_ToList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating Integer Array
            int[] numbersArray = { 10, 22, 30, 40, 50, 60 };
            //Converting Integer Array to List using ToList method
            List<int> numbersList = numbersArray.ToList();
            foreach (var num in numbersList)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
