using System;

namespace fib
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassWork WorkC = new ClassWork();
            ClassSwitch classSw = new ClassSwitch();
            WorkC.TxTHeLLo();
           string n = Console.ReadLine();
           int b = Convert.ToInt32(n);
           classSw.Swc_(b);
          
        }

    }
}
