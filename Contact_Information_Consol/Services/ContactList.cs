
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
                        Console.ReadKey();
                        continue;
                    }
     
                    switch (userChoiceContact)
                    {

                        case "1"://jämför det jag sparat från användaren
                        Console.Write("skriv Namn:");
                            string? input = Console.ReadLine(); //? string får vara null
                        if (string.IsNullOrWhiteSpace(input)) //anropar class string och använder inbyggd metod isnull för att kolla string-input
                        {
                            Console.Write("du får inte skicka in tomma värden");

                        }
                        else
                        {
                            RegexHelper.AddNameToList(input, userInputList);//öppnar en portal och "speglar" innehållet här med contact
                        }
                            break; //stoppar exekveringen av switchen

                        //med breakpoints kan man köra igång utan att behöve gå igenom hela programmet. smidigare än att lägga ContactList.Run() på Main
                        case "2":
                            Console.Write("Skriv in din ålder:");

                            string? ageInput = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(ageInput)) //här vill jag också kolla om det är mer än 0
                        {
                            Console.WriteLine("Det får inte vara tomt");//skrivs om is null är true annar skippar vi
                            break;
                        }
                        if (int.TryParse(ageInput, out int yearsInNumber) && yearsInNumber > 0) // osäker på om if bör användas såhär men det funkar
                        {
                            userInputList.Add($"Age:{yearsInNumber}");
                            Console.WriteLine($"åldern '{yearsInNumber}' har lagts till i listan.");//skrirs om den lyckas konvertera och det som konverterats är mer än 0
                            //Console.ReadKey();
                            break;
                        }
     
                        else
                        {
                            Console.Write("Det måste vara en siffra och den måste vara högre än 0");
                        }
                        break;
                            
                        case "3":
                        Console.Write("Skriv in din email");
                        string? emailAdress = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(emailAdress))
                        {
                            Console.WriteLine("Du måste skriva in något här faktist");
                        }
                        else
                        {
                            userInputList.Add(emailAdress);
                            Console.WriteLine($"Din email: {emailAdress} är tillagd");
                        }

                        break;


                        case "4":
                            Console.WriteLine("Lägg till telefonnummer");
                            string? telefonInput = Console.ReadLine();

                            if (long.TryParse(telefonInput, out _))
                            {
                            Console.WriteLine($"telefonnummer {telefonInput} tillagd");
                            userInputList.Add($"Telephonenumber: {telefonInput}");
                            }
                            else
                            {
                            Console.WriteLine("du måste skriva siffror, exempelvis 070 11 88 318");
                            }
                            break;

                        case "5":
                            Console.WriteLine("Här har du listan");
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




