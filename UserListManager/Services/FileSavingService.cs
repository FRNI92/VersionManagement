using System.Text.Json;
using UserListManager.Models;

namespace UserListManager.Services;
public class FileSavingService
{
    public string filePath = "user.json";

    public void SaveToFile(List<UserTemplate> UserTemplates)
    {
        var json = JsonSerializer.Serialize(UserTemplates, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }

    public List<UserTemplate> LoadFromFile() 
    {
        if (!File.Exists(filePath)) return new List<UserTemplate>();
        var json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<UserTemplate>>(json) ?? new List<UserTemplate>();
    }
}
