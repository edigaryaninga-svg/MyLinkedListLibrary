using System;
using MyLinkedListLibrary;

class Program
{
    static void Main()
    {
        MyStack<int> stack = new MyStack<int>();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine("Stack-ի գագաթն է: " + stack.Peek());
        Console.WriteLine("Հեռացվեց: " + stack.Pop());
        Console.WriteLine("Հիմա գագաթն է: " + stack.Peek());

        Console.WriteLine("\nՍեղմեք որևէ ստեղն փակելու համար...");
        Console.ReadKey();
    }
}