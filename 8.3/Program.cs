using System;

namespace _8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите 1-ое число");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите 2-ое число");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Выберите действие");
                string v = Convert.ToString(Console.ReadLine());
                if (v == "+")
                {
                    int c = a + b;
                    Console.WriteLine(c);
                }
                else if (v == "-")
                {
                    int c = a - b;
                    Console.WriteLine(c);
                }
                else if (v == "*")
                {
                    int c = a * b;
                    Console.WriteLine(c);
                }
                else if (v == "/")
                {
                    int c = a / b;
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine("Знак неверный");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Конец");
            }
        }
    }
}
