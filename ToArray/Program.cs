using System;
using System.Collections.Generic;
using System.Linq;

namespace ToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a List
            List<int> numbersList = new List<int>()
            {
                10, 22, 30, 40, 50, 60
            };
            //Converting List to Array
            int[] numbersArray = numbersList.ToArray();
            foreach (var num in numbersArray)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
