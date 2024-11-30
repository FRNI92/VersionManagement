using System.Text.Json;
using UserListManager.Models;

namespace UserListManager.Services;
public class FileSavingService
{
    public string filePath = "user.json";

    public void SaveToFile(List<UserTemplate> UserTemplates)
    {//using text json gör att vi kan köra new på JsonSerial och skapa en instans av classen och använder metoden serialize 
        var json = JsonSerializer.Serialize(UserTemplates, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }/*writeIndented=true formaterar så att json kan läsa våra object
      new jsnserializeroptions skapar en instans av classen så att vi kan använda WriteIndented köra hela objectet userTemplates genom den
    jsonserializer.serialize gör att den går att spara i var json
   sedan skriver vi vart vi vill spara sakerna och vilken variabel vi vill spara
    Man få läsa det här lite baklänges. ta objectet UserTemplates och formatera det med WriteIndented sedan konvertera med serialize och spara i var json*/

    public List<UserTemplate> LoadFromFile() 
    {
        if (!File.Exists(filePath)) return new List<UserTemplate>();
        var json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<UserTemplate>>(json) ?? new List<UserTemplate>();
    }
}
