using System;
using System.Linq;
using System.Threading;

namespace Lab_2
{
    public class Part_1_part_3
    {
        double[] vector = new double[0];

        public void showMenu()
        {
            Console.WriteLine("\n\nOptions Menu:");
            Console.WriteLine("1-Make vector");
            Console.WriteLine("2-Remove values");
            Console.WriteLine("3-Show values");
            Console.WriteLine("4-Exit to main menu");


            string options = Console.ReadLine().ToString();
            switch (options)
            {
                case "1":
                    Console.WriteLine("Enter double number sequence separated using space\n");

                    string input = Console.ReadLine().ToString();
                    double[] newArray = input.Split(' ').Select(double.Parse).ToArray();

                    vector = newArray;

                    showMenu();
                    break;
                case "2":
                    Console.WriteLine(
                        "Enter what sequence you want to remove. First value should be less than second\n");

                    string input2 = Console.ReadLine().ToString();
                    double[] valuesSequence = input2.Split(' ').Select(double.Parse).ToArray();

                    if (valuesSequence.Length != 2)
                    {
                        Console.WriteLine(
                            "There should be 2 values. First less than second. For example 1 9. So values between this two number will be removed");
                        showMenu();
                        break;
                    }

                    double[] badUniversityArray = new double[vector.Length];
                    int countOfZeros = 0;

                    for (int i = 0; i < vector.Length; i++)
                    {
                        if (vector[i] <= valuesSequence[1] && vector[i] >= valuesSequence[0])
                        {
                            countOfZeros++;
                        }
                        else
                        {
                            badUniversityArray[i - countOfZeros] = vector[i];
                        }
                    }

                    for (int i = 0; i < countOfZeros; i++)
                    {
                        badUniversityArray[vector.Length - countOfZeros - 1] = 0;
                    }

                    vector = badUniversityArray;

                    showMenu();
                    break;
                case "3":
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