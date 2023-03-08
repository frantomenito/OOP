using System;
using System.Linq;

namespace Lab_2
{
    internal class Part_1_part_1
    {
        double[] vector = new double[0];

        public void showMenu()
        {
            Console.WriteLine("\n\nOptions Menu:");
            Console.WriteLine("1-Make vector");
            Console.WriteLine("2-Show vector values");
            Console.WriteLine("3-Replace elements, which are bigger than average, to 0");
            Console.WriteLine("4-Exit");

            string options = Console.ReadLine().ToString();
            switch (options)
            {
                case "1":
                    Console.WriteLine(
                        "Enter double number sequence separated using space. Array size should be the same as selected.\n");

                    string input = Console.ReadLine().ToString();
                    double[] newArray = input.Split(' ').Select(double.Parse).ToArray();
                    vector = newArray;

                    showMenu();
                    break;
                case "2":
                    if (vector.Length == 0)
                    {
                        Console.WriteLine("Vector is empty");
                    }
                    else
                    {
                        for (int i = 0; i < vector.Length; i++)
                        {
                            Console.WriteLine(vector[i]);
                        }
                    }

                    showMenu();
                    break;

                case "3":
                    double average = 0;
                    for (int i = 0; i < vector.Length; i++)
                    {
                        average += vector[i];
                    }

                    average /= vector.Length;

                    for (int i = 0; i < vector.Length; i++)
                    {
                        if (vector[i] > average)
                        {
                            vector[i] = 0;
                        }
                    }

                    Console.WriteLine("Average was: " + average + ". Everything bigger is now 0");

                    showMenu();
                    break;
                case "4":
                    Console.WriteLine(@"Snap back to reality!");
                    break;
                default:
                    Console.WriteLine("Wrong choice!");
                    showMenu();
                    break;
            }
        }
    }
}