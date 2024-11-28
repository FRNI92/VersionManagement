using Contact_Information_Consol.Models;
using System.ComponentModel.Design;

namespace Contact_Information_Consol.Services;

public static class TodoList
{
    private static List<Todo> todos = new List<Todo>();

    public static void Run()
    {
        bool isRunning = true;
        while (isRunning) 
        {
            Console.Clear();
            Console.WriteLine("Todolist Menu\n 1. Lägg till uppgift\n 2. Markera uppgift som klar\n 3. Visa alla uppgifter\n 4. Avsluta ");

            Console.WriteLine("Välj vad du vill göra");
            string? menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    showTasks();
                    break;
                case "3":
                    markAsCompleted();
                    break;
                case "4":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Gör ett val");
                    break;

            }
        }
    }

    private static void AddTask()
    {
        Console.WriteLine("What task would you like to add");
        string? taskDescription = Console.ReadLine();

        if (string.IsNullOrEmpty(taskDescription))
        {
            Console.WriteLine("fyll i något tack");

        }
        else
        {
            todos.Add(new Todo(taskDescription));
            Console.WriteLine($"The task '{taskDescription}' has been added");
        }
        Console.ReadKey();
    }
    private static void showTasks()
    {

    }
    private static void markAsCompleted()
    {

    }
}

