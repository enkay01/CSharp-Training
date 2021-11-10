using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    class DateCalculator
    {
        private string datePrompt = "\nPlease enter a date: ";
        private string dayPrompt = "\nPlease enter the number of days to add: ";
        public DateCalculator() 
        {
            performDateCalculation();
        }
        public void performDateCalculation()
        {
            DateTime dt = askForDate();
            int dy = askForDays();
            Console.WriteLine("The answer is: {0}", addDays(dt, dy));
        }
        public DateTime askForDate()
        {
            DateTime date;
            do
            {
                Console.Write(datePrompt);


            } while (!DateTime.TryParse(Console.ReadLine(), out date));
            return date;
        }
        public int askForDays()
        {
            int days;
            do
            {
                Console.Write(dayPrompt);
            } while (!int.TryParse(Console.ReadLine(), out days));
            return days;
        }
        public DateTime addDays(DateTime date, int days)
        {
            return date.AddDays(days);
        }

        

    }
    class NumberCalculator
    {
        string nNumbersPrompt = "How many numbers do you want to {0}";
        string numberPrompt = "Please enter number {0}:";

        public NumberCalculator() 
        {
            performNumberCalculation();
        }
        private string AskForOperator()
        {
            while (true)
            {
                Console.Write("Please enter the operator: ");
                char op = Console.ReadLine().ToCharArray()[0];
                if (op == '+' || op == '-' || op == '*' || op == '/')
                {
                    return op + "";
                }
            }
        }
        public void performNumberCalculation()
        {
            var op = AskForOperator();
            var numbers = AskForNumberArray(op);
            var answer = CalculateAnswer(op, numbers);

            Console.WriteLine("The answer is: " + answer);
            Console.WriteLine();
        }
        private int[] AskForNumberArray(string op)
        {
            var count = AskForNumber(nNumbersPrompt, op);

            int[] numbers = new int[count];
            for (int index = 0; index < count; index++)
            {
                numbers[index] = AskForNumber(numberPrompt, "" + index+1);
            }
            return numbers;
        }

        private int AskForNumber(string message, string op)
        {
            int count;

            do
            {
                Console.Write(message, op);
            } while (!int.TryParse(Console.ReadLine(), out count));

            return count;
        }

        private  int CalculateAnswer(string op, int[] numbers)
        {
            int answer = numbers[0];

            for (int index = 1; index < numbers.Length; index++)
            {
                if (op == "*")
                {
                    answer = answer * numbers[index];
                }
                else if (op == "/")
                {
                    answer = answer / numbers[index];
                }
                else if (op == "+")
                {
                    answer = answer + numbers[index];
                }
                else if (op == "-")
                {
                    answer = answer - numbers[index];
                }
            }
            return answer;
        }

    }
}
