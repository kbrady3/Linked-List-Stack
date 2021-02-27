using System;

namespace LinkedListStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push("Apple");
            s.Push("Pear");
            s.Push("Banana");
            Console.WriteLine("Popped: " + s.Pop());
            Console.WriteLine("Top: " + s.Peek());
            Console.WriteLine(s.PrintStackUp());
        }
    }
}
