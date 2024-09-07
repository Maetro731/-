using System;

class Stack
{
    private int N;
    private int[] Array;
    private int top;
    public Stack(int N)
    {
        this.N = N;
        Array = new int[N];
        top = -1;
    }
    public void Push(int x)
    {
        if (top == N - 1)
        {
            Console.WriteLine("Стек переполнен!");
            return;
        }
        top += 1;
        Array[top] = x;
    }
    public int Pop()
    {
        if (IsEmpty() || N == 0)
        {
            Console.WriteLine("Стек пуст.");
            return -1;
        }
        int item = Array[top--];
        Print();
        return item;
    }
    public int Last()
    {
        if(IsEmpty() || N == 0)
        {
            Console.WriteLine("Стек пуст.");
            return -1;
        }
        return Array[top];
    }
    public bool IsEmpty()
    {
        return top == -1;
    }
    public void Print()
    {
        Console.WriteLine("Значения стека: ");
        for (int i = 0; i <= top; i++)
        {
            Console.Write(Array[i]+ " ");
        }
        Console.WriteLine();
    }
}
class Queue
{
    private int capacity;
    private int[] massive;
    private int count;
    public Queue(int capacity)
    {
        this.capacity = capacity;
        massive = new int[capacity];
        count = -1;
    }
    public void enqueue(int x)
    {
        if (count == capacity)
        {
            Console.WriteLine("Очередь переполнена!");
            return;
        }
        count++;
        massive[count] = x;
        Print();
    }
    public int dequeue()
    {
        if (IsEmpty() || capacity == 0)
        {
            Console.WriteLine("Очередь пуста!");
            return -1;
        }
        var result = massive[0];
        for(int i = 0; i < count; i++)
        {
            massive[i] = massive[i + 1];
        }
        count--;
        return result;
        

    }
    public int first()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Очередь пуста!");
            return -1;

        }
        return massive[0]; 
    }
    public bool IsEmpty()
    {
        return count == -1;
    }
    public void Print()
    {
        Console.WriteLine("Значения очереди: ");
        for (int i = 0; i <= count; i++)
        {
            Console.Write(massive[i] + " ");
        }
        Console.WriteLine();
    }
}
class List
{
    private int[] _array; 
    private int size;    

    public List(int capacity) 
    {
        
        _array = new int[capacity];
        size = 0;
    }

    public void Add(int item) 
    {
        if (size == _array.Length) 
        {
            Resize();
        }

        _array[size] = item; 
        size++;
    }

    public void Pop(int index)
    {
        if (index < 0 || index >= size)
        {
            Console.WriteLine("Элемент вне диапазона.");
        }

        for (int i = index; i < size - 1; i++) 
        {
            _array[i] = _array[i + 1];
        }

        size--; 
        _array[size] = default; 
    }

    private void Resize() 
    {
        int newCapacity = _array.Length * 2; 
        int[] newArray = new int[newCapacity];
        Array.Copy(_array, newArray, size);
        _array = newArray;
    }

    public void Print() 
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write(_array[i] + " ");
        }
        Console.WriteLine();
    }
}
public class Set
{
    private object[] elements;
    private bool[] marked;
    private int size;

    public Set(int capacity)
    {
        elements = new object[capacity];
        marked = new bool[capacity];
        size = 0;
    }

    
    public void Add(object item)
    {
        if (size == elements.Length)
        {
            Console.WriteLine("Множество заполнено. Необходимо увеличить емкость.");
            return;
        }

        for (int i = 0; i < size; i++)
        {
            if (elements[i].Equals(item) && marked[i])
            {
                Console.WriteLine("Элемент уже существует.");
                return;
            }
        }

        elements[size] = item;
        marked[size] = true; 
        size++;
        Console.WriteLine($"Элемент {item} добавлен.");
    }

    
    public void Remove(object item)
    {
        for (int i = 0; i < size; i++)
        {
            if (elements[i].Equals(item) && marked[i])
            {
                marked[i] = false; 
                Console.WriteLine($"Элемент {item} удален.");
                return;
            }
        }
        Console.WriteLine("Элемент не найден.");
    }

    
    public bool Contains(object item)
    {
        for (int i = 0; i < size; i++)
        {
            if (elements[i].Equals(item) && marked[i])
            {
                return true;
            }
        }
        return false;
    }

    
    public void Print()
    {
        Console.Write("Множество: ");
        for (int i = 0; i < size; i++)
        {
            if (marked[i])
            {
                Console.Write(elements[i] + " ");
            }
        }
        Console.WriteLine();
    }
}
class Program
{
    static void Main(string[] args)
    {
        int n = 3;
        Stack stack = new Stack(n);
        stack.Push(11);
        stack.Print();
        stack.Push(12);
        stack.Print();
        stack.Push(13);
        stack.Print();
        Console.WriteLine($"Последнее значение стека: {stack.Last()}\n");
        Console.WriteLine($"Удаленное значение стека: {stack.Pop()}");
        Console.WriteLine($"Последнее значение стека: {stack.Last()}\n");
        stack.Pop();
        stack.Pop();
        if(stack.IsEmpty())
        { Console.WriteLine("Стек пуст."); }

        /*int k = 4;
        Queue queue = new Queue(k);
        queue.enqueue(20);
        queue.enqueue(30);
        queue.enqueue(40);
        queue.enqueue(60);
        Console.WriteLine($"Первое значение очереди: {queue.first()}\n");
        Console.WriteLine($"Удаленное значение очереди: {queue.dequeue()}");
        queue.Print();
        queue.dequeue();
        queue.Print();
        queue.dequeue();
        queue.Print();
        queue.dequeue();
        queue.Print();
        if (queue.IsEmpty()) { Console.WriteLine("Очередь пуста!"); }*/

        /*int _size = 3;
        List list = new List(_size);
        list.Add(27);
        list.Add(43);
        list.Add(69);
        list.Print();
        list.Pop(1);
        list.Print();*/

        /*Set mySet = new Set(5);
        mySet.Add(1);
        mySet.Add(2);
        mySet.Add("apple");
        mySet.Remove(1);
        mySet.Print(); 

        Console.WriteLine(mySet.Contains(2));
        Console.WriteLine(mySet.Contains(1)); */

    }
}
