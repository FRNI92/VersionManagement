using Contact_Information_Consol.Services;
using System; //gör att man kan använda consoleWrite/read och datatyper
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates; //gör att vi kan använda List

//flyttade switchen och all lokig till 'MainMenu' och la den i mappen Services

class ProgramMenu // den här klassen ska innehålle Main
{
    static void Main(string[] args)
    {
        MainMenu.Run();
        
    }
}

                    