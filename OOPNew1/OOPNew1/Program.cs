using System;

namespace OOPNew1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TArray array1 = new TArray();
            
            array1.append(5);
            array1.append(23);
            array1.append(3);
            
            array1.printValues();
            Console.WriteLine(array1.sum() + " - Sum"); 
            
            TArray array2 = new TArray(array1);

            array2.sort();
            array2.printValues();
            
            Console.WriteLine("Biggest: " + array2.biggestValue());
            Console.WriteLine("Smallest: " + array2.smallestValue());
            
            TArray array3 = array2 * 5;;
            array3.printValues();
            
            array3 = array2 + array2 * 2 - array1;
            array3.printValues();

            array3 = array2 + array1 * 3;
            array3.printValues();
            
            TOderedArray array4 = new TOderedArray(new int[]{5,7,8,1}, 4);;

            array4.printValues();
            TOderedArray array5 = array4 + 3 - 1;

            array5.printValues();

        }
    }

   internal class TArray
    {
        public int[] array;
        public int count;
        
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

        public int[] values()
        {
            return array;
        }

        public int valueAt(int index)
        {
            return array[index];
        }

        public void append(int newValue)
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
       
       public void append(int newValue)
       {
           Array.Resize(ref array, count + 1);
           array[count] = newValue;
           count++;
           
           sort();
       }       
       public TOderedArray()
       {
           count = 0;
           array = new int[]{};
       }
        
       public TOderedArray(int[] array, int count)
       {
           this.array = array;
           this.count = count;
           
           sort();
       }
        
       public TOderedArray(TArray copyFrom)
       {
           array = copyFrom.array;
           count = copyFrom.count;
           
           sort();
       }
   }
}