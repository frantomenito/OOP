using System;
using System.Linq;

namespace Lab_2
{
    internal class Part_1_part_1
    {
        static double[] vector = new double[0];

        public void showMenu()
        {
            Console.WriteLine("\n\nOptions Menu:");
            Console.WriteLine("1-Add value to vector");
            Console.WriteLine("2-Show vector values");
            Console.WriteLine("3-Do lab_2 part 1 part 1");
            Console.WriteLine("4-Exit");

            string options = Console.ReadLine().ToString();
            switch (options)
            {
                case "1":
                    Console.WriteLine("Enter double number:");
                    double newElement = Double.Parse(Console.ReadLine().ToString());

                    Array.Resize(ref vector, vector.Length + 1);
                    vector[vector.Length - 1] = newElement;

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
                    
                    Console.WriteLine("Average was: " + average);
                    
                    showMenu();
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Wrong choice!");
                    showMenu();
                    break;
            }
        }
    }
}
