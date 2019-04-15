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


         


            // ООП. Лабораторна робота 2
            // Завдання №1. Введення значень для всіх рівнянь (№№ 1-7):
            
            Console.WriteLine("Введите значение x: ");
            var xInput = Console.ReadLine();                      // юзер вводит значение х на консоли 
            double x;                                             // переменная для хранения значения х
            while (!double.TryParse(xInput, out x))
            {
                Console.WriteLine("Вы ввели некорректное значение x, попробуйте ещё раз: ");
                xInput = Console.ReadLine();
            }
            
            
            Console.WriteLine("Введите значение y: ");
            var yInput = Console.ReadLine();                      // юзер вводит значение y на консоли 
            double y;                                             // переменная для хранения значения y 
            while (!double.TryParse(yInput, out y))
            {
                Console.WriteLine("Вы ввели некорректное значение y, попробуйте ещё раз: ");
                yInput = Console.ReadLine();
            }
            
            
            Console.WriteLine("Введите значение z: ");
            var zInput = Console.ReadLine();                      // юзер вводит значение y на консоли 
            double z;                                             // переменная для хранения значения y 
            while (!double.TryParse(zInput, out z))
            {
                Console.WriteLine("Вы ввели некорректное значение z, попробуйте ещё раз: ");
                zInput = Console.ReadLine();
            }

            var equationOne = EquationOne(x, y, z);
            var equationTwo = EquationTwo(x, y, z);
            var equationThree = EquationThree(x, y, z);
            var equationFour = EquationFour(x, y, z);
            var equationFive = EquationFive(x, y, z);
            var equationSix = EquationSix(x, y, z);
            var equationSeven = EquationSeven(x, y, z);

            Console.WriteLine($"Значение уравнения 1 равно {equationOne}");
            Console.WriteLine($"Значение уравнения 2 равно {equationTwo}");
            Console.WriteLine($"Значение уравнения 3 равно {equationThree}");
            Console.WriteLine($"Значение уравнения 4 равно {equationFour}");
            Console.WriteLine($"Значение уравнения 5 равно {equationFive}");
            Console.WriteLine($"Значение уравнения 6 равно {equationSix}");
            Console.WriteLine($"Значение уравнения 7 равно {equationSeven}");

            
            
            
            
            
            
            // Завдання №2: Виклик методу discriminant для обчислення коренів квадратного рівняння

            // Оголошую змінні х1, х2 та D, у які буде передано значення квадратних коренів
            // та дискримінанта після виклику метода discriminant
            /*int x1;
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
            discriminant(a, b, c, out x1, out x2, out D);*/
        }


        
        
        
        
        // метод для рівняння №1 з завдання №1: 
        static double EquationOne(double x, double y, double z)
        {
            var yPower = 2 - z;
            var forSin = Math.Pow(y, yPower);
            var leftSide = (2 * Math.Cos(x * x) - 0.5) / (0.5 + Math.Sin(forSin));
            var rightSide = (z * z) / (7 - z / 3);

            return Math.Round(leftSide + rightSide, 3);
        }
        
        
        // метод для рівняння №2 з завдання №1: 
        static double EquationTwo(double x, double y, double z)
        {
            var xyPower = Math.Pow(3 + (x - y), 1 / 3);
            var leftSide = xyPower / (x * x + z * z * z + 4);
            var rightSide = Math.Tan(z);
            return Math.Round(leftSide - rightSide, 3);
        }
        
        
        // метод для рівняння №3 з завдання №1: 
        static double EquationThree(double x, double y, double z)
        {
            var znamenatel = Math.Abs(z - 2 * x / (1 + x * x * y * y));
            var xPower = Math.Pow(x, Math.Abs(y));  
            var result = (1 + Math.Sin(x + y)) / znamenatel * xPower + Math.Tan(1 / z);
            return Math.Round(result, 3);
        }
        
        
        // метод для рівняння №4 з завдання №1: 
        static double EquationFour(double x, double y, double z)
        {
            var yPower = 1 + 2 * Math.Sin(z);
            var xyPow = Math.Pow(Math.Cos(x) - Math.Sin(y), yPower);
            var result = xyPow * (z + z * z / 2 + z * z * z / 3 + z * z * z * z / 4);
            return Math.Round(result, 3);
        }
             
        
        // метод для рівняння №5 з завдання №1: 
        static double EquationFive(double x, double y, double z)
        {
            var xAbs = Math.Abs(x);
            var yPower = -Math.Sqrt(xAbs);
            var leftSide = Math.Sin(Math.Pow(y, yPower)) * (z - x / y);
            var rightSide = Math.Sin(Math.Cos(z));
            return Math.Round(leftSide + rightSide, 3);
        }        
        
        
        // метод для рівняння №6 з завдання №1:
        static double EquationSix(double x, double y, double z)
        {
            var leftSide = Math.Sqrt(10 * (Math.Pow(x, 1 / 3) + Math.Pow(x, y + 2)));
            var rightSide = Math.Sin(z - Math.Abs(x + y));
            return Math.Round(rightSide * leftSide, 3);
        }
        
        
        // метод для рівняння №7 з завдання №1:
        static double EquationSeven(double x, double y, double z)
        {
            var rightSide = z / 4 * Math.Sin(y) * (4 * Math.Abs(z - x) - 5) / (z * (x - y) + z * z);
            return Math.Round(5 * Math.Cos(x) - rightSide, 3);
        }
        
        
        
        
        
        
        
        
        
        // метод дискримінант, завдання №2:
        /*static void discriminant(int a, int b, int c, out int x1, out int x2, out int D)
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
        }*/    
    }
}