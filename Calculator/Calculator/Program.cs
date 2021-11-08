using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            Console.WriteLine("Welcome to the calculator\n=============================");
            c1.getOperator();
            c1.getInputs();
            int res = c1.doOp();
            Console.WriteLine("The answer is {0}", res);
            Console.ReadLine();

        }
    }
    class Calculator
    {
        char op = '+';
        int noNums;
        int n1;
        string operands = "";
        public Calculator()
        {

        }
        public void getOperator()
        {
            Console.WriteLine("Please enter the operator.");
            char tOp = Console.ReadLine().ToCharArray()[0];
            if (tOp == '+' || tOp == '-' || tOp == '*' || tOp == '/')
                op = tOp;
            
        }
        public void getInputs()
        {
            Console.WriteLine("How many numbers do you want to {0}?", op);
            this.noNums = int.Parse(Console.ReadLine());
            for(int i = 1; i <= noNums; i++)
            {
                Console.WriteLine("Please enter number {0}:", i);
                operands = operands + Console.ReadLine().ToCharArray()[0];
                if (i == 1)
                    n1 = i;
                    
            }
            
        }
        public int doOp()
        {
            int runningT = n1;
            char[] numList = operands.ToCharArray();
            for(int c = 1; c <operands.Length; c++)
            {
                String s = numList[c].ToString();
                int x = int.Parse(s);

                if (this.op == '+')
                    runningT += x;
                else if (this.op == '-')
                    runningT -= x;
                else if (this.op == '*')
                    runningT *= x;
                else
                    runningT /= x;
            }
            return runningT;
            
        }

    }
}
