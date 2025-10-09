using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{ 

    class Box<T>
    {
       public T Value { get; set; }
       public void Display()
       {
         Console.WriteLine("Value: " + Value);
       }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
            fruits.Add("Mango");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            } */

            /*Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1, "Alice");
            students.Add(2, "Bob");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            }*/

            /* Stack<int> numbers = new Stack<int>();
             numbers.Push(10);
             numbers.Push(20);
             numbers.Push(30);
             Console.WriteLine("Top: " + numbers.Peek());
             while (numbers.Count > 0)
             {
                 Console.WriteLine(numbers.Pop());
             }*/

            /*Queue<string> tasks = new Queue<string>();
            tasks.Enqueue("Email");
            tasks.Enqueue("Meeting");
            tasks.Enqueue("Report");

            while (tasks.Count > 0)
            {
                Console.WriteLine("Processing: " + tasks.Dequeue());
            }*/

            Box<int> intBox = new Box<int> { Value = 100 };
            Box<string> strBox = new Box<string> { Value = "Hello" };

            intBox.Display();
            strBox.Display();


        }
    }
}

