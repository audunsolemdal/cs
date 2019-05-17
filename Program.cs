using System;
using Acme.Collections;

namespace csproj2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            Console.WriteLine("Hello World!");

                    Stack s = new Stack();
        s.Push(1);
        s.Push(10);
        s.Push(100);
        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());
        }
    }
}
