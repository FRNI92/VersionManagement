using System;
using System.Linq;
namespace Contact_Information_Consol
{
    class SuperCalculator
    {
        //döpte om lite saker för att inte krocka med min main
        public static void Run()
        {
            // Ber användaren om antal siffror att mata in
            Console.Write("Hur många siffror vill du mata in? ");
            if (!int.TryParse(Console.ReadLine(), out int antal) || antal <= 0)//hanterar utfallet direkt så man slipper flera if else. om det inte går hoppas man till brackets
            {
                Console.WriteLine("Ogiltig inmatning. Försök igen med ett positivt heltal.");
                return;
            }

            // Array för att lagra användarens siffror
            double[] yourNumbers = new double[antal];

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

        static void Minimum(double[] yourNumbers)
        {
            Console.WriteLine("Minimum är " + yourNumbers.Min());
        }

        static void Average(double[] yourNumbers)
        {
            Console.WriteLine("Medelvärdet är " + yourNumbers.Average());
        }

        static void Maximum(double[] yourNumbers)
        {
            Console.WriteLine("Maximum är " + yourNumbers.Max());
        }
    }
}
