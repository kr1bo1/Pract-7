using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 задание

            //создание массивов
            Console.WriteLine("Task 1");
            int[] mas1 = { 5, 2, 8, 1, 4 };
            int[] mas2 = { 7, 3, 6, 9 };

            Console.WriteLine("\nArray 1: " + string.Join(", ", mas1));
            Console.WriteLine("Array 2: " + string.Join(", ", mas2));

            // Сортировка массивов
            SortAscending(mas1);
            SortDescending(mas2);

            Console.WriteLine("Sorted array 1(ascending): " + string.Join(", ", mas1)); //по возрастанию
            Console.WriteLine("Sorted array 2 (descending order): " + string.Join(", ", mas2)); //по убыванию

            // Объединение массива
            int[] comArray = CombineArrays(mas1, mas2);
            Console.WriteLine("Combined array: " + string.Join(", ", comArray));

            Console.WriteLine("\nTask 2");
            Console.Write("\nEnter an integer n: ");
            int n;

            // Проверяем, является ли введенное значение целым числом
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Please enter a valid integer: ");
            }

            int result = CalculateAbsoluteDifference(n);
            Console.WriteLine("Result: " + result); 
        }
        // Метод сортировки массива по возрастанию
        static void SortAscending(int[] mas)
        {
            Array.Sort(mas);
        }

        // Метод сортировки массива по убыванию
        static void SortDescending(int[] mas)
        {
            Array.Sort(mas);
            Array.Reverse(mas);
        }

        // Метод объединения двух массивов в один
        static int[] CombineArrays(int[] mas1, int[] mas2)
        {
            int[] com = new int[mas1.Length + mas2.Length];
            Array.Copy(mas1, com, mas1.Length);
            Array.Copy(mas2, 0, com, mas1.Length, mas2.Length);
            return com;
        }

        //2 задания

        static int CalculateAbsoluteDifference(int n)
        {
            int absoluteDifference = Math.Abs(n - 123);

            // Если n больше 123, возвращаем тройную абсолютную разность
            if (n > 123)
            {
                return 3 * absoluteDifference;
            }

            return absoluteDifference;
        }
    }
}
