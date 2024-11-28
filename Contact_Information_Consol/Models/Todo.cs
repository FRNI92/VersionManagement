

namespace Contact_Information_Consol.Models;

public class Todo// här hanterar vi våra brev. deras adress och status. i servie hämtar brevbärare in nya brev och håller kolla på brevens status
{
    public string Description { get; set; }
    public bool IsCompleted { get; set; }

    public Todo(string description)
    {
        Description = description;
        IsCompleted = false;
    }
}
