using System;
using System.Collections.Generic;

public class CircularBuffer<T>
{

    private readonly Queue<T> _queue;
    private readonly int _capacity;
    
    public virtual T Read()=>  _queue.Dequeue();

    public virtual void Clear()=>  _queue.Clear();

    public virtual void Write(T value)
    {
        if (_capacity < _queue.Count + 1)
            throw new InvalidOperationException("buffer is full");
        else
            _queue.Enqueue(value);
    }

    public CircularBuffer(int capacity)
    {
        _capacity = capacity;
        _queue = new Queue<T>(capacity);
    }

    public virtual void Overwrite(T value)
    {
        if (_queue.Count < _capacity)
            this.Write(value);
        else
        {
            _queue.Dequeue();
            _queue.Enqueue(value);
        }
    }

    
}