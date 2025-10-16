using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace practice_1
{
    internal class Program
    {
        private static object cw;

        static void Main(string[] args)
        {


            /*Console.WriteLine("Enter a number: ");                     // Addition of two numbers
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;
            Console.WriteLine($"The sum of two nums:{sum} " );*/

            /* Console.WriteLine("Enter num1: ");
             double num1 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Enter num2: ");
             double num2 = Convert.ToDouble(Console.ReadLine());                // Largest of three numbers

             Console.WriteLine("Enter num3: ");
             double num3 = Convert.ToDouble(Console.ReadLine());

             if (num1 >= num2 && num1 >= num3)
             {
                 Console.WriteLine($"The largest number is: {num1}");
             }
             else if (num2 >= num1 && num2 >= num3)
             {
                 Console.WriteLine($"The largest number is: {num2}");
             }
             else
             {
                 Console.WriteLine($"The largest number is: {num3}");
             } */


            /*  Console.WriteLine("Enter num1: ");
              int num1 = Convert.ToInt32(Console.ReadLine());

              if(num1 % 2 == 0)                                               // Even or odd
              {
                  Console.WriteLine($"{num1} is even");
              }
              else
              {
                  Console.WriteLine($"{num1} is odd");
              } */



            /* int a = 5, b = 10;
             Console.WriteLine($"Before Swap: a = {a}, b = {b}");                // swap two nums without using third variable

             a = a + b;
             b = a - b;
             a = a - b;

             Console.WriteLine($"After Swap: a = {a}, b = {b}"); */

            /*for (int i = 1; i <= 10; i++)                                      // print nums 1 to 10
            {
                Console.WriteLine(i);
            } */


            /*  Console.WriteLine("Enter a number: ");
              int number = Convert.ToInt32(Console.ReadLine());                  //factorial of a num

              int fact = 1;

              for (int i = 1; i <= number; i++)
              {
                  fact = fact * i;
              }
              Console.WriteLine($"The factorial of the number is: {fact}"); */

            /*  Console.WriteLine("Enter a number: ");
              int num = Convert.ToInt32(Console.ReadLine());                   // multiplication table of a num

               for(int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{num} * {i} = {num * i}"); 
                }*/


            /*    Console.WriteLine("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                bool isPrime = true;
                                                                                       // prime or not
                if (num <= 1)
                {
                    isPrime = false;
                }

                else
                {
                    for (int i = 2; i <= Math.Sqrt(num); i++)
                    {

                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;

                        }
                    }
                }

                Console.WriteLine(isPrime ? "Prime" : "Not Prime"); */




            /* Console.Write("Enter number of terms: ");
             int n = Convert.ToInt32(Console.ReadLine());

             int a = 0, b = 1;                                                      // fibonacci series
             Console.Write("Fibonacci Series: ");

             for (int i = 0; i < n; i++)
             {
                 Console.Write($"{a} ");
                 int temp = a + b;
                 a = b;
                 b = temp;
             } */


            /* int[] arr = { 5, 12, 7, 20, 3 };
             int max = arr[0];
                                                                                        // largest element in an array
             foreach (int num in arr)
             {
                 if (num > max)
                     max = num;
             }

             Console.WriteLine($"Largest element: {max}"); */

            /* Console.Write("Enter a string: ");
             string input = Console.ReadLine();                                          // reverse a string
             char[] chars = input.ToCharArray();
             Array.Reverse(chars);
             string reversed = new string(chars);

             Console.WriteLine($"Reversed: {reversed}"); */


            /* Console.Write("Enter a string: ");
             string input = Console.ReadLine().ToLower();                     //Count Vowels in a String
             int count = 0;

             foreach (char c in input)
             {
                 if ("aeiou".Contains(c))
                     count++;
             }

             Console.WriteLine($"Vowel count: {count}"); */


            /* int[] arr = { 5, 2, 9, 1, 7 };                                      // sort an array in ascending order
             Array.Sort(arr);

             Console.WriteLine("Sorted array:");
             foreach (int num in arr)
                 Console.Write(num + " "); */


            /* Console.Write("Enter a string: ");
             string input = Console.ReadLine();                                         // check palindrome
             string reversed = new string(input.Reverse().ToArray());

             if (input == reversed)
                 Console.WriteLine("Palindrome");
             else
                 Console.WriteLine("Not Palindrome"); 

         }
        }     */


            /* class Car
             {                                                                                 // Class Car with Properties
                 public string Brand;
                 public int Year;

                 public void Display()
                 {
                     Console.WriteLine($"Brand: {Brand}, Year: {Year}");
                 }
             }

             class Program
             {
                 static void Main()
                 {
                     Car myCar = new Car();
                     myCar.Brand = "Toyota";
                     myCar.Year = 2022;
                     myCar.Display();
                 }
             } */


            /* class Student
             {                                                                             // class Student with Constructor
                 public string Name;
                 public int Marks;

                 public Student(string name, int marks)
                 {
                     Name = name;
                     Marks = marks;
                 }

                 public void Show()
                 {
                     Console.WriteLine($"{Name} scored {Marks}");
                 }
             }

             class Program
             {
                 static void Main()
                 {
                     Student s1 = new Student("Ravi", 88);
                     s1.Show();
                 }
             } */

            /*class Book
           {
               public string Title;                                                      // Class Book with Multiple Constructors
               public string Author;

               public Book(string title)
               {
                   Title = title;
                   Author = "Unknown";
               }

               public Book(string title, string author)
               {
                   Title = title;
                   Author = author;
               }

               public void Info()
               {
                   Console.WriteLine($"Title: {Title}, Author: {Author}");
               }
           }

           class Program
           {
               static void Main()
               {
                   Book b1 = new Book("C# Basics");
                   Book b2 = new Book("Advanced C#", "John Doe");

                   b1.Info();
                   b2.Info();
               }
           }  */


            List<int> numbers = new List<int> { 10, 20, 30 };                     // list of integers

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

    }
}


































