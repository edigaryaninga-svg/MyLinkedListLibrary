using System;
using MyLinkedListLibrary;

class Program
{
    static void Main()
    {
        MyQueue<int> hert= new MyQueue<int>();

        hert.Enqueue(1); 
        hert.Enqueue(2); 
        hert.Enqueue(3); 

        Console.WriteLine(hert.Peek());  
        Console.WriteLine(hert.Dequeue());
        Console.WriteLine( hert.Peek()); 

        Console.ReadLine();
    }
}
