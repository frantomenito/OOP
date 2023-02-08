using System;

namespace OOPNew1
{
    internal class Program
    {
        private static bool adding = false;
        private static bool ifOrdered = false;
        private static string currentAction = "";
        
        private static TArray currentArray = new TArray();
        private static TArray previousArray = new TArray();

        private static TArray currentArrayO = new TOderedArray();
        private static TArray previousArrayO = new TOderedArray();
        public static void Main(string[] args)
        {
            showMenu();
        }
        
        static void showMenu()
        {
            Console.WriteLine("\n\nOptions Menu:");
                if (adding)
                {
                    Console.WriteLine("---Adding---");
                }

                Console.WriteLine("1-Add value");
                Console.WriteLine("2-Show smallest value");
                Console.WriteLine("3-Show biggest value");
                Console.WriteLine("4-Show Sum");
                Console.WriteLine("5-Print Values");
                if (ifOrdered)
                {
                    Console.WriteLine("6-Change to TArrray");
                }
                if (!ifOrdered)
                {
                    Console.WriteLine("6-Sort");
                    Console.WriteLine("7-Change to TOderedArrray");
                }

                if (ifOrdered)
                {
                    Console.WriteLine("+ Add array");
                    Console.WriteLine("++ Add element");
                    Console.WriteLine("- Substract array");
                    Console.WriteLine("-- Substract element");
                }
                else
                {
                    Console.WriteLine("+ Add array");
                    Console.WriteLine("- Substract array");
                }

                Console.WriteLine("* Multiply");
                if (adding)
                {
                    Console.WriteLine("= Get result");
                }


                string options = Console.ReadLine().ToString();
                switch (options)
                {
                    case "1":
                        Console.WriteLine("Enter integer number:");
                        int newElement = int.Parse(Console.ReadLine().ToString());

                        if (ifOrdered)
                        {
                            currentArrayO.append(newElement);
                        }
                        else
                        {
                            currentArray.append(newElement);
                        }
                        showMenu();
                        break;
                    case "2":
                        if (ifOrdered)
                        {
                            Console.WriteLine("Smallest number is: " + currentArrayO.smallestValue());
                        }
                        else
                        {
                            Console.WriteLine("Smallest number is: " + currentArray.smallestValue());
                        }
                        showMenu();

                        break;
                    case "3":
                        if (ifOrdered)
                        {
                            Console.WriteLine("Biggest number is: " + currentArrayO.biggestValue());
                        }
                        else
                        {
                            Console.WriteLine("Biggest number is: " + currentArray.biggestValue());
                        }
                        showMenu();
                        break;
                    case "4":
                        if (ifOrdered)
                        {
                            Console.WriteLine("Sum is: " + currentArrayO.biggestValue());
                        }
                        else
                        {
                            Console.WriteLine("Sum is: " + currentArray.biggestValue());
                        }                        
                        showMenu();
                        break;
                    case "5":
                        if (ifOrdered)
                        {
                            currentArrayO.printValues();
                        }
                        else
                        {
                            currentArray.printValues();
                        }     
                        showMenu();
                        break;
                    case "6":
                        if (ifOrdered)
                        { 
                            ifOrdered = false;
                            currentArray = currentArrayO;
                            showMenu();
                        }
                        else
                        {
                            currentArray.sort();
                            Console.WriteLine("\nSorted!");
                            showMenu();

                        }
                        break;
                    case "7":
                        if (!ifOrdered)
                        {
                            ifOrdered = true;
                            currentArrayO = new TOderedArray(currentArray);
                            showMenu();
                        }
                        else
                        {
                            Console.WriteLine("Wrong choice!");
                            showMenu();
                        }
                        break;
                    case "+":
                        currentAction = "+";
                        
                        if (!ifOrdered)
                        {
                            previousArray = currentArray;
                            currentArray = new TArray();
                        }
                        else
                        {
                            previousArrayO = currentArrayO;
                            currentArrayO = new TArray();
                        }
                        
                        adding = true;
                        showMenu();
                        break;
                    case "++":
                        Console.WriteLine("Enter integer element");
                        int element = int.Parse(Console.ReadLine().ToString());

                        //currentArrayO = currentArrayO + element;
                        Console.WriteLine("\nMultiplied!");

                        showMenu();
                        break;
                    case "-":
                        currentAction = "-";
                        if (!ifOrdered)
                        {
                            previousArray = currentArray;
                            currentArray = new TArray();
                        }
                        else
                        {
                            previousArrayO = currentArrayO;
                            currentArrayO = new TArray();
                        }
                        adding = true;

                        showMenu();
                        break;
                    case "*":
                        Console.WriteLine("Enter integer multiplier");
                        int multiplier = int.Parse(Console.ReadLine().ToString());
                        
                        currentArray = currentArray * multiplier;
                        Console.WriteLine("\nMultiplied!");

                        showMenu();
                        break;
                    case "=":
                        if (!adding)
                        {
                            Console.WriteLine("Wrong choice!");
                            showMenu();
                            return;
                        }
                        
                        if (!ifOrdered)
                        {
                            switch (currentAction)
                            {
                                case "+":
                                    currentArray = previousArray + currentArray;
                                    break;
                                case "-":
                                    currentArray = previousArray - currentArray;
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (currentAction)
                            {
                                case "+":
                                    currentArrayO = previousArrayO + currentArrayO;
                                    break;
                                case "-":
                                    currentArrayO = previousArrayO - currentArrayO;
                                    break;
                                default:
                                    break;
                            }
                            
                        }

                        adding = false;

                        showMenu();
                        break;
                            default:
                            Console.WriteLine("Wrong choice!");
                            showMenu();
                            break;
                        }
            }
    }

    internal class TArray
    {
        protected int[] array;
        protected int count;
        
        public TArray()
        {
            count = 0;
            array = new int[]{};
        }
        
        public TArray(int[] array, int count)
        {
            this.array = array;
            this.count = count;
        }
        
        public TArray(TArray copyFrom)
        {
            array = copyFrom.array;
            count = copyFrom.count;
        }

        public int valueAt(int index)
        {
            return array[index];
        }

        public virtual void append(int newValue)
        {
            Array.Resize(ref array, count + 1);
            array[count] = newValue;
            count++;
            
        }
        public int biggestValue()
        {
            int biggestValue = Int32.MinValue;

            for (int i = 0; i < count; i++)
            {
                biggestValue = Math.Max(biggestValue, array[i]);
            }

            return biggestValue;
        }
        
        public int smallestValue()
        {
            int smallestValue = Int32.MaxValue;

            for (int i = 0; i < count; i++)
            {
                smallestValue = Math.Min(smallestValue, array[i]);
            }

            return smallestValue;
        }

        public int sum()
        {
            int sum = 0;
            
            for (int i = 0; i < count; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        public void sort()
        {
            Array.Sort(array);
        }

        public void printValues()
        {
            Console.WriteLine("Array items:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(array[i]);
            }
        }


        public static TArray operator -(TArray a, TArray b)
        {
            TArray returnArray = new TArray();
            for (int i = 0; i < a.count; i++)
            {
                int valueA = a.valueAt(i);
                
                bool good = true;
                for (int j = 0; j < b.count; j++)
                {
                    
                    good = valueA != b.valueAt(j) && good;
                }
                
                if (good)
                {
                    returnArray.append(valueA);
                }
            }
            
            return returnArray;
        }

        public static TArray operator *(TArray a, int b)
        {
            TArray returnArray = new TArray();
            for (int i = 0; i < a.count; i++)
            {
                returnArray.append(a.valueAt(i) * b);
            }

            return returnArray;
        }
            

        public static TArray operator +(TArray a, TArray b)
        {
            TArray returnArray = new TArray(a);
            for (int i = 0; i < b.count; i++)
            {
                returnArray.append(b.valueAt(i));
            }
            
            return returnArray;
        }
    }

   internal class TOderedArray : TArray
   {
       public static TOderedArray operator +(TOderedArray a, int b)
       {
           TOderedArray returnArray = new TOderedArray(a);
           returnArray.append(b);
           
           returnArray.sort();
           return returnArray;
       }
       
       public static TOderedArray operator -(TOderedArray a, int b)
       {
           TOderedArray returnArray = new TOderedArray();
           for (int i = 0; i < a.count; i++)
           {
               int valueA = a.valueAt(i);
                
               bool good = valueA != b;

               if (good)
               {
                   returnArray.append(valueA);
               }
           }
           returnArray.sort();
           return returnArray;
       }
       
       public static TOderedArray operator -(TOderedArray a, TOderedArray b)
       {
           TOderedArray returnArray = new TOderedArray();
           for (int i = 0; i < a.count; i++)
           {
               int valueA = a.valueAt(i);
                
               bool good = true;
               for (int j = 0; j < b.count; j++)
               {
                    
                   good = valueA != b.valueAt(j) && good;
               }
                
               if (good)
               {
                   returnArray.append(valueA);
               }
           }
            
           return returnArray;
       }
    
       public static TOderedArray operator +(TOderedArray a, TOderedArray b)
       {
           TOderedArray returnArray = new TOderedArray(a);
           for (int i = 0; i < b.count; i++)
           {
               returnArray.append(b.valueAt(i));
           }
           
           returnArray.sort();
            
           return returnArray;
       }
       
       public override void append(int newValue)
       {
           Array.Resize(ref array, count + 1);
           array[count] = newValue;
           count++;

           sort();
       }       
       public TOderedArray(): base()
       {
       }
        
       public TOderedArray(int[] array, int count): base(array, count)
       {
           sort();
       }
        
       public TOderedArray(TArray copyFrom): base(copyFrom)
       {
           sort();
       }
       
       public TOderedArray(TOderedArray copyFrom): base(copyFrom)
       {
           array = copyFrom.array;
           count = copyFrom.count;
       }
   }
}