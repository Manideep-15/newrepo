using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
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

            Stack<int> numbers = new Stack<int>();
            numbers.Push(10);
            numbers.Push(20);
            numbers.Push(30);
            Console.WriteLine("Top: " + numbers.Peek());
            while (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Pop());
            }


        }
    }
}

