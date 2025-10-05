using System;
using System.Collections.Generic;
using System.Linq;

enum Priority { Low, Medium, High }

class Task
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Title { get; set; }
    public DateTime DueDate { get; set; }
    public Priority Priority { get; set; }

    public override string ToString() =>
        $"[{Id}] {Title} | Due: {DueDate:dd-MM-yyyy} | Priority: {Priority}";
}

class Program
{
    static List<Task> taskList = new();
    static Dictionary<Guid, Task> taskMap = new();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== TodoCLI ===");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View All Tasks");
            Console.WriteLine("3. Search Task by Title");
            Console.WriteLine("4. Sort Tasks");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1": AddTask(); break;
                case "2": ViewTasks(); break;
                case "3": SearchTasks(); break;
                case "4": SortTasks(); break;
                case "5": return;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    static void AddTask()
    {
        Console.Write("Enter task title: ");
        string title = Console.ReadLine();

        Console.Write("Enter due date (yyyy-mm-dd): ");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime dueDate))
        {
            Console.WriteLine("Invalid date.");
            return;
        }

        Console.Write("Enter priority (Low, Medium, High): ");
        if (!Enum.TryParse(Console.ReadLine(), true, out Priority priority))
        {
            Console.WriteLine("Invalid priority.");
            return;
        }

        var task = new Task { Title = title, DueDate = dueDate, Priority = priority };
        taskList.Add(task);
        taskMap[task.Id] = task;

        Console.WriteLine("Task added successfully.");
    }

    static void ViewTasks()
    {
        if (taskList.Count == 0)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        foreach (var task in taskList)
            Console.WriteLine(task);
    }

    static void SearchTasks()
    {
        Console.Write("Enter keyword to search: ");
        string keyword = Console.ReadLine()?.ToLower();

        var results = taskList
            .Where(t => t.Title.ToLower().Contains(keyword))
            .ToList();

        if (results.Count == 0)
            Console.WriteLine("No matching tasks found.");
        else
            results.ForEach(t => Console.WriteLine(t));
    }

    static void SortTasks()
    {
        Console.WriteLine("Sort by: 1. Due Date  2. Priority");
        string choice = Console.ReadLine();

        var sorted = choice switch
        {
            "1" => taskList.OrderBy(t => t.DueDate).ToList(),
            "2" => taskList.OrderByDescending(t => t.Priority).ToList(),
            _ => null
        };

        if (sorted == null)
        {
            Console.WriteLine("Invalid sort option.");
            return;
        }

        Console.WriteLine("Sorted Tasks:");
        sorted.ForEach(t => Console.WriteLine(t));
    }
}
