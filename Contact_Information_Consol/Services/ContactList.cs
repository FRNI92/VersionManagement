using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Information_Consol.Services
{
    public static class ContactList
    {
        public static void Run()
        {
            List<string> userInputList = [];
            string userChoiceContact;
            do
            {
                Console.WriteLine("Kontaktuppgifter");
                Console.WriteLine("1. Lägg till ett namn");
                Console.WriteLine("2. lägg till ålder");
                Console.WriteLine("3. lägg till email");
                Console.WriteLine("4. lägg till telefonnummer");
                Console.WriteLine("5. Gå tillbaka till huvudmenyn");


                userChoiceContact = Console.ReadLine();
                switch (userChoiceContact)
                {
                    case "1":
                        Console.Write("Skriv ditt namn");
                        string namn = Console.ReadLine();
                        userInputList.Add(namn);
                        Console.WriteLine("Namn tillagt\n");
                        break;

                    case "2":
                        Console.Write("Skriv din ålder");
                        string ageInput = Console.ReadLine();

                        if (int.TryParse(ageInput, out int age))
                        {
                            Console.WriteLine($"Din ålder är {age}");
                        }
                        else
                        {
                            Console.WriteLine("Du måste ange siffor. exempelvis '5' '22' '45' ");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Fyll i din email");
                        string email = Console.ReadLine();
                        Console.Write($"email tillagd: {email}");
                        break;

                    case "4":
                        Console.WriteLine("Lägg till telefonnummer");
                        string telefonInput = Console.ReadLine();

                        if (int.TryParse(telefonInput, out int telefon))
                        {
                            Console.WriteLine("telefonnummer tillagd");
                        }
                        else
                        {
                            Console.WriteLine("du måste skriva siffror, exempelvis '070 11 88 318");

                        }
                        break;

                    case "5":
                        Console.WriteLine("tillbaka till huvudmenyn");
                        return;

                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }
            }
            while (userChoiceContact != "5");
        }
    }
}




