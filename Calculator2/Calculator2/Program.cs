using System;

namespace Calculator2
{
    class Program
    {
        static string nAnString = "Error. Please enter either 1 or 2.";
       
        static string welcomeString = "Welcome to the calculator\n" +
                               "=========================";
        static string modeQuestion = "\nWhich mode do you want?\n" +
                                  "1) Numbers\n2) Dates\n3) Exit\n> ";
        static void Main(string[] args)
        {
            while (true)
            {
                printWelcomeMessage();
                int mode = getMode();
                if(mode == 1)
                {
                    NumberCalculator nc = new NumberCalculator();
                }
                else if (mode == 2)
                {
                    DateCalculator dc = new DateCalculator();
                }
                else if (mode == 3)
                {
                    Console.WriteLine("Exiting...");
                    break;
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
        private static void showError(string errorM)
        {
            Console.WriteLine(errorM);

        }





    }
}
