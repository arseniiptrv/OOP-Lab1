using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo) 
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            
            //Console.OutputEncoding = Encoding.Unicode;
            //Console.InputEncoding = Encoding.Unicode;
           
            
            
            
            
            
            
            // Some test task
            /*int[] arr = new int[] {1, 3, 5, 7, 9};
            arr[2] = 15;
            arr[5] = 25;
            foreach (int q in arr)
            {
                Console.WriteLine(q);
            }

            for (int e = 0; e < arr.Length; e++)
            {
                Console.WriteLine(arr[e]);
            }*/
            
            
            
            
            
            
            
            
            // ООП. Лабораторна робота 2
            // Завдання №2: Виклик методу discriminant для обчислення коренів квадратного рівняння

            // Оголошую змінні х1, х2 та D, у які буде передано значення квадратних коренів
            // та дискримінанта після виклику метода discriminant
            int x1;
            int x2;
            int D;
            
            // Запрошую користувача ввести ціле значення а. Є перевірка на коректність введення
            Console.WriteLine("Введіть ціле значення a: ");
            var inputA = Console.ReadLine();
            int a;
            while (!int.TryParse(inputA, out a))
            {
                Console.WriteLine("Ви ввели не число. Будь ласка, спробуйте ще раз: ");
                inputA = Console.ReadLine();
            }
            Console.WriteLine("значення a: " + a);
            Console.WriteLine("тип a: " + a.GetType().ToString());
          
            
            // Запрошую користувача ввести ціле значення b. Є перевірка на коректність введення
            Console.WriteLine("Введіть ціле значення b: ");
            var inputB = Console.ReadLine();
            int b;
            while (!int.TryParse(inputB, out b))
            {
                Console.WriteLine("Ви ввели не число. Будь ласка, спробуйте ще раз: ");
                inputB = Console.ReadLine();
            }
            Console.WriteLine("значення b: " + b);
            Console.WriteLine("тип b: " + b.GetType().ToString());

            
            // Запрошую користувача ввести ціле значення c. Є перевірка на коректність введення
            Console.WriteLine("Введіть ціле значення c: ");
            var inputC = Console.ReadLine();
            int c;
            while (!int.TryParse(inputC, out c))
            {
                Console.WriteLine("Ви ввели не число. Будь ласка, спробуйте ще раз: ");
                inputC = Console.ReadLine();
            }
            Console.WriteLine("значення c: " + c);
            Console.WriteLine("тип c: " + c.GetType().ToString());

            
            
            // Викликаю метод дискримінант
            discriminant(a, b, c, out x1, out x2, out D);
        }

        
       

        static void discriminant(int a, int b, int c, out int x1, out int x2, out int D)
        {
            D = b * b - 4 * a * c;                           // змінна D - містить значення дискримінанту
            x1 = 0;                                          // змінна х1 - містить значення квадратного кореня №1
            x2 = 0;                                          // змінна х2 - містить значення квадратного кореня №2
            
            if (D > 0)
            {
                x1 = Convert.ToInt32((-b + Math.Sqrt(D)) / (2 * a));
                x2 = Convert.ToInt32((-b - Math.Sqrt(D)) / (2 * a));
            }
            else if (D == 0)
            {
                x1 = x2 = -b / (2 * a);
            }
            else if (D < 0)
            {
                Console.WriteLine($"Дискримінант має від'ємне значення {D}, квадратні корені обчислити неможливо");
                return;                     // x1 и x2 обчислити неможливо. Виходжу через з циклу через return
            }
            
            Console.WriteLine($"Значення змінної D: {D}");           //виводжу отримане значення дискримінанту
            Console.WriteLine($"Значення змінної x1: {x1}");         //виводжу отримане значення x1
            Console.WriteLine($"Значення змінної x2: {x2}");         //виводжу отримане значення x2
        }    
    }
}