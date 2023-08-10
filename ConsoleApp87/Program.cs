using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp87
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            int result;

            Console.Write("Enter first integer:");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer:");
            y = int.Parse(Console.ReadLine());
            Console.Write("Enter third integer:");
            z = int.Parse(Console.ReadLine());

            result = x * y * z;

            Console.WriteLine("product is{0}",result);
            Console.ReadLine();
        }
    }
}
