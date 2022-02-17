using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fib
{
    class ClassWork
    {

        // FibCycl = Число фибоначи Циклом
        // Algoritm = Алгоритм по блок-схеме
        //FibRec = Число фибоначи Рекурсией

        public void FibCycl(int fibcycle)
        {
            int FibCyk = Convert.ToInt32(fibcycle);
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
        public void Algoritm(int _Alg)
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
        public void TwoList()
        {
            ILinkedList list = new LinkedList();
            var initializer = new LinkedListInitializer();

            // init list
            Console.Write("Input number of random elements in the list: ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int count))
            {
                initializer.InitList(list, count);
                list.PrintNodes();
            }
            else
            {
                Console.WriteLine("\n\nWrong input value, press eny key to exit..");
                return;
            }

            //search node
            Console.Write("Input Value to search in the list: ");
            var inputValue = Console.ReadLine();
            if (int.TryParse(inputValue, out int value))
            {
                var node = list.FindNode(value);
                Console.WriteLine(node == null ? "Such node was not found" : "The node was found");

                list.PrintNodes();
            }
            else
            {
                Console.WriteLine("\n\nWrong input value, press eny key..");
            }

            // add node
            Console.Write("Input Value for the new Node: ");
            var newNodeValueString = Console.ReadLine();
            if (int.TryParse(newNodeValueString, out int newNodeValue))
            {

                list.AddNode(newNodeValue);
                list.PrintNodes();
            }
            else
            {
                Console.WriteLine("\n\nWrong input value, press eny key to exit..");
            }

            // remove node
            // add node
            Console.Write("Input Value for the Node index to remove: ");
            var nodeIndexString = Console.ReadLine();
            if (int.TryParse(nodeIndexString, out int nodeIndex))
            {
                list.RemoveNode(nodeIndex);
                list.PrintNodes();
            }
            else
            {
                Console.WriteLine("\n\nWrong input value, press eny key to exit..");
            }

            Console.WriteLine("\n\nPress eny key to exit..");
            Console.ReadLine();
        }
    }
}

