using System;
using System.Collections.Generic;

class Student
{
    public string Name;
    public int Marks;

    public Student(string name, int marks)
    {
        Name = name;
        Marks = marks;
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        students.Add(new Student("Ravi", 85));
        students.Add(new Student("Priya", 92));

        foreach (Student s in students)
        {
            Console.WriteLine($"{s.Name} scored {s.Marks}");
        }
    }
}
