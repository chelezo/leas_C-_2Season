using System;
using System.Linq;


namespace alg
{
    class Program
    {
      
        static void Main(string[] args)

        {
            int d, i, number;
            number = Convert.ToInt32(System.Console.ReadLine());
            d = 0;
            i = 2;
             
            while (i < number)
            {
                if (number%i == 0)
                {
                    d++;
                    break;
                }
                else
                {
                    i++;
                }
            }

            if (d == 0)
            {
                Console.WriteLine("Введенное число простое");
            }
            else
            {
                Console.WriteLine("Введенное число простое");
            }
        

        }
    }
}
