
using System.Reflection.Metadata;
using UserListManager.Services;
using UserListManager.Models;
class Program
{
    static void Main()
    {
        var fileSavingService = new FileSavingService();
        var userTemplates = fileSavingService.LoadFromFile();

        while (true) 
        {
            Console.Clear();
            Console.WriteLine("1. Add a user");
            Console.WriteLine("2. Show all users");
            Console.WriteLine("3. Exit");

            var choiceInput = Console.ReadLine();

            switch (choiceInput)
            {
                case "1":
                    Console.WriteLine("Submit you name");
                    var nameInput = Console.ReadLine();
                    Console.WriteLine("Submit you email");
                    var emailInput = Console.ReadLine();
                    userTemplates.Add(new UserTemplate (nameInput, emailInput));
                    fileSavingService.SaveToFile(userTemplates);
                    Console.WriteLine("The user has been added");
                    break;

                case "2":
                    Console.WriteLine("UserList:");
                    for (int i = 0; i < userTemplates.Count; i++)
                    {
                        var user = userTemplates[i];
                        Console.WriteLine($"{i + 1}. Name: {user.Name}, Email: {user.Email}, Created: {user.Created}");
                    }
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("invalid");
                    break;
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}