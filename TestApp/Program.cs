using System;
using MyStackProj;
using MyQueueProj; 

class Program
{
    static void Main()
    {
        MyStack<int> stack = new MyStack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Peek());

        Console.WriteLine("--- Queue Test ---");

        MyQueue<int> queue = new MyQueue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        Console.WriteLine(queue.Dequeue());
    }
}