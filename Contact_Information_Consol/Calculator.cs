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


            Console.WriteLine("Vad vill du öppna för konto?");
            Console.WriteLine("1. Fasträntekonto");
            Console.WriteLine("2. Sparkonto");
            string accountChoice = Console.ReadLine();
            accountChoice.ToLower();

            switch (accountChoice)
            {
                case "1":
                    OpenAccount("fasträntekonto");
                    break;

                case "2":
                    OpenAccount("Sparkonto");
                    break;
                default:
                    Console.WriteLine("välj ett konto");
                    break;



            }
        }
        
public static void OpenAccount(string account)

    {
            List<decimal> bankAccount = [];

            Console.WriteLine("du valde att öppna ett fasträntekonto");
        Console.WriteLine("hur mycket vill du sätta in?");
        string moneyInFixedDeposit = Console.ReadLine();
        if (decimal.TryParse(moneyInFixedDeposit, out decimal depositAmount))
        {
            bankAccount.Add(depositAmount);
            Console.WriteLine("hur länge vill du spar? (i dagar)");
            string moneySaveTimeInput = Console.ReadLine();
                if (decimal.TryParse(moneySaveTimeInput, out decimal moneySaveTime))
                {
                    Console.WriteLine($"du har valt att spara {moneyInFixedDeposit} kr i  {moneySaveTime} dagar");
                    Console.WriteLine("låt mig räkna ut detta åt dig");
                    foreach (int bank in bankAccount)
                    {


                        decimal interest = 0.038m;
                        decimal earnedInterest = ((bank * (moneySaveTime / 365)) * interest);
                        decimal result = (bank + earnedInterest);
                        decimal uncleSam = (earnedInterest * 0.33m);
                        Console.WriteLine($"om du tar ditt konto med: {bank} och sätter på ett fasträntekonto \n" +
                                           $"med en ränta på {interest * 100}% i {moneySaveTime} dagar, kommer du tjäna {earnedInterest} kr\n" +
                                           $"vilket genererar en summa på {result}\n" +
                                           $"Sedan måstedu skatta 33% på {earnedInterest}. Du kommer alltså slutändan tjäna {earnedInterest - uncleSam}");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Ogiltig sparperiod, ange heltal. du kan inte ha pengarna här en del av en dag");
                }
            }
            else
            {
                Console.WriteLine("Ogiltigt belopp, ange ett giltigt belopp");
            }
            //public static int GetUserInput()kanske behöver den här när jaghar flera konton
            //{
            //    try
            //    {
            //        Console.WriteLine("Ange ett heltal:");
            //        int input = int.Paarse(Console.ReadLine());
            //        return input;
            //    }
            //    catch {FormatException) {
            //            Console.WriteLine("Fel, du måste ange ett heltal.");
            //            return -1;
            //        }
            //}




            //string money = Console.ReadLine();

            //if (int.TryParse(money, out int mmoney))
            //{
            //    bankAccount.Add(mmoney);
            //    Console.WriteLine($"Du har angett beloppet: {mmoney} kr");
            //}
            //else
            //{
            //    Console.WriteLine("ogiltig inmatning. skriv minst en siffra och inga decimaler");
            //}


            //foreach (int bank in bankAccount)
            //{
            //    decimal interest = 0.038m;
            //    decimal timeInBank = 92;
            //    decimal earnedInterest = ((bank * (timeInBank / 365)) * interest);
            //    decimal result = (bank + earnedInterest);
            //    decimal uncleSam = (earnedInterest * 0.33m);
            //    Console.WriteLine($"om du tar ditt konto med: {bank} och sätter på ett fasträntekonto \n" +
            //                       $"med en ränta på {interest * 100}% i 3 månader, kommer du tjäna {earnedInterest} kr\n" +
            //                       $"vilket genererar en summa på {result}\n" +
            //                       $"Sedan måstedu skatta 33% på {earnedInterest}. Du kommer alltså slutändan tjäna {earnedInterest - uncleSam}");
            //    Console.ReadKey();
            //}
        }
    }
}
