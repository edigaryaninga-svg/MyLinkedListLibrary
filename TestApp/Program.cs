using System;
using MyStackProj;
using MyQueueProj;
using MyBinaryTreeProj;
using MyCalculatorProj;
using HashTableProj;
using MyLinkedListLibrary;

class Program
{
    static void Main()
    {
        // 0. Linked List Test
        Console.WriteLine("=== Linked List ===");
        MyLinkedList<int> list = new MyLinkedList<int>();
        list.AddLast(10);
        list.AddLast(20);
        list.AddFirst(5);
        Console.WriteLine("Count: " + list.Count);
        Console.WriteLine("First element: " + list.GetFirst());
        Console.WriteLine("Contains 10: " + list.Contains(10));
        list.RemoveFirst();
        Console.WriteLine("First after RemoveFirst: " + list.GetFirst());

        // 1. Stack Test
        Console.WriteLine("\n=== Stack ===");
        MyStack<int> stack = new MyStack<int>();
        stack.Push(100);
        stack.Push(200);
        Console.WriteLine("Peek: " + stack.Peek());
        Console.WriteLine("Pop:  " + stack.Pop());

        // 2. Queue Test
        Console.WriteLine("\n=== Queue ===");
        MyQueue<int> queue = new MyQueue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        Console.WriteLine("Dequeue: " + queue.Dequeue());

        // 3. Binary Tree Test
        Console.WriteLine("\n=== Binary Tree ===");
        MyBinaryTree<int> tree = new MyBinaryTree<int>();
        tree.Add(50);
        tree.Add(30);
        tree.Add(70);
        Console.Write("Sorted: ");
        tree.PrintSorted();
        Console.WriteLine("\nContains 70: " + tree.Contains(70));

        // 4. Calculator Test
        Console.WriteLine("\n=== Calculator ===");
        MyCalculator calc = new MyCalculator();
        Console.WriteLine("10 + 5 = " + calc.Calculate(10, 5, "+"));
        Console.WriteLine("10 * 5 = " + calc.Calculate(10, 5, "*"));

        // 5. Hash Table Test
        Console.WriteLine("\n=== Hash Table ===");
        string word = "Hasmik";
        int addHash = MyHasher.AdditiveHash(word);
        int foldHash = MyHasher.FoldingHash(word);
        Console.WriteLine($"Input: {word}");
        Console.WriteLine($"Additive Hash: {addHash}");
        Console.WriteLine($"Folding Hash:  {foldHash}");

        Console.WriteLine("\n-------------------------------------------");
        Console.WriteLine("All tests completed. Press any key to exit.");
        Console.ReadKey();
    }
}