using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


//g�r en meny. problem: beh�ver g�ra om vissa delar till private s� inte andra delar av programmet modifierar min regex

   /*flyttar upp regex namespace till de andra namespace l�ngst upp p� sidan
    * flyttar ned classen s� man ser vart contact b�rjar
    * provar att g�ra regex private 
    den startar alltid min gamla Contact
   Provede att l�gga st�rre delen av koden i en tempor�r klass s� att den inte skulle k�ras. gick inte.
   provade att BUILD-Clean-Rebuld men det gick inte.
   tog bort all kod i Contact och la till endast det ny som ska jobba med menyn. nu kunde jag k�ra Program och den verkar fungera r�tt. 
   det satt en "{" p� ett st�lle som st�rde hela projektet samt att jag tror att den gamla koden exekverades p�grund av att den l�g utanf�r min Contact klass*/
/*  Fr�ga om kontaktuppgifter
Namn?check
kontrollera namncheck
�lder?
spara �lder
skriv ut �lder
*/

public static class Contact
{
    private static Regex nameCheck = new Regex(@"^[a-zA-Z]+$");

    public static void AddNameToList(string input, List<string> userInputList) /*portal och spegling. f�rtydligar att det �r string. 
                                                                                userInputList f�r inget v�rde f�rr�n klarat Regex*/
    {
        if (nameCheck.IsMatch(input)) // j�mf�r med regex
        {
            userInputList.Add(input);//uppdaterar List
            Console.WriteLine($"Namnet '{input}' har lagts till i listan.");
        }
        else
        {
            Console.WriteLine("Ogiltigt namn. Endast bokst�ver till�tna. F�rs�k igen.");
        }
    }
}

