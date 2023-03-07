using System;
using System.Linq;
using System.Threading;

namespace Lab_2
{
    public class Part_2_part_3
    {
        static double[][] matrix = new double[0][];
        private int rowLenght = 0;
        public void showMenu()
        {
            Console.WriteLine("\n\nOptions Menu:");
            Console.WriteLine("1-Make matrix");
            Console.WriteLine("2-Show values");
            Console.WriteLine("3-Count rows with average less than a given value");
            Console.WriteLine("4-Exit to main menu");


            string options = Console.ReadLine().ToString();
            switch (options)
            {
                case "1":
                    matrix = new double[0][];
                    bool keepGoing = true;
                    int rows = 1;
                    
                    while (keepGoing)
                    {
                        Console.WriteLine("Enter double number sequence separated using space.\nEnter '-' to stop typing. Every row should have the same size and matrix should be rectangle");

                        string input = Console.ReadLine().ToString();

                        if (input == "-")
                        {
                            keepGoing = false;
                        }
                        else
                        {
                            double[] row = input.Split(' ').Select(double.Parse).ToArray();
                            if (row.Length != rowLenght && rowLenght != 0)
                            {
                                Console.WriteLine("Not the same row lenght");
                                showMenu();
                            }

                            rowLenght = row.Length;
                            Array.Resize(ref matrix, matrix.Length + 1);
                            matrix[rows - 1] = row;
                            rows++;
                        }
                    }

                    showMenu();
                    break;
                case "2":
                    for (int i = 0; i < matrix.Length; i++)
                    {
                        for (int j = 0; j < matrix[0].Length; j++)
                        {
                            Console.Write(matrix[i][j]);
                        }
                        Console.Write("\n");
                    }

                    showMenu();
                    break;
                case "3":
                    Console.WriteLine("Enter a value to compare:");
                    double value = double.Parse(Console.ReadLine());

                    int count = 0;
                    for (int i = 0; i < matrix.Length; i++)
                    {
                        double sum = 0;
                        for (int j = 0; j < matrix[0].Length; j++)
                        {
                            sum += matrix[i][j];
                        }
                        double average = sum / matrix[0].Length;
                        if (average < value)
                        {
                            count++;
                        }
                    }

                    Console.WriteLine("The number of rows with average less than "+ value + " is " + count);
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