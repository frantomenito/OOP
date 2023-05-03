
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string filename = "textfile.txt";

            bool fileExists = File.Exists(filename);

            if (!fileExists)
            {
                Console.WriteLine("Файл не існує");
                return;
            }
            
            char[] charArray = File.ReadAllText(filename).ToCharArray();
            if (charArray.Length == 0)
            {
                Console.WriteLine("Файл пустий");
                return;
            }
            
            int count = CountUpperCaseLetters(charArray);
            Console.WriteLine("Кількість прописних літер у файлі використовуючи масив: " + count);

            List<char> charList = new List<char>(charArray);
            count = CountUpperCaseLetters(charList);
            Console.WriteLine("Кількість прописних літер у файлі використовуючи список: " + count);
        }
        
        static int CountUpperCaseLetters(char[] array)
        {
            int count = 0;
            foreach (char c in array)
            {
                if (Char.IsUpper(c))
                {
                    count++;
                }
            }
            return count;
        }
        
        static int CountUpperCaseLetters(List<char> list)
        {
            int count = 0;
            foreach (char c in list)
            {
                if (Char.IsUpper(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}