/*  Fråga om kontaktuppgifter
    Namn?check
    kontrollera namncheck
    ålder?
    spara ålder
    skriv ut ålder
*/
using System.Text.RegularExpressions;
List<string> userInputList = []; //använder samma lista för namn och ålder. kommer behöva konvertera age ToString()
string userNameInput;
Regex nameCheck = new Regex(@"^[a-zA-Z]+$");

int userAgeInput;

do 
    {
    Console.Write("Vi behöver få in dina kontaktuppgifte\n skriv in ditt namn eller skriv 'Avsluta' för att stänga fönstret:");
     userNameInput = Console.ReadLine();

        if (userNameInput.ToLower() == "avsluta")
        {
            break;//skriver man avsluta så breakar den och skriver ut listan
        }
    
        if (nameCheck.IsMatch(userNameInput))//kollar om namnet innehåller bokstäver
        {
            userInputList.Add(userNameInput);//lägger till input i listan
            Console.WriteLine($"Vi har lagt till: {userNameInput}"); //säger till användaren att namnet lagts till och breakar
            break;
        }
        else
        {
            Console.WriteLine("You need to enter a valid name. no numbers "); //skriv in korrekt namn som är godkänd av regex
        }
    } while (true);
//när denna loop är avslutat påbörjas nästa do-while
do
{
    Console.Write("Hur många år är du? skriv avsluta för att se listan");
    string input = Console.ReadLine();

    if (input.ToLower() == "avsluta")
    {
        break;
    }
    

    if (int.TryParse(input, out userAgeInput)) //kollar om det är en giltig siffra. är det ok så hamnar value hos out-variabeln
    {
        userInputList.Add(input.ToString());// den läggs till i listan men som en string och breakar
        Console.WriteLine($"du är {userAgeInput} år gammal. Ålder har lagts till i listan");
        break;
    }
    else
    {
        Console.WriteLine("Du måste ange ett giltigt heltal för ålder. försök igen.");
    }
} while (true);

Console.WriteLine("\nKontaktuppgifter");// när allt har breakat aningen av korrekt inmatning eller "avslut" så hämtar foreach ut allt ur listan

foreach (string userInputName in userInputList)
{
    Console.WriteLine($"- {userInputName}");
}

Console.ReadKey();



