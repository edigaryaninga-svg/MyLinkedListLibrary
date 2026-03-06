namespace MyQueueProj;

public class MyQueue<T>
{
    private MyLinkedList<T> _list = new MyLinkedList<T>();

    public void Enqueue(T item)
    {
        _list.AddLast(item);
    }

    public T Dequeue()
    {
        if (_list.Count == 0)
            throw new InvalidOperationException();

        T firstItem = _list.GetFirst();
        _list.RemoveFirst();
        return firstItem;
    }

    public T Peek()
    {
        if (_list.Count == 0)
            throw new InvalidOperationException();

        return _list.GetFirst();
    }


    public int Count => _list.Count;
}
