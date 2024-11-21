using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Information_Consol //tillhör samma namespace som resten av projektet
{
    public static class Rock_Paper_Scissors //klassens namne
    {
        public static void Play()// för att vara tillgänglig
        {
            //Console.WriteLine("Välkommen till spelet, det finns inte än men är på G");

            bool continuefightingHans = true;// håller kolla om vi ska forsätta spela
            var rock = "1";
            var scissors = "2";
            var paper = "3";
            do
            {
                Console.WriteLine("write Rock, Paper or Scissors. skriv klar för att avsluta");
                var userHand = Console.ReadLine().ToLower();

                Random random = new Random();
                var computerHans = random.Next(1, 4);

                if ((userHand == "rock" && computerHans == 2) ||
                (userHand == "scissors" && computerHans == 3) ||
                (userHand == "paper" && computerHans == 1))
                {
                    Console.WriteLine("You Won!, Hans lost");
                }
                else if
                ((userHand == "rock" && computerHans == 3) ||
                    (userHand == "scissors" && computerHans == 1) ||
                    (userHand == "paper" && computerHans == 2))
                {
                    Console.WriteLine("You lost!, Hans won!");
                }
                else if ((userHand == "rock" && computerHans == 1) ||
                    (userHand == "scissors" && computerHans == 2) ||
                    (userHand == "paper" && computerHans == 3))
                {
                    Console.WriteLine("Its a draw");
                }
                else
                {
                    Console.WriteLine("du måste använda näven!");
                }

                Console.WriteLine("orkar du spela mer? (ja/nej)");
                string answer = Console.ReadLine().ToLower();
                if (answer == "nej")
                {
                    continuefightingHans = false;//avslutar fighten
                }
            } while (continuefightingHans);


        }
    }
}
