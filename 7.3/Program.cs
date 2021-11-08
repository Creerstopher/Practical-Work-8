using System;

namespace _7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd, rub, i;
            Console.WriteLine("Выберите валюту $ или Р");
            string a = Convert.ToString(Console.ReadLine());
            if (a == "$")
            {
                usd = Convert.ToDouble(Console.ReadLine());
                i = 71;
                rub = usd * i;
                Console.WriteLine(usd + "$ =" + rub + " рублей");
            }
            else if (a == "Р")
            {
                rub = Convert.ToDouble(Console.ReadLine());
                i = 71;
                usd = rub / i;
                Console.WriteLine(rub + "рублей/ля=" + usd + "$");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("end");
            }

        }
    }
}
