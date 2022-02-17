using System;

namespace fib
{
    public class LinkedListInitializer
    {
        public ILinkedList InitList(ILinkedList list, int count)
        {
            var random = new Random((int)DateTime.Now.Ticks);
            
            for (int index = 0; index < count; index++)
            {
                list.AddNode(random.Next(100));    
            }

            return list;
        }
    }
}