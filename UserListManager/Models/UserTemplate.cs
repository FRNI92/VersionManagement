namespace UserListManager.Models;

public class UserTemplate
{
    public string Name { get; set; }
    public string Email { get; set; }

    public DateTime Created { get; set; } // gör inte denna som en public string
    
        public UserTemplate(string name, string email)
        {
        Name = name;
        Email = email;
        Created = DateTime.Now;
        }
}
