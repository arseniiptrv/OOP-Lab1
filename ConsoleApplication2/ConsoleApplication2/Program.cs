using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // ООП. Лабораторна робота 2
            // Завдання №3
            /*int x = 0;                             // счетчик, используется для обращения к эл-ту массива с индексом x в цикле
            int a = 1;                             // будет хранить введенное значение, распарсенное в число
            int[] array = new int[50];            // массив, в который буду сохранять введеные значения            
            Console.WriteLine("Будь ласка, введіть цілі числа. Для закінчення введення введіть 0");

    
            while (a != 0)
            {
                string input = Console.ReadLine();
                
                if (int.TryParse(input, out a))
                {
                    array[x] = a;
                    x++;
                }
                else
                {
                                // TryParse возвращает 0 если не удалось пр-е, поэтому возвращаем значение a (любое отличное от 0) 
                    Console.WriteLine("Ви ввели помилкове значення. Будь ласка, спробуйте ще раз: ");
                    a = 1;
                }                       
            }
            
            int pairNumb = 0;                  // кількість парних чисел
            int oddNumb = 0;                   // кількість непарних чисел
            int posNumb = 0;                   // кількість додатних чисел
            int negNumb = 0;                   // кількість від'ємних чисел
                     
            Numbers(ref pairNumb, ref oddNumb, ref posNumb, ref negNumb, array);*/          // виклик методу Numbers
            
            
            
            
            
            // вызов метода Fact - факториал числа (через рекурсию, тест):
            /*Console.Write("Для обчислення факторіалу введіть значення: ");
            var factInput = Console.ReadLine();
            int factValue;
            while (!int.TryParse(factInput, out factValue))
            {
                Console.WriteLine("Ви ввели помилкове значення. Будь ласка, спробуйте ще раз: ");
                factInput = Console.ReadLine();             
            }

            var factResult = Fact(factValue);
            Console.WriteLine($"Значення факторіалу числа {factValue} дорівнює {factResult}");*/
            
            
            
            
            // вызов метода Fib - Фибоначчи (через рекурсию, тест):
            /*Console.Write("Для обчислення фібоначчі введіть номер послідовності: ");
            var fibInput = Console.ReadLine();
            int fibValue;
            while (!int.TryParse(fibInput, out fibValue))
            {
                Console.WriteLine("Ви ввели помилкове значення. Будь ласка, спробуйте ще раз: ");
                fibInput = Console.ReadLine();
            }
            
            var fibResult = Fib(fibValue);
            Console.WriteLine($"Значення фібоначчі числа {fibValue} дорівнює {fibResult}");*/
            
            double x1 = Math.Sin()
        }

        
        
        
        
        public static void Numbers(ref int pairNumb, ref int oddNumb, ref int posNumb, ref int negNumb, params int[] numbs)
        {
            foreach (int i in numbs)
            {
                int firstCheck = 0;     // переменная для сравнения с остатком от деления
                if (i > 0)
                {
                    posNumb += 1;
                    firstCheck == (i % 2 == 0) ? pairNumb += 1 : oddNumb += 1;                                 
                }               
                else
                {
                    negNumb += 1;
                    firstCheck = (i % 2 == 0) ? pairNumb += 1 : oddNumb += 1;
                }                                        
            }
            
            Console.WriteLine($"Кількість парних чисел: {pairNumb}");
            Console.WriteLine($"Кількість непарних чисел: {oddNumb}");
            Console.WriteLine($"Кількість додатних чисел: {posNumb}");
            Console.WriteLine($"Кількість від'ємних чисел: {negNumb}");
        }


        
        
        
        
        // метод Fact - факториал числа (через рекурсию, тест):
        static int Fact(int z)
        {
            if (z == 0)
                return 1;
            if (z == 1)
                return 1;
            return z * Fact(z - 2);
        }

        
        
        // метод Fib - Фибоначчи (через рекурсию, тест):
        static int Fib(int y)
        {
            if (y == 0)              
                return 0;
            if (y == 1)
                return 1; 
            
            return Fib(y - 2) + Fib(y - 1);            
        }
    }
}