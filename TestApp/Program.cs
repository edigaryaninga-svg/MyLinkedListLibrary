using MyStackProj;

class Program
{
    static void Main()
    {
        MyStack<int> stack = new MyStack<int>();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine( stack.Peek());
        Console.WriteLine(stack.Pop());
        Console.WriteLine( + stack.Peek());

        Console.WriteLine();
        Console.ReadKey();
    }
}
