using System;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    public Character character;
    public Node next;

    public Node(Character character)
    {
        this.character = character;
        this.next = null;
    }
}

public class CustomQueue
{
    private Node front;
    private Node rear;
    private int count;

    public CustomQueue()
    {
        front = rear = null;
        count = 0;
    }

    public void Enqueue(Character character)
    {
        Node newNode = new Node(character);
        if (rear == null)
        {
            front = rear = newNode;
        }
        else
        {
            rear.next = newNode;
            rear = newNode;
        }
        count++;
    }

    public Character Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        Character removedCharacter = front.character;
        front = front.next;

        if (front == null)
        {
            rear = null;
        }
        count--;
        return removedCharacter;
    }

    public bool IsEmpty()
    {
        return front == null;
    }

    public int Count()
    {
        return count;
    }

    // Print the current queue
    public void PrintQueue()
    {
        Node temp = front;
        string queueContent = "Current Queue: ";

        while (temp != null)
        {
            queueContent += temp.character.gameObject.name + " ";
            temp = temp.next;
        }

        Debug.Log(queueContent);
    }
}
