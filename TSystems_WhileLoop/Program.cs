using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystems_WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================WHILELOOP=================");
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"While loop is executed  {i}");
                i++;
            }
            Console.ReadLine();
        }
    }
}
