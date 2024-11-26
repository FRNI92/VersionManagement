
namespace Contact_Information_Consol.Services
{
    public static class ContactList
    {
        public static void Run()
        {
            List<string> userInputList = [];//skapar en List string som är tom
            bool isRunning = true;

            while (isRunning) 
            {
                    Console.Clear();
                    Console.WriteLine("Kontaktuppgifter");
                    Console.WriteLine("1. Lägg till ett namn");
                    Console.WriteLine("2. lägg till ålder");
                    Console.WriteLine("3. lägg till email");
                    Console.WriteLine("4. lägg till telefonnummer");
                    Console.WriteLine("5. Titta på listan");
                    Console.WriteLine("6. Gå tillbaka till huvudmenyn");

                    string? userChoiceContact = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(userChoiceContact))
                    {
                        Console.Write("Ogiltigt, försök igen");
                    }
     
                    switch (userChoiceContact)
                    {

                        case "1"://jämför det jag sparat från användaren
                            Console.Write("skriv Namn:");
                            string input = Console.ReadLine(); //? string får vara null
                            RegexHelper.AddNameToList(input, userInputList);//öppnar en portal och "speglar" innehållet här med contact
                            break;

                        case "2":
                            Console.Write("Skriv in din ålder:");
                            string ageInput = Console.ReadLine();
                            userInputList.Add(ageInput);
                            Console.WriteLine($"åldern '{ageInput}' har lagts till i listan.");
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
                            foreach (string info in userInputList)
                                Console.WriteLine($"-- {info}");
                            break;

                        case "6":
                            Console.WriteLine("tillbaka till huvudmenyn");
                            return;

                        default:
                            Console.WriteLine("Ogiltigt val, försök igen.");
                            break;
                    }
                Console.ReadKey();

            }            
        }
    }
}




