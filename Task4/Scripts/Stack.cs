using System.Collections.Generic;
using UnityEngine;

public class CustomStack<T> : MonoBehaviour
{
    private List<T> items = new List<T>();

    public void Push(T item)
    {
        items.Add(item);
    }

    public T Pop()
    {
        if (IsEmpty()) return default;
        T item = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return item;
    }

    public T Peek()
    {
        if (IsEmpty()) return default;
        return items[items.Count - 1];
    }

    public int Count()
    {
        return items.Count;
    }

    public bool IsEmpty()
    {
        return items.Count == 0;
    }
}
