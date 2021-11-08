using System;

namespace _7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, u, r;
            try
            {
                u = Convert.ToInt32(Console.ReadLine());
                r = Convert.ToInt32(Console.ReadLine());
                i = u / r;
                Console.WriteLine(i);
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
            { Console.WriteLine("Задача решена"); }
        }
    }
}
