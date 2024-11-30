
using System.Reflection.Metadata;
using UserListManager.Services;
using UserListManager.Models;

/*skapa 3 classer, en för meny(gör den i program), en för filen(services) och en för users(models)
 */
class Program
{
    static void Main()
    {
        var fileSavingService = new FileSavingService();//skapar en instans av class FileSavingService(är ej skriven med static)
        var userTemplates = fileSavingService.LoadFromFile();//sparar object från metoden LoadFromFile
        /*Brevbäraren(Program) vill öppna dörren och få tillgång till en instans av maskinen(FileSavingServie 
         * som kan hjälpa oss skriva ut rätt fil med metoden LoadFromFile*/

        while (true) //den här bestämmer om vi ska springe genom kodblocket igen eller ej
        {
            Console.Clear();//rensar det som varit tidigare i loopen
            Console.WriteLine("1. Add a user");
            Console.WriteLine("2. Show all users");
            Console.WriteLine("3. Exit");

            var choiceInput = Console.ReadLine();//var verkar inte klaga på null i jämförelse med string

            switch (choiceInput)//beroende på vad man klickat i så åker vi till rätt case
            {
                case "1":
                    /*här öppnar vi inte dörren till classen UserTemplate. vi använder konstruktor med samma namn
                     för att direkt vi using.models
                    vi skapar objectet med new. men använder using för att se mallen.
                    using är hur brevet ska vara utformat, vilken adress, avsändare. frimärke med stämpel eller ej
                    medans new userTemplate skapar det faktiska breve utifrån mallen.
                    finns ingen mall så måste vi säga exakt hur den ska se ut
                    */
                    Console.WriteLine("Submit you name");
                    var nameInput = Console.ReadLine();
                    Console.WriteLine("Submit you email");
                    var emailInput = Console.ReadLine();//hoppar över till konstruktorn och set respektive, samt får timestamp
                    userTemplates.Add(new UserTemplate (nameInput, emailInput));//är samma som userTemplates.Add(new UserListManager.Models.UserTemplate(nameInput, emailInput));
                    fileSavingService.SaveToFile(userTemplates);//sparar det med public void saveToFie
                    Console.WriteLine("The user has been added");
                    break;

                    /*vi skriver ut UserList och sedan loopar vi med for tills att vi gått igenom alla fack i boxen
                     * .Count är en inbyggd egenskap i List som kan returnera antalet fack/element
                     så länge i är färre än Count så fortsätter vi loopa. index börjar på 0 men vi räknar från 1
                    har jag 3 object[0,1,2] så är Count 3. varv 1 så är i 0, varv 2 är i 1, varv 3 är i 2. därför kommer den inte 
                    loopa på varv 4 för då är count inte mindre än i(3)*/
                case "2":
                    Console.WriteLine("UserList:");
                    for (int i = 0; i < userTemplates.Count; i++)
                    {
                        var user = userTemplates[i];//här så använder vi i för att srkiva ut dem i indexeringsording
                        Console.WriteLine($"{i + 1}. Name: {user.Name}, Email: {user.Email}, Created: {user.Created}");
                    }//men för att inte börja på 0 så kör man i+1
                    //verkar kunna bli problem med både for och foreach om strukturen på facken i boxen ändras
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