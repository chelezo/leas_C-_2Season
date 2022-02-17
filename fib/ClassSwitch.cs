using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fib
{

    class ClassSwitch
    {
        // TxTHeLLo = Ничего не принимает а лишь выдает список выборки
        //Swc_ = Оператор switch для выбора нужного задания

        ClassWork WorkC = new ClassWork();
        public void TxTHeLLo()
        {
            Console.WriteLine("1) Число Фибоначи методом цикла");
            Console.WriteLine("2) Число Фибоначи методом рекурсии");
            Console.WriteLine("3) Алогритм по блок-схеме задача 1");
            Console.WriteLine("4) Двухсвязный список");

        }
        public void Swc_(int swc)
        {
            switch (swc)
            {
                case 1:
                    Console.WriteLine("Введите число для получения числа Фибоначи циклом");
                    WorkC.FibCycl(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 2:
                    Console.WriteLine("Введите число для получения числа Фибоначи рекурсией");
                    int num = WorkC.FibRec(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Число Фибоначи рекурсией равно: " + num);
                    break;
                case 3:
                    Console.WriteLine("Введите число для получения результата работы алгоритма");
                    WorkC.Algoritm(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 4:
                    WorkC.TwoList();
                    break;
            }
        }

    }

}
