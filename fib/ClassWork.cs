using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fib
{
    class ClassWork
    {
        public void FibCycl(int fibcycle)
        {
           int FibCyk =Convert.ToInt32(fibcycle);
            int FindFebN = Convert.ToInt32(FibCyk);
            int _fibcycle = 0;
            int b = 0;
            int f = 1;

            for (int a = 0; a < FindFebN; a++)
            {

                _fibcycle = b + f;
                f = b;
                b = _fibcycle;


            }
            Console.WriteLine($"Число Фибоначи = {_fibcycle}");

        }




    }

     
}
