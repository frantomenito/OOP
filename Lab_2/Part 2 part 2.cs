using System;
using System.Linq;
using System.Threading;

namespace Lab_2
{
    public class Part_2_part_2
    { 
        double[][] matrix = new double[0][];
        private int rowLenght = 0;
        public void showMenu()
        {
            Console.WriteLine("\n\nOptions Menu:");
            Console.WriteLine("1-Make matrix");
            Console.WriteLine("2-Show values");
            Console.WriteLine("3-Convert matrix to triangular form");
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
                            Console.Write(" ");
                            
                        }
                        Console.Write("\n");
                    }

                    showMenu();
                    break;
                case "3":
                    if (matrix.Length != matrix[0].Length)
                    {
                        Console.WriteLine("Matrix is not squared. Redo matrix!");
                        showMenu();
                        break;
                    }
                    Console.WriteLine("Converting matrix to triangular form...");

                    for (int i = 0; i < matrix[0].Length - 1; i++)
                    {
                        for (int j = i+1; j < matrix.Length; j++)
                        {
                            if (matrix[i][i] == 0)
                            {
                                swapRow(matrix, j, i);
                            } else
                            {
                                double factor = matrix[j][i] / matrix[i][i];
                                SubtractRow(matrix, j, i, factor);
                            }
                        }
                    }

                    Console.WriteLine("Done!");
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
        void SubtractRow(double[][] matrix, int row, int fromRow, double factor)
        {
            for (int i = 0; i < matrix[row].Length; i++)
            {
                matrix[row][i] -= factor * matrix[fromRow][i];
            }
        }

        void swapRow(double[][] matrix, int row1, int row2)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                double temp = matrix[row1][i];
                matrix[row1][i] = matrix[row2][i];
                matrix[row2][i] = temp;
            }
        }
    }
}