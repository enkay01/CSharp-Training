using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Please enter one number");
            string number1 = Console.ReadLine();
            Console.WriteLine("Please enter another number.");
            string number2 = Console.ReadLine();
            int n1 = int.Parse(number1);
            int n2 = int.Parse(number2);
            int res = n1 * n2;
            Console.WriteLine("The result is: {0}", res);
            Console.ReadLine();
        }
    }
    class Calculator
    {
        public Calculator()
        {
        }
    }
}
