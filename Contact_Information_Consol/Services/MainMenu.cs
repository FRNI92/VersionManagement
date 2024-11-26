﻿using System;

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
            Console.WriteLine("Välj ett alternativ:");
            Console.WriteLine("1. Lägg till Namn");
            Console.WriteLine("2. Lägg till ålder");
            //Console.WriteLine("3. Lägg till telefonnummer");
            //Console.WriteLine("4 Lägg till adress");
            Console.WriteLine("5. Skriv ut listan");
            Console.WriteLine("6. Sten Sax Påse");
            Console.WriteLine("7. Fixed deposit Account-Calculator");
            Console.WriteLine("8. Stefans-Calc");
            //Console.WriteLine("9. Fight The Boss"); gör detta senare
            Console.WriteLine("10. saker som ska fixas");


            string menuChoice = Console.ReadLine();//sparar användarens text
            Console.Clear();
            switch (menuChoice) //städar upp konsollen lite
            {
                case "1"://jämför det jag sparat från användaren
                    Console.WriteLine("skriv Namn:");
                    string input = Console.ReadLine(); //? string får vara null
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

                case "8":
                    SuperCalculator.Run();
                    break;

                case "10":
                    Console.WriteLine("Do you want to open the todolist-menu?\n ja\t/\tnej");
                    string toDoAnswer = Console.ReadLine()?.ToLower();

                    if (toDoAnswer == "ja")
                    {
                        Console.WriteLine("shut up");
                        //ToDoList.Run();
                    }
                    else if (toDoAnswer == "nej")
                    {
                        Console.WriteLine("do nothing");
                    }
                    else
                    {
                        Console.WriteLine("inte okej gör om");
                    }
                    break;

                default:
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    break;

            }

        }
    }
}

