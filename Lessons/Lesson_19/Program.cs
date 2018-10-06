using System;
using System.Collections.Generic;
using System.Collections;

namespace Lesson_19
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList();

            BitArray bitarray = new BitArray(5);

            Hashtable hashtable = new Hashtable();

            Queue queue = new Queue();

            SortedList sortedList = new SortedList();

            Stack stack = new Stack();

            //Некоторые методы List<T>
            ExampleOfList();

            //Некоторые методы Queue<T>
            ExampleOfQueue();

            //Некоторые методы Stack<T>
            ExampleOfStack();

            //Некоторые методы Dictionary<TKey, TValue>
            ExampleOfDictionary();

            Console.ReadLine();
        }

        static void WriteCollection(IList<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void WriteCollection<T>(IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void WriteDictionary<TKey, TValue>(Dictionary<TKey, TValue> dictionary)
        {
            foreach (var item in dictionary)
            {
                Console.Write(item.Key + "-" + item.Value + " ");
            }
            Console.WriteLine();
        }

        static void ExampleOfList()
        {
            List<int> list = new List<int>() { 1, 2, 3 };
            WriteCollection(list);
            Console.WriteLine();

            list.Add(5);
            WriteCollection(list);
            Console.WriteLine();

            list.AddRange(new int[] { 7, 8, 9 });
            WriteCollection(list);
            Console.WriteLine();

            list.AddRange(list);
            WriteCollection(list);
            Console.WriteLine();

            Console.WriteLine("index of first 5: " + list.IndexOf(5));
            Console.WriteLine();

            list.Insert(3, 9);
            WriteCollection(list);
            Console.WriteLine();

            list.Remove(9);
            WriteCollection(list);
            Console.WriteLine();

            list.RemoveAt(3);
            WriteCollection(list);
            Console.WriteLine();

            list.Sort();
            WriteCollection(list);
            Console.WriteLine();

            //Найдет быстрее чем IndexOf
            Console.WriteLine("index of 7: " + list.BinarySearch(7));
            Console.WriteLine();
        }

        static void ExampleOfQueue()
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("first");
            queue.Enqueue("second");
            queue.Enqueue("third");
            WriteCollection<string>(queue);
            Console.WriteLine();

            //Метод Dequeue берет первый эл-т очереди и удаляет его из очереди
            Console.WriteLine("Dequeue: First element in queue was: " + queue.Dequeue());
            Console.WriteLine("Now queue contains:");
            WriteCollection<string>(queue);
            Console.WriteLine();

            //Метод Peek берет первый элемент очереди без удаления его из нее
            Console.WriteLine("Peek: First element in queue was: " + queue.Peek());
            Console.WriteLine("Now queue contains:");
            WriteCollection<string>(queue);
            Console.WriteLine();
        }

        static void ExampleOfStack()
        {
            Stack<char> stack = new Stack<char>();

            stack.Push('a');
            stack.Push('b');
            stack.Push('c');
            WriteCollection<char>(stack);
            Console.WriteLine();

            //Метод Pop берет первый эл-т очереди и удаляет его из очереди
            Console.WriteLine("Pop: First element in stack was: " + stack.Pop());
            Console.WriteLine("Now stack contains:");
            WriteCollection<char>(stack);
            Console.WriteLine();

            //Метод Peek берет первый элемент очереди без удаления его из нее
            Console.WriteLine("Peek: First element in stack was: " + stack.Peek());
            Console.WriteLine("Now stack contains:");
            WriteCollection<char>(stack);
            Console.WriteLine();
        }

        static void ExampleOfDictionary()
        {
            //Первый способ инициализации
            Dictionary<string, string> dictionary1 = new Dictionary<string, string>();
            dictionary1.Add("Russia", "Moscow");
            dictionary1.Add("France", "Paris");
            dictionary1.Add("Germany", "Berlin");
            WriteDictionary<string, string>(dictionary1);
            Console.WriteLine();

            //Удаление производится по ключу
            dictionary1.Remove("Germany");
            WriteDictionary<string, string>(dictionary1);
            Console.WriteLine();

            //Второй способ инициализации
            Dictionary<int, char> dictionary2 = new Dictionary<int, char>
            {
                {1, 'a'},
                {3, 'c'},
                {5, 'e'}
            };
            WriteDictionary<int, char>(dictionary2);
            Console.WriteLine();

            //Удаление не зависит от того на каком месте находится эл-т
            dictionary2.Remove(3);
            WriteDictionary<int, char>(dictionary2);
            Console.WriteLine();

            //Третий способ инициализации
            Dictionary<int, string> dictionary3 = new Dictionary<int, string>
            {
                [1] = "Париж",
                [2] = "Берлин",
                [3] = "Лондон"
            };
            WriteDictionary<int, string>(dictionary3);
            Console.WriteLine();
        }
    }
}
