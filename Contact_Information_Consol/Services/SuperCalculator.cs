using System;
using System.ComponentModel.Design;
using System.Linq;
namespace Contact_Information_Consol.Services
{
    class SuperCalculator
    {
        //döpte om lite saker för att inte krocka med min main
        public static void Run()
        {
            // Ber användaren om antal siffror att mata in
            Console.Write("Hur många siffror vill du mata in? ");
            if (!int.TryParse(Console.ReadLine(), out int antal) || antal <= 0)/*
                                                            * hanterar utfallet direkt så man slipper flera if else. om det inte går hoppar man till brackets
                                                            * <= 0 andra argumentet bryr sig bara om vad första argumentet har fått för svar 
                                                            */
            {
                Console.WriteLine("Ogiltig inmatning. Försök igen med ett positivt heltal.");//
                return;
            }
            // Array för att lagra användarens siffror
            double[] yourNumbers = new double[antal];// kan vara smidigare med en List

            // Tar emot inmatning från användaren
            for (int i = 0; i < antal; i++)
            {
                Console.Write($"Ange siffra {i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out yourNumbers[i]))
                {
                    Console.WriteLine("Ogiltig siffra. Försök igen.");
                }
            }

            // Beräknar och skriver ut resultat
            Minimum(yourNumbers);
            Average(yourNumbers);
            Maximum(yourNumbers);

            Console.WriteLine("\nTryck på valfri tangent för att återgå till huvudmenyn...");
            Console.ReadKey();
        }

        public static void Minimum(double[] yourNumbers)
        {
            Console.WriteLine("Minimum är " + yourNumbers.Min()); //enablas av linq, inbyggda functioner
        }

        public static void Average(double[] yourNumbers)
        {
            Console.WriteLine("Medelvärdet är " + yourNumbers.Average()); // jag gör alla public så att jag kan anropa dem från andra delar. kanske från bankdelen
        }

        public static void Maximum(double[] yourNumbers)
        {
            Console.WriteLine("Maximum är " + yourNumbers.Max());
        }
    }
}
