using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


//gör en meny. problem: behöver göra om vissa delar till private så inte andra delar av programmet modifierar min regex

   /*flyttar upp regex namespace till de andra namespace längst upp på sidan
    * flyttar ned classen så man ser vart contact börjar
    * provar att göra regex private 
    den startar alltid min gamla Contact
   Provede att lägga större delen av koden i en temporär klass så att den inte skulle köras. gick inte.
   provade att BUILD-Clean-Rebuld men det gick inte.
   tog bort all kod i Contact och la till endast det ny som ska jobba med menyn. nu kunde jag köra Program och den verkar fungera rätt. 
   det satt en "{" på ett ställe som störde hela projektet samt att jag tror att den gamla koden exekverades pågrund av att den låg utanför min Contact klass*/
/*  Fråga om kontaktuppgifter
Namn?check
kontrollera namncheck
ålder?
spara ålder
skriv ut ålder
*/

public static class Contact
{
    private static Regex nameCheck = new Regex(@"^[a-zA-Z]+$");

    public static void AddNameToList(string input, List<string> userInputList) /*portal och spegling. förtydligar att det är string. 
                                                                                userInputList får inget värde förrän klarat Regex*/
    {
        if (nameCheck.IsMatch(input)) // jämför med regex
        {
            userInputList.Add(input);//uppdaterar List
            Console.WriteLine($"Namnet '{input}' har lagts till i listan.");
        }
        else
        {
            Console.WriteLine("Ogiltigt namn. Endast bokstäver tillåtna. Försök igen.");
        }
    }
}

