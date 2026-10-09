using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;

            while (option != 6)
            {
                Console.WriteLine("\n==============  OPTIONS  ===========");
                Console.WriteLine("");
                Console.WriteLine("---------------------");
                Console.WriteLine("1. PLUS (+)");
                Console.WriteLine("2. MINUS (-)");
                Console.WriteLine("3. MULTIPLICATION (*)");
                Console.WriteLine("4. DIVISION (/)");
                Console.WriteLine("5. GRADE");
                Console.WriteLine("6. EXIT");
                Console.WriteLine("---------------------");
                Console.WriteLine("");

                Console.Write("Select an option: ");

                // Validamos la opción directamente aquí
                bool optionValid = int.TryParse(Console.ReadLine(), out option);
                Console.Clear();

                if (!optionValid)
                {
                    Console.WriteLine("\nError: Please enter a valid number (1-6)\n");
                    continue;
                }

                if (option == 6)
                {
                    break;
                }

                switch (option)
                {
                    // PLUS (+)
                    case 1:
                        while (true)
                        {
                            Console.WriteLine("----- PLUS -----");
                            Console.WriteLine("Just press ENTER to get the result\n");

                            double totalPlus = 0;

                            while (true)
                            {
                                Console.Write("Enter number: ");
                                string texto = Console.ReadLine();

                                if (texto == "")
                                {
                                    break;
                                }

                                if (double.TryParse(texto, out double number))
                                {
                                    totalPlus = totalPlus + number;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Only numbers are allowed. Try again.");
                                }
                            }

                            Console.WriteLine("---------------------");
                            Console.WriteLine($"Result is: {totalPlus}");
                            Console.WriteLine("---------------------");

                            Console.WriteLine("If you want to Exit press letter (x), and if you want to Calculate again press (ENTER)");
                            string exit = Console.ReadLine();
                            if (exit == "x" || exit == "X")
                            {
                                Console.Clear();
                                break;
                            }
                            Console.Clear();
                        }
                        break;

                    // MINUS (-)
                    case 2:
                        while (true)
                        {
                            Console.WriteLine("----- MINUS -----");
                            Console.WriteLine("Just press ENTER to get the result\n");

                            double totalMinus = 0;
                            int contador = 0;

                            while (true)
                            {
                                Console.Write("Enter number: ");
                                string text = Console.ReadLine();

                                if (text == "")
                                {
                                    break;
                                }

                                if (double.TryParse(text, out double number))
                                {
                                    if (contador == 0)
                                    {
                                        totalMinus = number;
                                        contador = 1;
                                    }
                                    else
                                    {
                                        totalMinus = totalMinus - number;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Only numbers are allowed. Try again.");
                                }
                            }

                            Console.WriteLine("---------------------");
                            Console.WriteLine($"Result is: {totalMinus}");
                            Console.WriteLine("---------------------");

                            Console.WriteLine("If you want to Exit press letter (x), and if you want to Calculate again press (ENTER)");
                            string exit = Console.ReadLine();
                            if (exit == "x" || exit == "X")
                            {
                                Console.Clear();
                                break;
                            }
                            Console.Clear();
                        }
                        break;

                    // MULTIPLICATION (*)
                    case 3:
                        while (true)
                        {
                            Console.WriteLine("----- MULTIPLICATION -----");
                            Console.WriteLine("Just press ENTER to get the result\n");

                            double totalMultiplition = 0;
                            int contador = 0;

                            while (true)
                            {
                                Console.Write("Enter number: ");
                                string text = Console.ReadLine();

                                if (text == "")
                                {
                                    break;
                                }

                                // Corregido: double.TryParse en vez de Parse
                                if (double.TryParse(text, out double number))
                                {
                                    if (contador == 0)
                                    {
                                        totalMultiplition = number;
                                        contador = 1;
                                    }
                                    else
                                    {
                                        totalMultiplition = totalMultiplition * number;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Only numbers are allowed. Try again.");
                                }
                            }

                            Console.WriteLine("---------------------");
                            Console.WriteLine($"Result: {totalMultiplition}");
                            Console.WriteLine("---------------------");

                            Console.WriteLine("If you want to Exit press letter (x), and if you want to Calculate again press (ENTER)");
                            string exit = Console.ReadLine();
                            if (exit == "x" || exit == "X")
                            {
                                Console.Clear();
                                break;
                            }
                            Console.Clear();
                        }
                        break;

                    // DIVISION (/)
                    case 4:
                        while (true)
                        {
                            Console.WriteLine("----- DIVISION -----");
                            Console.WriteLine("Just press ENTER to get the result\n");

                            double totalDivision = 0;
                            int contador = 0;

                            while (true)
                            {
                                Console.Write("Enter number: ");
                                string text = Console.ReadLine();

                                if (text == "")
                                {
                                    break;
                                }

                                if (double.TryParse(text, out double number))
                                {
                                    if (contador == 0)
                                    {
                                        totalDivision = number;
                                        contador = 1;
                                    }
                                    else
                                    {
                                        if (number == 0)
                                        {
                                            Console.WriteLine("Error: Cannot divide by zero. Number ignored.");
                                        }
                                        else
                                        {
                                            totalDivision = totalDivision / number;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Only numbers are allowed. Try again.");
                                }
                            }

                            Console.WriteLine("---------------------");
                            Console.WriteLine($"Result is: {totalDivision}");
                            Console.WriteLine("---------------------");

                            Console.WriteLine("If you want to Exit press letter (x), and if you want to Calculate again press (ENTER)");
                            string exit = Console.ReadLine();
                            if (exit == "x" || exit == "X")
                            {
                                Console.Clear();
                                break;
                            }
                            Console.Clear();
                        }
                        break;

                    // GRADE (A,B,C,F)
                    case 5:
                        Console.WriteLine("----- GRADE CALCULATOR -----");

                        while (true)
                        {
                            Console.WriteLine("-----------------------------------------------------------");
                            Console.WriteLine("To get your Grade, please complete this:");
                            Console.WriteLine("-----------------------------------------------------------\n");

                            int score1, score2, score3, score4;

                            Console.Write("Please Insert Your Score of Introduction to Programming: ");
                            while (!int.TryParse(Console.ReadLine(), out score1))
                            {
                                Console.Write("Invalid score. Enter a valid number: ");
                            }

                            Console.Write("Please Insert Your Score of Logic & Algorithms: ");
                            while (!int.TryParse(Console.ReadLine(), out score2))
                            {
                                Console.Write("Invalid score. Enter a valid number: ");
                            }

                            Console.Write("Please Insert Your Score of Object-Oriented Programming (OOP): ");
                            while (!int.TryParse(Console.ReadLine(), out score3))
                            {
                                Console.Write("Invalid score. Enter a valid number: ");
                            }

                            Console.Write("Please Insert Your Score of Database Fundamentals: ");
                            while (!int.TryParse(Console.ReadLine(), out score4))
                            {
                                Console.Write("Invalid score. Enter a valid number: ");
                            }

                            Console.WriteLine("");

                            int average = (score1 + score2 + score3 + score4) / 4;

                            Console.WriteLine("-----------------------------------------------------------");
                            if (average >= 90 && average <= 100)
                            {
                                Console.WriteLine($"Congratulations, Amazing Score of: {average}");
                                Console.WriteLine("GRADE: (A)");
                            }
                            else if (average >= 80 && average <= 89)
                            {
                                Console.WriteLine($"Good Job, Score: {average}");
                                Console.WriteLine("GRADE: (B)");
                            }
                            else if (average >= 70 && average <= 79)
                            {
                                Console.WriteLine($"Score: {average}");
                                Console.WriteLine("GRADE: (C)");
                            }
                            else
                            {
                                Console.WriteLine($"I'm Sorry but You Failed, You got A Score of: {average}");
                                Console.WriteLine("GRADE: (F)");
                            }
                            Console.WriteLine("-----------------------------------------------------------");

                            Console.WriteLine("If you want to Exit press letter (x), and if you want to Calculate again press (ENTER)");
                            string exit = Console.ReadLine();
                            if (exit == "x" || exit == "X")
                            {
                                Console.Clear();
                                break;
                            }
                            Console.Clear();
                        }
                        break;

                    case 6:
                        Console.WriteLine("The Program Has Finished");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Option not valid, select 1, 2, 3, 4, 5 or 6.");
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("The Program Has Finished. Goodbye");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
        }
    }
}