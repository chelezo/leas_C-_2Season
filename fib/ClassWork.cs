using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fib
{
    class ClassWork
    {
        
        public void TxTHeLLo()
        {
            Console.WriteLine("1) Число Фибоначи методом цикла");
            Console.WriteLine("2) Число Фибоначи методом рекурсии");
            Console.WriteLine("3) Алогритм по блок-схеме задача 1");

        }
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

        public void Algoritm (int _Alg)
        {
            int d, i, number;
            number = _Alg;
            d = 0;
            i = 2;

            while (i < number)
            {
                if (number % i == 0)
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
                Console.WriteLine("Введенное число не простое");
            }
        }
        public int FibRec(int _num)
        {
         
            if (_num <= 1)
            {
                return 1;
            }
            else if (_num == 2)
            {
                
                return 1;
            }
            else
            {
                return FibRec(_num - 1) + FibRec(_num - 2);
                
            }
            

        }

    }

     
}
