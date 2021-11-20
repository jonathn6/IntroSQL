using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
            var arr = new int[] { 1, 2, 3, 4, 5 };
            var returnInt = arr.Where(x => x % 2 == 0);

        }
    }
}
