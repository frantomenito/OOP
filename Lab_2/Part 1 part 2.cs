using System;
using System.Linq;
using System.Threading;

namespace Lab_2
{
    public class Part_1_part_2
    {
        static double[] vectora = new double[0];
        static double[] vectorb = new double[0];
        static double[] vectorc = new double[0];

        static int vectorSize = 0;

        public void startMenu()
        {
            Console.WriteLine("Enter vector size");
            vectorSize = int.Parse(Console.ReadLine().ToString());

            vectora = new double[vectorSize];
            vectorb = new double[vectorSize];
            vectorc = new double[vectorSize];

            showMenu();
        }

        public void showMenu()
        {
            Console.WriteLine("\n\nOptions Menu:");
            Console.WriteLine("1-Make vector a");
            Console.WriteLine("2-Make vector b");
            Console.WriteLine("3-Make vector c");
            Console.WriteLine("4-Show vectors values");
            Console.WriteLine("5-Do lab_2 part 1 part 2");
            Console.WriteLine("6-Exit to main menu");


            string options = Console.ReadLine().ToString();
            switch (options)
            {
                case "1":
                    Console.WriteLine(
                        "Enter double number sequence separated using space. Array size should be the same as selected.\n");

                    string input = Console.ReadLine().ToString();
                    double[] newArray = input.Split(' ').Select(double.Parse).ToArray();

                    if (newArray.Length == vectorSize)
                    {
                        vectora = newArray;
                    }
                    else
                    {
                        Thread.Sleep(new TimeSpan(0, 0, 1));
                        Console.WriteLine(
                            @"Unhandled Exception: System.FormatException: Input string was not in a correct format.
                        at System.Number.StringToNumber(String str, NumberStyles options, NumberBuffer& number, NumberFormatInfo info, Boolean parseDecimal)
                        at System.Number.ParseInt32(String s, NumberStyles style, NumberFormatInfo info)
                        at System.Linq.Enumerable.WhereSelectArrayIterator`2.MoveNext()
                        at System.Linq.Buffer`1..ctor(IEnumerable`1 source)
                        at System.Linq.Enumerable.ToArray[TSource](IEnumerable`1 source)
                        at Lab_2.Part_1_part_2.showMenu() in C:\Users\dmaks\RiderProjects\Lab_2\Lab_2\Part 1 part 2.cs:line 44
                        at Lab_2.Part_1_part_2.startMenu() in C:\Users\dmaks\RiderProjects\Lab_2\Lab_2\Part 1 part 2.cs:line 23
                        at Lab_2.MainMenuClass.showMenu() in C:\Users\dmaks\RiderProjects\Lab_2\Lab_2\MainMenuClass.cs:line 36
                        at Lab_2.MainMenuClass.Main(String[] args) in C:\Users\dmaks\RiderProjects\Lab_2\Lab_2\MainMenuClass.cs:line 9
                        ");
                        Thread.Sleep(new TimeSpan(0, 0, 2));
                        Console.WriteLine("Process finished with exit code -532,459,699");
                        Thread.Sleep(new TimeSpan(0, 0, 5));
                    }

                    showMenu();
                    break;
                case "2":
                    Console.WriteLine(
                        "Enter double number sequence separated using space. Array size should be the same as selected.\n");

                    string input2 = Console.ReadLine().ToString();
                    double[] newArray2 = input2.Split(' ').Select(double.Parse).ToArray();

                    if (newArray2.Length == vectorSize)
                    {
                        vectorb = newArray2;
                    }
                    else
                    {
                        Thread.Sleep(new TimeSpan(0, 0, 1));
                        Console.WriteLine(
                            @"Unhandled Exception: System.FormatException: Input string was not in a correct format.
                        at System.Number.StringToNumber(String str, NumberStyles options, NumberBuffer& number, NumberFormatInfo info, Boolean parseDecimal)
                        at System.Number.ParseInt32(String s, NumberStyles style, NumberFormatInfo info)
                        at System.Linq.Enumerable.WhereSelectArrayIterator`2.MoveNext()
                        at System.Linq.Buffer`1..ctor(IEnumerable`1 source)
                        at System.Linq.Enumerable.ToArray[TSource](IEnumerable`1 source)
                        at Lab_2.Part_1_part_2.showMenu() in C:\Users\dmaks\RiderProjects\Lab_2\Lab_2\Part 1 part 2.cs:line 44
                        at Lab_2.Part_1_part_2.startMenu() in C:\Users\dmaks\RiderProjects\Lab_2\Lab_2\Part 1 part 2.cs:line 23
                        at Lab_2.MainMenuClass.showMenu() in C:\Users\dmaks\RiderProjects\Lab_2\Lab_2\MainMenuClass.cs:line 36
                        at Lab_2.MainMenuClass.Main(String[] args) in C:\Users\dmaks\RiderProjects\Lab_2\Lab_2\MainMenuClass.cs:line 9
                        ");
                        Thread.Sleep(new TimeSpan(0, 0, 2));
                        Console.WriteLine("Process finished with exit code -532,459,699");
                        Thread.Sleep(new TimeSpan(0, 0, 5));
                    }

                    showMenu();
                    break;
                case "3":
                    Console.WriteLine(
                        "Enter double number sequence separated using space. Array size should be the same as selected.\n");

                    string input3 = Console.ReadLine().ToString();
                    double[] newArray3 = input3.Split(' ').Select(double.Parse).ToArray();

                    if (newArray3.Length == vectorSize)
                    {
                        vectorc = newArray3;
                    }
                    else
                    {
                        Console.WriteLine(newArray3.Length + vectorSize);
                        Thread.Sleep(new TimeSpan(0, 0, 1));
                        Console.WriteLine(
                            @"Unhandled Exception: System.FormatException: Input string was not in a correct format.
                        at System.Number.StringToNumber(String str, NumberStyles options, NumberBuffer& number, NumberFormatInfo info, Boolean parseDecimal)
                        at System.Number.ParseInt32(String s, NumberStyles style, NumberFormatInfo info)
                        at System.Linq.Enumerable.WhereSelectArrayIterator`2.MoveNext()
                        at System.Linq.Buffer`1..ctor(IEnumerable`1 source)
                        at System.Linq.Enumerable.ToArray[TSource](IEnumerable`1 source)
                        at Lab_2.Part_1_part_2.showMenu() in C:\Users\dmaks\RiderProjects\Lab_2\Lab_2\Part 1 part 2.cs:line 44
                        at Lab_2.Part_1_part_2.startMenu() in C:\Users\dmaks\RiderProjects\Lab_2\Lab_2\Part 1 part 2.cs:line 23
                        at Lab_2.MainMenuClass.showMenu() in C:\Users\dmaks\RiderProjects\Lab_2\Lab_2\MainMenuClass.cs:line 36
                        at Lab_2.MainMenuClass.Main(String[] args) in C:\Users\dmaks\RiderProjects\Lab_2\Lab_2\MainMenuClass.cs:line 9
                        ");
                        Thread.Sleep(new TimeSpan(0, 0, 2));
                        Console.WriteLine("Process finished with exit code -532,459,699");
                        Thread.Sleep(new TimeSpan(0, 0, 5));
                    }

                    showMenu();
                    break;
                case "4":
                    for (int i = 0; i < vectorSize; i++)
                    {
                        Console.WriteLine("[" + vectora[i] + " " + vectorb[i] + " " + vectorc[i] + "]");
                    }
                    showMenu();
                    break;
                case "5":
                    labStuff();
                    
                    Console.WriteLine("Done!");
                    
                    showMenu();
                    break;
                case "6":
                    break;
                default:
                    Console.WriteLine("Wrong choice!");
                    showMenu();
                    break;
            }
        }
        double ScalarProduct(double[] a, double[] b)
        {
            double result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                result += a[i] * b[i];
            }

            return result;
        }

        void labStuff()
        {
            double scalarProduct = ScalarProduct(vectora, vectorb);

            double[] result = new double[vectora.Length];
            for (int i = 0; i < vectora.Length; i++)
            {
                result[i] = 2 * scalarProduct * vectorc[i] - 3 * vectorb[i];
            }

            vectorc = result;
        }
        
    }
}