using System;

namespace MyLinkedListLibrary
{
    public class MyStack<T>
    {
        private T[] _items; 
        private int _top;   
        public MyStack(int capacity = 10)
        {
            _items = new T[capacity];
            _top = -1; 
        }
        public void Push(T item)
        {
            if (_top == _items.Length - 1)
            {
                throw new InvalidOperationException();
            }

            _top++;              
            _items[_top] = item;
        }
        public T Pop()
        {
            if (_top == -1)
            {
                throw new InvalidOperationException();
            }

            T value = _items[_top]; 
            _items[_top] = default(T); 
            _top--;                 
            return value;
        }

        public T Peek()
        {
            if (_top == -1)
            {
                throw new InvalidOperationException();
            }

            return _items[_top];
        }

        
        public int Count => _top + 1;
    }
}
