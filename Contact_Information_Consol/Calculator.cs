using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*lägg till val på hur länge man vill spara
 iterera genom alla användarens konton för att generera en totalsumma*/
namespace Contact_Information_Consol
{
    public static class Calculator
    {
        public static void CalcBank()
        {
            List<int> bankAccount = [];

            Console.WriteLine("skriv in hur mycket du vill sätta in på ditt fasträntekonto");
            string money = Console.ReadLine();

            if (int.TryParse(money, out int mmoney))
            {
                bankAccount.Add(mmoney);
                Console.WriteLine($"Du har angett beloppet: {mmoney} kr");
            }
            else
            {
                Console.WriteLine("ogiltig inmatning. skriv minst en siffra och inga decimaler");
            }

            foreach (int bank in bankAccount)
            {
                decimal interest = 0.038m;
                decimal timeInBank = 92;
                decimal earnedInterest = ((bank * (timeInBank / 365)) * interest);
                decimal result = (bank + earnedInterest);
                decimal uncleSam = (earnedInterest * 0.33m);
                Console.WriteLine($"om du tar ditt konto med: {bank} och sätter på ett fasträntekonto \n" +
                                   $"med en ränta på {interest * 100}% i 3 månader, kommer du tjäna {earnedInterest} kr\n" +
                                   $"vilket genererar en summa på {result}\n" +
                                   $"Sedan måstedu skatta 33% på {earnedInterest}. Du kommer alltså slutändan tjäna {earnedInterest - uncleSam}");
                Console.ReadKey();
            }
        }
    }
}
