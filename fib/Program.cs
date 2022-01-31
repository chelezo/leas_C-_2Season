using System;

namespace fib
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassWork WorkC = new ClassWork();
           System.Console.WriteLine("Введите число Фибоначи");
           string n = Console.ReadLine();
           int b = Convert.ToInt32(n);
           WorkC.FibCycl(b);
          
        }

    }
}
