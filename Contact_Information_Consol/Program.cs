/*  Fråga om kontaktuppgifter
    Namn?
    kontrollera namn
    ålder?
    spara ålder
    skriv ut ålder
*/
using System.Text.RegularExpressions;
List<string> userInputList = [];
string userNameInput;
Regex nameCheck = new Regex(@"^[a-zA-Z]+$");

do 
    {
    Console.Write("Vi behöver få in dina kontaktuppgifte\n skriv in ditt namn eller skriv 'Avsluta' för att stänga fönstret:");
     userNameInput = Console.ReadLine();

        if (userNameInput.ToLower() == "avsluta")
        {
            break;
        }
    
        if (nameCheck.IsMatch(userNameInput))
        {
            userInputList.Add(userNameInput);
            Console.WriteLine($"Vi har lagt till: {userNameInput}");
        }
        else
        {
            Console.WriteLine("You need to enter a valid name. no numbers ");
        }
    } while (true);

Console.WriteLine("\nKontaktuppgifter");

foreach (string userInputName in userInputList)
{
    Console.WriteLine($"- {userInputName}");
}

Console.ReadKey();



