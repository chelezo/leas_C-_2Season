using System;

namespace fib
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ClassSwitch classSw = new ClassSwitch();
            classSw.TxTHeLLo();
           string n = Console.ReadLine();
           int b = Convert.ToInt32(n);
           classSw.Swc_(b);
          
        }

    }
}