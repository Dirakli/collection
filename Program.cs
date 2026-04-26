using System.Collections;

namespace ConsoleApp218
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack: ");
            Console.WriteLine();
            MyStack stack = new MyStack();
            stack.Push("Paladin");
            stack.Push("Human");
            stack.Push("Hunter");

            while (stack.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(stack.Peek());
                stack.Pop();
                Console.ResetColor();
            }

            Console.WriteLine();
            Console.WriteLine("Queue: ");
            Console.WriteLine();

            MyQueue queue = new MyQueue();
            queue.Enqueue("Mercedes Benz");
            queue.Enqueue("Tesla");
            queue.Enqueue("Suzuki");

            while (queue.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(queue.Peek());
                queue.Dequeue();
                Console.ResetColor();
            }

            Console.WriteLine();



            MyList list = new MyList();

            list.Add("Euripide");
            list.Add("Sophocle");
            list.Add("Molière");
            list.Add("Shakespeare");
            list.Add("Eschyle");

            list.Insert(1, "Aristophane");
            list.Insert(3, "Homer");

            list[2] = "Jumberi";

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("GetElementAt(2): " + list.GetElementAt(2));

            Console.WriteLine("Contains 'Jumberi': " + list.Contains("Jumberi"));
            Console.WriteLine("IndexOf 'Jumberi': " + list.IndexOf("Jumberi"));
            Console.WriteLine("IndexOf from 3: " + list.IndexOf("Jumberi", 3));

            list.Remove("Jumberi");

            list.RemoveAt(0);

            object[] arr = new object[20];
            list.CopyTo(arr, 5);

            list.Clear();

            Console.WriteLine("After Clear: " + list.Count);
        }
    }
}