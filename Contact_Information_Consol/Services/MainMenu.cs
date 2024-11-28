using System;

namespace Contact_Information_Consol.Services;

public static class MainMenu
{
    public static void Run()
    {
        
        //Console.WriteLine("Startar ContactList..."); // testar contaclist direkt genom contactList.Run();
        //ContactList.Run();

        List<string> userInputList = [];//skapar en List string som är tom
        bool isRunning = true;//skapar en boolvariabel som jag sätter till true. så att koden körs.
        
        while (isRunning)// isRunning får "stämpeln" av true eller false. true i detta fall
        {
            Console.Clear();
            Console.WriteLine("Välj ett alternativ:");
            Console.WriteLine("1. Sten Sax Påse");
            Console.WriteLine("2. Fixed deposit Account-Calculator");
            Console.WriteLine("3. Stefans-Calc");
            Console.WriteLine("4. saker som ska fixas");
            Console.WriteLine("5. Skapa en lista");
            //Console.WriteLine("5. Fight The Boss"); gör detta senare


            string menuChoice = Console.ReadLine();//sparar användarens text
            Console.Clear();
            switch (menuChoice) //städar upp konsollen lite
            {

                case "1":
                    Console.WriteLine("vill du spela Sten sax påse? skriv ja ");
                    string? answer = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(answer)) 
                    {
                        if (answer.ToLower() == "ja")
                        {
                        Rock_Paper_Scissors.Play();//anropar filen med spelet

                        }
                    }
                    else
                    {
                        Console.WriteLine("Går tillbaka till menyn...");
                    }
                    break;

                case "2":
                    Console.WriteLine("vill du ha hjälp med banken skriv 'Bank'. anykey för att back");
                    string calcAnswer = Console.ReadLine();
                    if (calcAnswer.ToLower() == "bank")
                    {
                        Calculator.CalcBank();
                    }

                    else
                    {
                        Console.WriteLine("Går tillbaka till menyn...");
                    }
                    break;

                case "3":
                    SuperCalculator.Run();
                    break;

                case "4":
                    Console.WriteLine("Do you want to open the todolist-menu?\n ja\t/\tnej");
                    string toDoAnswer = Console.ReadLine()?.ToLower();

                    if (toDoAnswer == "ja")
                    {
                       
                        TodoList.Run();
                    }
                    else if (toDoAnswer == "nej")
                    {
                        Console.WriteLine("do nothing");
                    }
                    else
                    {
                        Console.WriteLine("inte okej gör om");

                    }
                    Console.ReadKey();
                    break;

                case "5":
                    {
                        ContactList.Run();
                        break;
                    }


                default:
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    break;

            }

        }
    }
}


