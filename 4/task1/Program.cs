using System;
using static System.Math;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.Write("Введите x: ");
                int x = Convert.ToInt32(Console.ReadLine());
                double y = Atan(x) / (x - 3);
                if (Double.IsInfinity(y))
                {
                    Console.WriteLine("Бесконечность");
                }
                else
                {
                    Console.WriteLine(y);
                }

                double y1 = Log10(x) + (5 * x - 3) / (x - 1);
                if (Double.IsInfinity(y1))
                {
                    Console.WriteLine("Бесконечность");
                }
                else
                {
                    Console.WriteLine(y1);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Нужно ввести число");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль недопустимо!!!");
            }
            

            
        }
    }
}
