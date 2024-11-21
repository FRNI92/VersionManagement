using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Information_Consol
{
    public static class Calculator
    {
        public static void CalcBank()
        {
            Console.WriteLine("skriv in ett tal så kommer jag räkna ut en sak åt dig");
            string money = Console.ReadLine();

            if (int.TryParse(money, out int mmoney))
            {

                Console.WriteLine($"Du har angett bloppet: {mmoney}");
            }
            else
            {
                Console.WriteLine("ogiltig inmatning");
            }
        }
    }
}
