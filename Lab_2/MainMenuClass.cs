using System;

namespace Lab_2
{
    public class MainMenuClass
    {
        public static void Main(string[] args)
        {
            showMenu();
        }

        static void showMenu()
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1-Part 1 Part 1");
            Console.WriteLine("2-Part 1 Part 2");
            Console.WriteLine("3-Part 1 Part 3");
            Console.WriteLine("4-Part 2 Part 1");
            Console.WriteLine("5-Part 2 Part 2");
            Console.WriteLine("6-Part 2 Part 3");


            string options = Console.ReadLine().ToString();
            switch (options)
            {
                case "1":
                    Part_1_part_1 prt = new Part_1_part_1();

                    prt.showMenu();

                    showMenu();
                    break;
                case "2":
                    Part_1_part_2 prt2 = new Part_1_part_2();

                    prt2.startMenu();

                    showMenu();
                    break;

                case "3":
                    Part_1_part_3 prt3 = new Part_1_part_3();

                    prt3.showMenu();
                    
                    showMenu();
                    break;
                
                case "4":
                    Part_2_part_1 prt21 = new Part_2_part_1();

                    prt21.showMenu();
                    
                    showMenu();
                    break;
                case "5":
                    Part_2_part_2 prt22 = new Part_2_part_2();

                    prt22.showMenu();
                    
                    showMenu();
                    break;
                case "6":
                    Part_2_part_3 prt23 = new Part_2_part_3();

                    prt23.showMenu();
                    
                    showMenu();
                    break;
                default:
                    Console.WriteLine("Wrong choice!");
                    showMenu();
                    break;
            }
        }
    }
}