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
            
            
            // ООП. Лабораторна робота 2
            // Завдання з рівняння №2
            /*Console.WriteLine("Введіть дійсне число x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(x.GetType().ToString());
            if (x.GetType().ToString() != System.Double)
            {
                Console.WriteLine("Помилка введення значення x. Будь ласка, повторіть введення значення ще раз: ");
                x = Convert.ToDouble(Console.ReadLine());
            }
            
                        
            Console.WriteLine("Введіть дійсне число y: ");
            double y = Convert.ToDouble(Console.ReadLine());           
            Console.WriteLine("Введіть дійсне число z: ");
            double z = Convert.ToDouble(Console.ReadLine());            
            Console.WriteLine(expr2(x, y, z));*/
            
            
            
            // ООП. Лабораторна робота 2
            // Завдання №2: Виклик методу discriminant для обчислення коренів квадратного рівняння
            /*int x1;
            int x2;
            int D;

     
            Console.WriteLine("Введіть ціле значення a: ");
            int a = Convert.ToInt32(Console.ReadKey());
            while (a.GetType().ToString() != System.Int32)
            {
                Console.WriteLine("Ви ввели помилкове значення a. Будь ласка, спробуйте ще раз: ");
                a = Convert.ToInt32(Console.ReadKey());
            }
            
            
            Console.WriteLine("Введіть ціле значення b: ");
            int b = Convert.ToInt32(Console.ReadKey());
            while (b.GetType().ToString() != System.Int32)
            {
                Console.WriteLine("Ви ввели помилкове значення b. Будь ласка, спробуйте ще раз: ");
                b = Convert.ToInt32(Console.ReadKey());
            }
            
            Console.WriteLine("Введіть ціле значення c: ");
            int c = Convert.ToInt32(Console.ReadKey());
            while (c.GetType().ToString() != System.Int32)
            {
                Console.WriteLine("Ви ввели помилкове значення c. Будь ласка, спробуйте ще раз: ");
                c = Convert.ToInt32(Console.ReadKey());
            }*/


            int x1;
            int x2;
            int D;
            discriminant(2, 6, 4, out x1, out x2, out D);
            //discriminant(3, 5, 3, out x1, out x2, out D);
            //discriminant(3, 6, 3, out x1, out x2, out D);
        }

        
        
        /*static double expr2(double x, double y, double z)
        {
            double first = Math.Pow(3 + (x - y), 1.0 / 3.0);
            double second = (x * x) + (z * z * z) + 4;
            double third = Math.Tan(z);

            //double res = first / second;
            return first / second - third;
        }*/

        

        static void discriminant(int a, int b, int c, out int x1, out int x2, out int D)
        {
            D = b * b - 4 * a * c;          // змінна D - містить значення дискримінанту
            x1 = 0;                                                         // змінна х1 - містить значення квадратного кореня №1
            x2 = 0;                                                         // змінна х2 - містить значення квадратного кореня №2
            
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
                // x1 и x2 залишаються у значенні 0. Яке значення вказати? Чи вийти через return?
                return;
            }
            
            Console.WriteLine($"Значення змінної D: {D}");           //виводжу значення D для перевірки
            Console.WriteLine($"Значення змінної x1: {x1}");
            Console.WriteLine($"Значення змінної x2: {x2}");
        }
        
        
    }
}