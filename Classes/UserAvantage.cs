namespace projetASSagy_front1.Classes;

public class UserAvantage
{
    public int id { get; set; }
    public string commentaire { get; set; }
    public bool isValide { get; set; }
    public string created { get; set; }
    public int points { get; set; }
    public int idAvantage { get; set; }

    public UserAvantage()
    {
        
    }

    public UserAvantage(int id, string commentaire, bool isValide, string created, int points, int avantage)
    {
        this.id = id;
        this.commentaire = commentaire;
        this.isValide = isValide;
        this.created = created;
        this.points = points;
        this.idAvantage = avantage;
    }
}