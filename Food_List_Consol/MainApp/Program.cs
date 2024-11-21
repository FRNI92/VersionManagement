using System.Text.RegularExpressions;

Console.WriteLine("Det är apocalypse imorgon. du måste ha mat.Gör en lista på vad som ska införskaffas");

List<string> foodList = [];
string input; 
Regex onlyFood = new Regex(@"^[a-zA-ZåäöÅÄÖ\s]+$"); 


do
{
    Console.WriteLine("Vad vill du ha på din lista? (skriv 'klar' för att avsluta)");
    input = Console.ReadLine();
    Console.Clear();

    if (input.ToLower() != "klar")
    {
        if (onlyFood.IsMatch(input)) 
        { 
        foodList.Add(input);
        Console.WriteLine($"Du har lagt till: {input}:");
        
        }
        else
        {
            Console.WriteLine("Endast bokstäver a-ö och mellanslag är tillåtna");
        }

        
        Console.WriteLine("din uppdaterade lista");
        foreach (string food in foodList)
        {
            Console.WriteLine($" .{food}");
        }
    }

    } while (input.ToLower() != "klar");
        Console.WriteLine("\nDin shoppinglist:");
        foreach (string food in foodList)
    { 
        Console.WriteLine($" - {food}");
    }