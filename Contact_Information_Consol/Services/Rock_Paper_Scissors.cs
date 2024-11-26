using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Information_Consol.Services //tillhör samma namespace som resten av projektet
{
    public static class Rock_Paper_Scissors //klassens namne
    {
        public static void Play()// för att vara tillgänglig
        {



            List<string> hansHandSign = [];
            List<string> userHandSign = [];



            //Console.WriteLine("Välkommen till spelet, det finns inte än men är på G");

            bool continuefightingHans = true;// håller kolla om vi ska forsätta spela
            //var rock = "1"; gör om detta till en array
            //var scissors = "2";
            //var paper = "3";
            string[] hands = { "rock", "scissors", "paper" }; // innehåller fasta värden, ej dynamisk som List
            do
            {
                Console.WriteLine("write Rock, Paper or Scissors.");
                var userHand = Console.ReadLine().ToLower();//tar input och gör det till små bokstäver

                Random random = new Random(); //kallar på en inbyggd class. kommer från using. men den "väcks" till liv med new
                var computerHans = random.Next(1, 4); // 1/2/3 genererar något av dessa tal. en method i randomklassen som tar argument så som 1 och 4
                string hansHand = hands[computerHans - 1]; //rock har index 0 så vi drar bort med -1. kanske kan priva att ändra random.next från 0-3 men jag har andra problem

                //jämför användarens "gissining" med datorn
                if (userHand == "rock" && computerHans == 2 ||// AND och OR operander
                userHand == "scissors" && computerHans == 3 ||
                userHand == "paper" && computerHans == 1)
                {
                    Console.WriteLine("You Won!, Hans lost");
                }
                else if
                (userHand == "rock" && computerHans == 3 ||
                    userHand == "scissors" && computerHans == 1 ||
                    userHand == "paper" && computerHans == 2)
                {
                    Console.WriteLine("You lost!, Hans won!");
                }
                else if (userHand == "rock" && computerHans == 1 ||
                    userHand == "scissors" && computerHans == 2 ||
                    userHand == "paper" && computerHans == 3)
                {
                    Console.WriteLine("Its a draw");
                }
                else
                {
                    Console.WriteLine("du måste använda näven!");
                }
                userHandSign.Add(userHand);//add är en method i List
                hansHandSign.Add(hansHand);
                Console.WriteLine($"\tDu valde {userHand}\n\tHans valde: {hansHand}");
                Console.WriteLine("orkar du spela mer? (ja/nej)");
                string answer = Console.ReadLine().ToLower();
                if (answer == "nej")
                {
                    continuefightingHans = false;//avslutar fighten

                }

            } while (continuefightingHans);
            int userRock = 0;
            for (int i = 0; i < userHandSign.Count; i++)// den här ska visa hur många gånger man valt en viss näve. kan utökas
            {
                if (userHandSign[i] == "rock")
                {
                    userRock++;
                }
            }
            Console.WriteLine($"Du valde rock {userRock}: Gånger");
        }
    }
}
