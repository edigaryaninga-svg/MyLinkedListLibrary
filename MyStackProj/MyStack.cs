using MyLinkedListLibrary;
namespace MyStackProj;

public class MyStack<T>
{
    private MyLinkedList<T> _list = new MyLinkedList<T>();

    public void Push(T item)
    {
        _list.AddFirst(item);
    }

    public T Pop()
    {
        if (_list.Count == 0) throw new InvalidOperationException();

        T topValue = Peek();
        _list.RemoveFirst();
        return topValue;
    }

    public T Peek()
    {
        if (_list.Count == 0) throw new InvalidOperationException();

        return _list.GetFirst();
    }
}