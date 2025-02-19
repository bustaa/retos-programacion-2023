using System;

namespace Reto__0___EL_FAMOSO_FIZZ_BUZZ
{
    class Program
    {
        static string ObtenerFizzBuzz(int num)
        {
            if (num % 3 == 0)
            {
                if (num % 5 == 0)
                {
                    return "fizzbuzz";
                }
                else
                {
                    return "fizz";
                }
            }
            else if (num % 5 == 0)
            {
                return "buzz";
            }
            else
            {
                return num.ToString();
            }
        }

        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(ObtenerFizzBuzz(i));   
            }
        }
    }
}
