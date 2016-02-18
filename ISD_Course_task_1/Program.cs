using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int chosen_exersise = -1;

            while(chosen_exersise != 0)
            {
                Console.WriteLine("\tISD Course. Homework by Fedor Voloshyn\n");
                Console.WriteLine("1. Task with name");
                Console.WriteLine("2. Tasks with conditional operators");
                Console.WriteLine("3. Tasks with cycles");
                Console.WriteLine("Enter number of section or '0' to exit: ");
                chosen_exersise = Convert.ToInt32(Console.ReadLine());
                
                switch (chosen_exersise)
                {
                    case 0: Console.WriteLine("Have a nice day!");
                        break;
                    case 1: Console.WriteLine("Enter your name: ");
                        TheTaskWithName(Console.ReadLine());
                        break;
                    case 2: Console.WriteLine("Enter number of exercise: ");
                        TheTaskWithConditionalOperators(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 3: Console.WriteLine("Enter number of exercise: ");
                        TheTaskWithCicles(Convert.ToInt32(Console.ReadLine()));
                        break;
                    default: Console.WriteLine("Looks like you entered wrong number! Try again ;)");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void TheTaskWithName(string MyName)
        {
            string first_string = "", second_string = "", third_string = "";
            // Construct strings
            for (int i = 0; i < MyName.Length + 2; i++)
            {
                if (i == 0 || i == MyName.Length + 1)
                {
                    first_string += '+';
                    second_string += '|';
                    third_string += '+';
                }
                else
                {
                    first_string += '-';
                    second_string += MyName[i - 1];
                    third_string += '-';
                }
            }
            Console.WriteLine(first_string);
            Console.WriteLine(second_string);
            Console.WriteLine(third_string);
        }

        static void TheTaskWithConditionalOperators(int exercise_number)
        {
            switch(exercise_number)
            {
                case 1: Console.WriteLine("Enter first number: ");
                    int first_number = Convert.ToInt32(Console.ReadLine()); 
                    Console.WriteLine("Enter second number: ");
                    int second_number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Bigger number is {0}", first_number > second_number ? first_number : second_number);
                    break;
                case 2: Console.WriteLine("Enter animal's speach: ");
                    string animals_speach = Console.ReadLine();
                    if (animals_speach == "мяу")
                        Console.WriteLine("Покорми кота");
                    else if (animals_speach == "гав")
                        Console.WriteLine("Выгуляй кота");
                    else Console.WriteLine("Unknown animal speach");
                    break;
                default: Console.WriteLine("Wrong exercise number!");
                    break;
            }
        }

        static void TheTaskWithCicles(int exercise_number)
        {
            switch (exercise_number)
            {
                case 1:
                    break;
                default: Console.WriteLine("Wrong exercise number!");
                    break;
            }
        }
    }
}
