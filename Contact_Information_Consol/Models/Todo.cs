

namespace Contact_Information_Consol.Models;

public class Todo// här hanterar vi våra brev. deras adress och status. i servie hämtar brevbärare in nya brev och håller kolla på brevens status
{
    public string Description { get; set; }//set och get kunde jag inte se när jag stegade igenom med breakpoints. 
    public bool IsCompleted { get; set; }// set för att tilldela värde. get för att hämta värde

    //
    public Todo(string description) //parametern(värdet) jag skickar som item object. sedan tar den tar value och kopplar till konstruktorn
    {//här nere är konstruktorn
        Description = description;//tar objectet av typen Todo som har en beskrivning via set och en stämpel av false via set
        IsCompleted = false;
        //vi skickar in ett öppet brev som sätts dit på våran lista och får en stämpel av false
        //vi lämnar över det till TodoList.cs där den sätter upp allt på lista
        //här konstruerar vi hur den ska se ut. men TodoList.cs är där vi ser alla nya items och håller koll på om de är klara eller ej.
    }
}
