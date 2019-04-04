using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // ООП. Лабораторна робота 2
            // Завдання №3

            int[] array = {};                    // масив, який буде зберігати введені значення
            Console.WriteLine("Будь ласка, введіть цілі числа. Для закінчення введення введіть 0");

            string input;
            int a;                                      // в пер-й будет храниться введенное значение, распарсенное в число

            do
            {
                input = Console.ReadLine();
                int x = 0;                                  // счетчик для массива
                if (int.TryParse(input, out a))
                {
                    array[x] = a;                             // добавляю элемент в массив
                    x++;                                    // увеличиваю счетчик на 1
                }
                else
                {
                    Console.WriteLine("Ви ввели помилкове значення. Будь ласка, спробуйте ще раз: ");
                    //input = Console.ReadLine();
                }
            } 
            while (a == 0);

            
            int pairNumb = 0;                  // кількість парних чисел
            int oddNumb = 0;                   // кількість непарних чисел
            int posNumb = 0;                   // кількість додатних чисел
            int negNumb = 0;                   // кількість від'ємних чисел
            
            //Numbers(ref pairNumb, ref oddNumb, ref posNumb, ref negNumb, array);          // виклик методу Numbers
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