using System;

namespace fib
{
    public class LinkedList : ILinkedList
    {
        protected int _count;

        protected Node FirstNode { get; set; }
        protected Node LastNode { get; set; }

        public int GetCount()
        {
            return _count;
        }

        public void AddNode(int value)
        {
            var newNode = new Node
            {
                PrevNode = LastNode,
                Value = value
            };
            if (LastNode == null && FirstNode == null)
            {
                LastNode = newNode;
                FirstNode = newNode;

                _count++;
            }
            else
            {
                AddNodeAfter(LastNode,value);
            }

        }

        public void AddNodeAfter(Node node, int value)
        {
            if (node != null)
            {
                var nextNode = node.NextNode;
                var newNode = new Node
                {
                    PrevNode = node,
                    NextNode = node.NextNode,
                    Value = value
                };

                if (nextNode!=null)
                {
                    nextNode.PrevNode = newNode;
                }
                else
                {
                    LastNode = newNode;
                }
                
                node.NextNode = newNode;
                _count++;
            }
            else
            {
                AddNode(value);
            }
        }

        public void RemoveNode(int index)
        {
            if (index>=_count)
            {
                return;
            }

            var currentIndex = 0;
            
            var currentNode = FirstNode;
            while (currentIndex < index && currentNode!=null)
            {
                currentIndex++;
                currentNode = currentNode.NextNode;
            }

            if (currentNode!=null)
            {
                RemoveNode(currentNode);
            }
        }

        public void RemoveNode(Node node)
        {
            _count--;
            var prevNode = node.PrevNode;
            if (prevNode == null)
            {
                FirstNode = node.NextNode;
                return;
            }

            prevNode.NextNode = node.NextNode;
        }

        public Node FindNode(int searchValue)
        {
            //var index = 0;
            var currentNode = FirstNode;
            do
            {
                if (currentNode.Value == searchValue)
                    return currentNode;
                //index++;
                currentNode = currentNode.NextNode;
            } while (currentNode != null);

            return null;
        }

        public void PrintNodes()
        {
            var index = 0;
            var currentNode = FirstNode;
            Console.WriteLine("[");
            do
            {
                Console.WriteLine($"  {{{index} : {currentNode.Value}}}");
                index++;
                currentNode = currentNode.NextNode;
            } while (currentNode != null);
            Console.WriteLine("]");

            Console.WriteLine($"Overall count of nodes: {_count}");
        }
    }
}