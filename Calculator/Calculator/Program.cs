using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            Console.WriteLine("Hello World!");
            int res = c1.getProduct();
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
    class Calculator
    {
        public Calculator()
        {

        }
        public int getProduct()
        {
            Console.WriteLine("Enter number 1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int n2 = int.Parse(Console.ReadLine());
            return n1 * n2;
        }
    }
}
