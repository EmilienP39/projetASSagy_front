using MudBlazor;

namespace projetASSagy_front1.Classes;

public class UserAvantage
{
    public UserAvantage()
    {
        this.id = 0;
        this.commentaire = "";
        this.isValide = false;
        this.created = new DateTime();
        this.points = 0;
        this.user = new User();
        this.avantage = new Avantage();
    }

    public UserAvantage(int id, string commentaire, bool isValide, DateTime created, int points)
    {
        this.id = id;
        this.commentaire = commentaire;
        this.isValide = isValide;
        this.created = created;
        this.points = points;
        this.user = new User();
        this.avantage = new Avantage();
    }
    
    public UserAvantage(int id, string commentaire, bool isValide, DateTime created, int points,Avantage avantage, User user)
    {
        this.id = id;
        this.commentaire = commentaire;
        this.isValide = isValide;
        this.created = created;
        this.points = points;
        this.user = user;
        this.avantage = avantage;
    }

    public int id { get; set; }
    public string commentaire { get; set; }
    public bool isValide { get; set; }
    public DateTime? created { get; set; }
    public int points { get; set; }
    public Avantage avantage { get; set; }
    public User user { get; set; }

    public override string ToString()
    {
        return "id: " + id + " commentaire: " + commentaire + " isValide: " + isValide + " created: " + created + " points: " + points;
    }
}