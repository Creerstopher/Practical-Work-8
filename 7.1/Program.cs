using System;

namespace _7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, u, r;
            try
            {
                u = Convert.ToDouble(Console.ReadLine());
                r = Convert.ToDouble(Console.ReadLine());
                i = u / r;
                Console.WriteLine(i);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}
