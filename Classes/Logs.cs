namespace projetASSagy_front1.Classes;

public class Logs
{
    public string username { get; set; }
    public string password { get; set; }

    public Logs(string username, string password)
    {
        this.username = username;
        this.password = password;
    }
}