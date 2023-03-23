using System.ComponentModel.DataAnnotations;

namespace projetASSagy_front1.Classes;

public class User
{
    public User()
    {
    }

    public User(int id, string nom, string prenom, string username, int point)
    {
        this.id = id;
        this.nom = nom;
        this.prenom = prenom;
        this.username = username;
        this.point = point;
    }
    
    public User(int id, string nom, string prenom, string username, int point, string[] roles)
    {
        this.id = id;
        this.nom = nom;
        this.prenom = prenom;
        this.username = username;
        this.point = point;
        this.role = roles;
    }

    public User(int point)
    {
        id = 0;
        nom = "TOTAL";
        prenom = "TOTAL";
        username = "";
        this.point = point;
    }

    public int id { get; set; }

    [Required] public string nom { get; set; }

    [Required] public string prenom { get; set; }

    [Required] public string username { get; set; }
    public string[] role { get; set; }

    public int point { get; set; }
}