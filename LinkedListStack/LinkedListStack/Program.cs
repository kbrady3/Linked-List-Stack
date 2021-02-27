using System;

namespace LinkedListStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            Console.WriteLine("Stack empty at beginning: " + s.IsEmpty());
            s.Push("Apple");
            s.Push("Pear");
            s.Push("Banana");
            s.Push("Grape");
            s.Push("Dragonfruit");
            s.Push("Strawberry");
            s.Push("FLKdjsfl");
            Console.WriteLine("Popped: " + s.Pop());
            Console.WriteLine("Peek: " + s.Peek());
            Console.WriteLine("Size: " + s.Size() + "\n");
            Console.WriteLine(s.PrintStackUp());
        }
    }
}
