using System;
using MyStackProj;
using MyQueueProj;
using MyBinaryTreeProj;
using MyCalculatorProj;

class Program
{
    static void Main()
    {
        // 1. Stack Test
        Console.WriteLine("=== Stack ===");
        MyStack<int> stack = new MyStack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Peek());

        // 2. Queue Test
        Console.WriteLine("\n=== Queue ===");
        MyQueue<int> queue = new MyQueue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        Console.WriteLine(queue.Dequeue());

        // 3. Binary Tree Test
        Console.WriteLine("\n=== Binary Tree ===");
        MyBinaryTree<int> tree = new MyBinaryTree<int>();
        tree.Add(50);
        tree.Add(30);
        tree.Add(70);
        Console.Write("Sorted: ");
        tree.PrintSorted();
        Console.WriteLine("Contains 70: " + tree.Contains(70));

        // 4. Calculator Test
        Console.WriteLine("\n=== Calculator ===");
        MyCalculator calc = new MyCalculator();
        Console.WriteLine("10 + 5 = " + calc.Calculate(10, 5, "+"));
        Console.WriteLine("10 * 5 = " + calc.Calculate(10, 5, "*"));
        Console.WriteLine("10 / 2 = " + calc.Calculate(10, 2, "/"));

        Console.ReadKey();
    }
}