using Contact_Information_Consol;
using System; //gör att man kan använda consoleWrite/read och datatyper
using System.Collections.Generic; //gör att vi kan använda List

/*lägger till val 2 i menyn. lägger till case 2 
 lägg till slah n och slah t*/

class ProgramMenu // den här klassen ska innehålle Main
{
    static void Main(string[] args)
    {
        List<string> userInputList = [];//skapar en List string som är tom
        bool isRunning = true;//skapar en boolvariabel som jag sätter till true. så att koden körs.

        while (isRunning)// isRunning får "stämpeln" av true eller false. true i detta fall
        {
            Console.WriteLine("Välj ett alternativ:");
            Console.WriteLine("1. Lägg till Namn");
            Console.WriteLine("2. Lägg till ålder");
            //Console.WriteLine("3. Lägg till telefonnummer");
            //Console.WriteLine("4 Lägg till adress");
            Console.WriteLine("5. Skriv ut listan");
            Console.WriteLine("6. Sten Sax Påse");
            Console.WriteLine("7 Calculator");

            string menuChoice = Console.ReadLine();//sparar användarens text
            Console.Clear();
            switch (menuChoice) //städar upp konsollen lite
            {
                case "1"://jämför det jag sparat från användaren
                    Console.WriteLine("skriv Namn:");
                    string input = Console.ReadLine();
                    Contact.AddNameToList(input, userInputList);//öppnar en portal och "speglar" innehållet här med contact
                    break;

                case "2":
                    Console.WriteLine("Skriv in din ålder:");
                    string ageInput = Console.ReadLine();
                    userInputList.Add(ageInput);
                    Console.WriteLine($"åldern '{ageInput}' har lagts till i listan.");
                   break;

                case "5":
                    Console.WriteLine("Skriver ut listan...");
                    foreach (string info in userInputList)
                    {
                        Console.WriteLine($"-- {info}");
                    }

                    isRunning = false;
                    break;
                
                case "6":
                    Console.WriteLine("vill du spela Sten sax påse? skriv ja ");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "ja")
                    {
                        Rock_Paper_Scissors.Play();//anropar filen med spelet
                    }
                    else
                    {
                        Console.WriteLine("Går tillbaka till menyn...");
                    }
                    break;

                case "7":
                    Console.WriteLine("Du vill ha hjälp att räkna ut saker?. skriv ja för att går vidare. anykey för att back");
                    string calcAnswer = Console.ReadLine();
                    if (calcAnswer.ToLower() == "ja")
                    {
                        Calculator.CalcBank();
                    }
                    else
                    {
                        Console.WriteLine("Går tillbaka till menyn...");
                    }
                    break;

                default:
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    break;

            }
        }
    }
}

                    