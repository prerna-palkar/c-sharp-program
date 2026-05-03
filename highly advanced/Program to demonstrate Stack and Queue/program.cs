using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        Console.WriteLine(stack.Pop());

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(10);
        Console.WriteLine(queue.Dequeue());
    }
}
