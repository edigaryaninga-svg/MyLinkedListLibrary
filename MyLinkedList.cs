using System;

public class MyLinkedList<T>
{
    private MyLinkedListNode<T> head;
    public int Count { get; private set; }

    public void AddFirst(T value)
    {
        var newNode = new MyLinkedListNode<T>(value);
        newNode.Next = head;
        head = newNode;
        Count++;
    }

    public void AddLast(T value)
    {
        var newNode = new MyLinkedListNode<T>(value);
        if (head == null) head = newNode;
        else
        {
            var current = head;
            while (current.Next != null) current = current.Next;
            current.Next = newNode;
        }
        Count++;
    }

    public void RemoveFirst()
    {
        if (head == null) return;
        head = head.Next;
        Count--;
    }

    public void RemoveLast()
    {
        if (head == null) return;
        if (head.Next == null) head = null;
        else
        {
            var current = head;
            while (current.Next.Next != null) current = current.Next;
            current.Next = null;
        }
        Count--;
    }

    public bool Contains(T value)
    {
        var current = head;
        while (current != null)
        {
            if (current.Value.Equals(value)) return true;
            current = current.Next;
        }
        return false;
    }

    public void Clear()
    {
        head = null;
        Count = 0;
    }

    public override bool Equals(object obj)
    {
        if (obj is MyLinkedList<T> other)
        {
            if (this.Count != other.Count) return false;
            var curr1 = this.head;
            var curr2 = other.head;
            while (curr1 != null)
            {
                if (!curr1.Value.Equals(curr2.Value)) return false;
                curr1 = curr1.Next;
                curr2 = curr2.Next;
            }
            return true;
        }
        return false;
    }

    public T GetFirst()
    {
        if (head == null)
            throw new InvalidOperationException();

        return head.Value;
    }
}