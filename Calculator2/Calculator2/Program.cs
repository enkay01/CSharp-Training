using System;

namespace Calculator2
{
    class Program
    {
        static string nAnString = "Error. Please enter either 1 or 2.";
        static string datePrompt = "\nPlease enter a date: ";
        static string dayPrompt = "\nPlease enter the number of days to add";
        static string welcomeString = "Welcome to the calculator\n" +
                               "=========================";
        static string modeQuestion = "\nWhich mode do you want?\n" +
                                  "1) Numbers\n2)Dates\n>";
        static void Main(string[] args)
        {
            while (true)
            {
                printWelcomeMessage();
                int mode = getMode();
                if(mode == 1)
                {
                    performNumberCalculation();
                }
                else if (mode == 2)
                {
                    performDateCalculation();
                }
                else
                {
                    showError(nAnString);
                }
            }
        }
        public static void printWelcomeMessage()
        {
            
            Console.WriteLine(welcomeString);
        }
        static int getMode()
        {
            
            Console.Write(modeQuestion);
            int ans;
            if(int.TryParse(Console.ReadLine(), out ans))
            {
                return ans;
            }
            else
            {
                return -1;
            }
        }
        
        //Numbers
        private static string AskForOperator()
        {
            Console.Write("Please enter the operator: ");
            string op = Console.ReadLine();
            return op;
        }
        static void performNumberCalculation()
        {
            var op = AskForOperator();
            var numbers = AskForNumberArray(op);
            var answer = CalculateAnswer(op, numbers);

            Console.WriteLine("The answer is: " + answer);
            Console.WriteLine();
        }
        private static int[] AskForNumberArray(string op)
        {
            var count = AskForNumber("How many numbers do you want to " + op + "? ");

            int[] numbers = new int[count];
            for (int index = 0; index < count; index++)
            {
                numbers[index] = AskForNumber("Please enter number " + (index + 1) + ": ");
            }
            return numbers;
        }

        private static int AskForNumber(string message)
        {
            int count;

            do
            {
                Console.Write(message);
            } while (!int.TryParse(Console.ReadLine(), out count));

            return count;
        }

        private static int CalculateAnswer(string op, int[] numbers)
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
        
        //Dates
        static void performDateCalculation()
        {
            DateTime dt = askForDate();
            int dy = askForDays();
            Console.WriteLine("The answer is: {0}", addDays(dt, dy));
        }
        static DateTime askForDate()
        {
            DateTime date;
            do
            {
                Console.Write(datePrompt);
                

            } while (!DateTime.TryParse(Console.ReadLine(), out date));
            return date;
        }
        static int askForDays()
        {
            int days;
            do
            {
                Console.Write(dayPrompt);
            } while (!int.TryParse(Console.ReadLine(), out days));
            return days;
        }
        static DateTime addDays(DateTime date, int days)
        {
            return date.AddDays(days);
        }

        static void showError(string errorM)
        {
            Console.WriteLine(errorM);

        }
    }
}
