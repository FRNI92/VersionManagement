using Contact_Information_Consol.Models;
using System.ComponentModel.Design;
using System.Threading.Tasks;

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
            Console.WriteLine("Todolist Menu\n 1. Lägg till uppgift\n 2. Visa alla uppgifter \n 3. Markera uppgift som klar\n 4. Avsluta ");

            Console.WriteLine("Välj vad du vill göra");
            string? menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    AddTask();//kallar på de olika metoderna
                    break;
                case "2":
                    ShowTasks();
                    break;
                case "3":
                    MarkAsCompleted();
                    break;
                case "4":
                    Console.WriteLine("Press anykey to end program");
                    isRunning = false;// stoppar whileloopen. vakten säger att vi inte får åka ett varv till
                    break;
                default:
                    Console.WriteLine("Gör ett val"); // här borde null hanteras
                    break;

            }
        }
    }

    private static void AddTask()
    {
        bool addMoreToList = true;

        while (addMoreToList)
        {
        
        Console.WriteLine("What task would you like to add? skriv avsluta för att gå till menyn");
        string? taskDescription = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(taskDescription))//hanterar null
            {
                Console.WriteLine("fyll i något tack");
            }
            else if (taskDescription.ToLower() == "avsluta")
            {
                addMoreToList = false;
            }
            else
            {
                todos.Add(new Todo(taskDescription));// det i parantesen sker först, object skickas som par
                Console.Clear();
                Console.WriteLine($"The task '{taskDescription}' has been added");
            }
            //Console.ReadKey();

        }
    }
    private static void ShowTasks()// ska lägga in logicen här
    {
        if (todos.Count == 0)
        {
            Console.WriteLine("Du har inget i denhär listan");
        }
        else
        {
        foreach (var taskItemsInTodoList in todos) // går igenom alla fack i min box
        {       //tilldelar en text till string status om IsCompleted är true (den är false från början) false får text nr 2
                string status = taskItemsInTodoList.IsCompleted ? "done" : "notevenclosebeingdone";
                Console.WriteLine($"-- {taskItemsInTodoList.Description} ({status})"); //string template för att snygga till. skriver ut den temporära variabeln taskItem från get-delen i Description
        }
        Console.ReadKey();//pausar exekveringen i väntan på key
             
        }
    }

    
    private static void MarkAsCompleted()// 
    {
        if (todos.Count == 0) // .Count är en inbyggd egenskap i List som kan räkna hur många items det finns. de försöker räkna antalet fack i min box.
        {
            Console.WriteLine("Din lista är tyvärr tom, Grattis!?");//är det 0 fack i min box så skriv detta
            Console.ReadKey();//pausar exekvering i väntan på keyinput
            return;//hoppar ur blocket och kör om från början. sitter en whileloop(isRunning som är true) där uppe. tills man klickar case 4
        }

        Console.WriteLine("uppgifter i listan");
        for (int i = 0; i < todos.Count; i++)// reglerna för att blocket ska köras. i++ sker efter blocket.
        {
            string status = todos[i].IsCompleted ? "done" : "notevenclosebeingdone"; //den kollar om alla items i listan är false eller inte. alla är false från början
            Console.WriteLine($"{i + 1}. {todos[i].Description} ({status})");// i+1 så att vi inte börjar på 0. indexerar genom Descriptions i todolistan och skriver ut status
        }
        Console.Write("\nAnge numret på uppgiften du vill markera som klar: ");
        string? input = Console.ReadLine(); 

        //kollar om input är null eller ogiltigt. kan den inte Parsa så returnerar den false och ge tasknumber 0.input är noll tills den kommer genom out
        if (int.TryParse(input, out int taskNumber) && taskNumber > 0 && taskNumber <= todos.Count)
        {   //Index räkna från 0. men vi räknar från 1. därför kör vi -1. input flyttas till tasknumber
            todos[taskNumber - 1].IsCompleted = true; // Markera uppgiften som klar
            Console.WriteLine($"Uppgiften '{todos[taskNumber - 1].Description}' har markerats som klar.");
        }
        else
        {
            Console.WriteLine("Ogiltigt val. Försök igen.");
        }

        Console.ReadKey(); // Pausa så användaren kan se meddelandet
    }
}

