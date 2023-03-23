namespace projetASSagy_front1.Classes;

public class Server
{
    private string serverUrl = "https://localhost:8000/";

    public string getUrl()
    {
        return this.serverUrl;
    }
}