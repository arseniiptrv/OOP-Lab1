using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // ООП. Лабораторна робота 2
            // Завдання №3
            int x = 0;                             // счетчик, используется для обращения к эл-ту массива с индексом x в цикле
            int a = 1;                             // будет хранить введенное значение, распарсенное в число
            int[] array = new int[100];            // массив, в который буду сохранять введеные значения
            Console.WriteLine("Будь ласка, введіть цілі числа. Для закінчення введення введіть 0");

            while (a != 0)
            {
                var input = Console.ReadLine();
                int.TryParse(input, out a);
                
                while (!int.TryParse(input, out a))
                {
                    Console.WriteLine("Ви ввели помилкове значення. Будь ласка, спробуйте ще раз: ");
                    input = Console.ReadLine();
                }

                array[x] = a;
                x++;
            }
            
            int pairNumb = 0;                  // кількість парних чисел
            int oddNumb = 0;                   // кількість непарних чисел
            int posNumb = 0;                   // кількість додатних чисел
            int negNumb = 0;                   // кількість від'ємних чисел
            
            Numbers(ref pairNumb, ref oddNumb, ref posNumb, ref negNumb, array);          // виклик методу Numbers
        }

        
        
        public static void Numbers(ref int pairNumb, ref int oddNumb, ref int posNumb, ref int negNumb, params int[] numbs)
        {
            foreach (int i in numbs)
            {
                if (i > 0 && i%2 == 0)
                {
                    pairNumb += 1;
                    posNumb += 1;
                }
                else if (i > 0 && i%2 != 0)
                {
                    oddNumb += 1;
                    posNumb += 1;
                }
                else if (i < 0 && i%2 == 0)
                {
                    pairNumb += 1;
                    negNumb += 1;
                }
                else if (i < 0 && i%2 != 0)
                {
                    oddNumb += 1;
                    negNumb += 1;
                }
            }
            
            Console.WriteLine($"Кількість парних чисел: {pairNumb}");
            Console.WriteLine($"Кількість непарних чисел: {oddNumb}");
            Console.WriteLine($"Кількість додатних чисел: {posNumb}");
            Console.WriteLine($"Кількість від'ємних чисел: {negNumb}");
        }
    }
}