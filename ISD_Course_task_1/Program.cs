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
                Console.WriteLine("\tISD Course. Homework by Fedor Voloshyn.\n");
                Console.WriteLine("1. Task with name.");
                Console.WriteLine("2. Tasks with conditional operators.");
                Console.WriteLine("3. Tasks with cycles.");
                Console.WriteLine("Enter number of section or '0' to exit: ");
                chosen_exersise = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                
                switch (chosen_exersise)
                {
                    case 0: Console.WriteLine("Have a nice day!");
                        break;
                    case 1: Console.WriteLine("\tTask with name\nEnter your name: ");
                        TheTaskWithName(Console.ReadLine());
                        break;
                    case 2: Console.WriteLine("\tTasks with conditional operators\nEnter number of exercise: ");
                        TheTaskWithConditionalOperators(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 3: Console.WriteLine("\tTasks with cycles\nEnter number of exercise: ");
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
            Random Rand = new Random();
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
                        Console.WriteLine("Выгуляй собаку");
                    else Console.WriteLine("Unknown animal speach");
                    break;

                case 3: Console.WriteLine("Enter number of month: ");
                    switch(Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1: 
                        case 2:
                        case 12: Console.WriteLine("Winter");
                            break;
                        case 3:
                        case 4:
                        case 5: Console.WriteLine("Spring");
                            break;
                        case 6:
                        case 7:
                        case 8: Console.WriteLine("Summer");
                            break;
                        case 9:
                        case 10:
                        case 11: Console.WriteLine("Autumn");
                            break;
                        default: Console.WriteLine("There is no such month on this planet!");
                            break;
                    }
                    break;

                case 4: Console.WriteLine("Enter number: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0}", number == 1 ? "Хорошо" : (number == 0 ? "Плохо" : "Не понятно"));
                    break;

                case 5: Console.WriteLine("Enter number from 1 to 7: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num > 0 && num < 8)
                    {
                        switch(num)
                        {
                            case 1: Console.WriteLine("Monday");
                                break;
                            case 2: Console.WriteLine("Tuesday");
                                break;
                            case 3: Console.WriteLine("Wednesday");
                                break;
                            case 4: Console.WriteLine("Thursday");
                                break;
                            case 5: Console.WriteLine("Friday");
                                break;
                            case 6: Console.WriteLine("Saturday");
                                break;
                            case 7: Console.WriteLine("Sunday");
                                break;
                        }
                    }
                    else
                        Console.WriteLine("Wrong number!");
                    break;

                case 6: Console.WriteLine("Enter number of km: ");
                    double km = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter number of minutes of inactivity: ");
                    double minutes = Convert.ToDouble(Console.ReadLine());
                    double price = 0;
                    if (km > 0 && minutes > 0)
                    {
                        price += km > 5 ? 20 + (km - 5) * 3 : 20;
                        price += minutes;
                        Console.WriteLine("Price: {0} UAH", price);
                    }
                    else
                        Console.WriteLine("Wrong data!");
                    break;

                case 7: Console.WriteLine("Enter natural number: ");
                    int natural_number = Convert.ToInt32(Console.ReadLine());
                    if(natural_number > 0)
                    {
                        if (natural_number > 3)
                        {
                            for (int i = 2; i <= Math.Sqrt(natural_number); i++)
                            {
                                if (natural_number % i == 0)
                                {
                                    Console.WriteLine("'{0}' is not simple number!", natural_number);
                                    break;
                                }
                                else if (i == Convert.ToInt32(Math.Truncate(Math.Sqrt(natural_number))))
                                    Console.WriteLine("'{0}' is simple number!", natural_number);
                            }
                        }
                        else if(natural_number > 1 && natural_number < 4)
                            Console.WriteLine("'{0}' is simple number!", natural_number);
                        else
                            Console.WriteLine("'{0}' is not simple number!", natural_number);
                    }
                    else
                        Console.WriteLine("It is not natural number!");
                    break;

                case 8: Console.WriteLine("Enter your parlay: ");
                    double parlay = Convert.ToDouble(Console.ReadLine());
                    if (parlay > 0)
                    {
                        int sqr = Rand.Next(1, 13);
                        switch (sqr)
                        {
                            case 1:
                            case 2:
                            case 3:
                            case 4:
                            case 5:
                                Console.WriteLine("{0}, you lost!", sqr);
                                break;
                            case 6:
                            case 7:
                            case 8:
                                Console.WriteLine("{0}, you win {1}.", sqr, parlay);
                                break;
                            case 9:
                            case 10:
                            case 11:
                                Console.WriteLine("{0}, you win {1}.", sqr, parlay * 2);
                                break;
                            case 12:
                                Console.WriteLine("{0}, you win {1}", sqr, parlay * 10);
                                break;
                        }
                    }
                    else
                        Console.WriteLine("Incorrect parlay!");
                    break;

                case 9: Console.WriteLine("Enter your summ: ");
                    double summ = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter number of your currency: ");
                    Console.WriteLine("1. UAH");
                    Console.WriteLine("2. USD");
                    Console.WriteLine("3. EUR");
                    int currency = Convert.ToInt32(Console.ReadLine());
                    if (summ > 0)
                    {
                        switch (currency)
                        {
                            case 1: Console.WriteLine("{0} UAH = {1} USD", summ, summ / 8.0);
                                Console.WriteLine("{0} UAH = {1} EUR", summ, summ / 10.0);
                                break;
                            case 2: Console.WriteLine("{0} USD = {1} UAH", summ, summ * 8.0);
                                Console.WriteLine("{0} USD = {1} EUR", summ, summ / 1.25);
                                break;
                            case 3: Console.WriteLine("{0} EUR = {1} UAH", summ, summ * 10.0);
                                Console.WriteLine("{0} EUR = {1} USD", summ, summ * 1.25);
                                break;
                            default: Console.WriteLine("Error: wrong number.");
                                break;
                        }
                    }
                    else
                        Console.WriteLine("Summ can't be negative!");
                    break;

                default: Console.WriteLine("Wrong exercise number!");
                    break;
            }
        }

        static void TheTaskWithCicles(int exercise_number)
        {
            Random Rand = new Random();
            switch (exercise_number)
            {
                case 1: Console.WriteLine("Enter N: ");
                    int N = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= 20; i++)
                        Console.WriteLine("{0} * {1} = {2}", N, i, N*i);
                    break;

                case 2: Console.WriteLine("Enter number: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    int count = 0;
                    do
                    {
                        number /= 10;
                        count++;
                    } while (Math.Abs(number) > 0);
                    Console.WriteLine("The rank of entered number = {0}", count);
                    break;

                case 3: Console.WriteLine("Enter your number: ");
                    int variant = Convert.ToInt32(Console.ReadLine());
                    int real_number = Rand.Next(1, 147);
                    while(variant != real_number)
                    {
                        if (variant > real_number)
                            Console.WriteLine("Number is less than yours");
                        else if(variant < real_number)
                            Console.WriteLine("Number is bigger than yours");
                        variant = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Correct! ({0}, {1})", variant, real_number);
                    break;

                case 4: Console.WriteLine("Enter your number: ");
                    int max_value = Convert.ToInt32(Console.ReadLine());
                    int sqr = 1;
                    if (max_value > 1)
                    {
                        while (sqr * sqr < max_value)
                        {
                            Console.WriteLine("{0} * {0} = {1}", sqr, sqr * sqr);
                            sqr++;
                        }
                    }
                    else
                        Console.WriteLine("No one sqr less then entered value.");
                    break;

                case 5:
                    {
                        Console.WriteLine("Enter 5 numbers: ");
                        double total_summ = 0;
                        for (int i = 0; i < 5; i++)
                            total_summ += Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Avarage = {0}", total_summ / 5);
                    }
                    break;

                case 6:
                    {
                        Console.WriteLine("5 numbers: ");
                        double total_summ = 0;
                        int buffer = 0;
                        for (int i = 0; i < 5; i++)
                        {
                            buffer = Rand.Next(-100, 101);
                            Console.WriteLine(buffer);
                            total_summ += buffer;
                        }
                        Console.WriteLine("Avarage = {0}", total_summ / 5);
                    }
                    break;

                case 7: int gooses = 2;
                    int rabbits = 15;
                    while (rabbits > 0)
                    {
                        Console.WriteLine("{0} gooses and {1} rabbits. Debug: {2} legs.", gooses, rabbits, gooses * 2 + rabbits * 4);
                        gooses += 2;
                        rabbits -= 1;
                    }
                    break;

                case 8: Console.WriteLine("Enter password:");
                    while(Console.ReadLine() != "root")
                    {
                        Console.WriteLine("Invalid password!\nTry again: ");
                    }
                    Console.WriteLine("Password correct!");
                    break;

                default: Console.WriteLine("Wrong exercise number!");
                    break;
            }
        }
    }
}
