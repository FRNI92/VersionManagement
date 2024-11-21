using System; //gör att man kan använda consoleWrite/read och datatyper
using System.Collections.Generic; //gör att vi kan använda List

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
            //Console.WriteLine("2. Lägg till ålder");
            //Console.WriteLine("3. Lägg till telefonnummer");
            //Console.WriteLine("4 Lägg till adress");
            //Console.WriteLine("5. Avsluta");

            string menuChoice = Console.ReadLine();//sparar användarens text
            Console.Clear();
            switch (menuChoice) //städar upp konsollen lite
            {
                case "1"://jämför det jag sparat från användaren
                    Console.WriteLine("skriv Namn:");
                    string input = Console.ReadLine();
                    Contact.AddNameToList(input, userInputList);//öppnar en portal och "speglar" innehållet här med contact
                    break;

                //    case "2":
                //    Console.WriteLine("Inmatningar:");
                //    foreach (string information in userInputList) 
                //    { 
                //        Console.WriteLine(information); 
                //    }
                //    break;

                //case "5":
                //    Console.WriteLine("Avslutar...");
                //    isRunning = false;
                //    break;

                default:
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    break;

            }
        }
    }
}

                    