using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace LINQ_Cast
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList
            {
                10,
                20,
                30
            };
            IEnumerable<int> result = list.Cast<int>();
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
