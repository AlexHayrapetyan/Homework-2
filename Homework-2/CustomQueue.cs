using System;

public class CustomQueue
{
	private int[] queue;  
	private int front;     
	private int rear;      
	private int size;      
	private int count;    

	public CustomQueue(int size)
	{
		this.size = size;
		queue = new int[size];
		front = 0;
		rear = -1;
		count = 0;
	}

	public void Enqueue(int element)
	{
		if (IsFull())
		{
			Console.WriteLine("Queue is full. Cannot add element.");
			return;
		}

		rear = (rear + 1) % size; 
		queue[rear] = element;
		count++;
	}

	public int Dequeue()
	{
		if (IsEmpty())
		{
			Console.WriteLine("Queue is empty. Cannot remove element.");
			return -1;
		}

		int element = queue[front];
		front = (front + 1) % size; 
		count--;
		return element;
	}

	public int Peek()
	{
		if (IsEmpty())
		{
			Console.WriteLine("Queue is empty. Nothing to peek.");
			return -1;
		}
		return queue[front];
	}

	public bool IsEmpty()
	{
		return count == 0;
	}

	public bool IsFull()
	{
		return count == size;
	}

	public void Display()
	{
		if (IsEmpty())
		{
			Console.WriteLine("Queue is empty.");
			return;
		}

		Console.Write("Queue elements: ");
		for (int i = 0; i < count; i++)
		{
			Console.Write(queue[(front + i) % size] + " ");
		}
		Console.WriteLine();
	}
}

public class Program1
{
	public static void Main()
	{
		CustomQueue queue = new CustomQueue(5);

		queue.Enqueue(10);
		queue.Enqueue(20);
		queue.Enqueue(30);
		queue.Enqueue(40);

		queue.Display();  

		Console.WriteLine("Peek: " + queue.Peek()); 

		Console.WriteLine("Dequeue: " + queue.Dequeue()); 
		queue.Display();  

		queue.Enqueue(50);
		queue.Enqueue(60);
		queue.Display();  

		queue.Enqueue(70); 
	}
}

