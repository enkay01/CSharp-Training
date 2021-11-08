using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            Console.WriteLine("Hello World!");
            c1.getOperator();
            c1.getInputs();
            int res = c1.doOp();
            Console.WriteLine("The result is {0}", res);
            Console.ReadLine();
        }
    }
    class Calculator
    {
        char op = '+';
        int n1;
        int n2;
        public Calculator()
        {

        }
        public void getOperator()
        {
            Console.WriteLine("Please enter the operator");
            char tOp = Console.ReadLine().ToCharArray()[0];
            if (tOp == '+' || tOp == '-' || tOp == '*' || tOp == '/')
                op = tOp;
            
        }
        public void getInputs()
        {
            Console.WriteLine("Enter number 1");
            this.n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            this.n2 = int.Parse(Console.ReadLine());
            
        }
        public int doOp()
        {
            if (this.op == '+')
                return this.n1 + this.n2;
            else if (this.op == '-')
                return this.n1 - this.n2;
            else if (this.op == '*')
                return this.n1 * this.n2;
            else
                return this.n1 / this.n2;
        }
    }
}
