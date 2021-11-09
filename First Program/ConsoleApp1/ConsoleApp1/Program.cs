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
            sentence_loop();
            Console.ReadLine();
        }

        public static void sentence_loop()
        {
            string sentence = "";
            while (true)
            {
                Console.WriteLine("Enter a word: ");
                string s = Console.ReadLine();
                if (s.Equals(""))
                    break;
                sentence += s + " ";
                Console.WriteLine("Current sentence: {0}", sentence);
            }
            Console.WriteLine("Final sentence: {0}", sentence);
        }

        public static void times_tables()
        {
            Console.WriteLine("Hello World! Please enter a number");
            int max = int.Parse(Console.ReadLine());
            int res = 0;
            for(int i = 2; i <= max; i++)
            {
                for(int j = 2; j <= max; j++)
                {
                    res = i * j;
                    Console.WriteLine("{0} X {1} = {2}", j, i, res);
                }
                Console.WriteLine("\n");
            }
        }
        public static void sum_of_all()
        {
            int max = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int c = 1; c <= max; c++)
            {
                sum += c;
            }
            Console.WriteLine("The sum of numbers 1 to {0} is: {1}", max, sum);
        }
        public static void nameFunction()
        {
            Console.WriteLine("Hello World! Please enter your first name");
            string name1 = Console.ReadLine();
            Console.WriteLine("Please enter your second name");
            string name2 = Console.ReadLine();
            if (name1.Equals("") && name2.Equals(""))
            {
                Console.WriteLine("You didn't enter a name");
            }
            else if (name2.Equals("") || name1.Equals(""))
            {
                Console.WriteLine("Hello, {0}{1}! I see you only have one name, but that's fine!", name1, name2);
            }
            else
            {
                Console.WriteLine("Hello, {0} {1}!", name1, name2);
            }
            Console.ReadLine();

        }
    }
}
