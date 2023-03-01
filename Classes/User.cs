using System.ComponentModel.DataAnnotations;

namespace projetASSagy_front1.Classes;

public class User
{
    public int id { get; set; }
    [Required]
    public string nom { get; set; }
    [Required]
    public string prenom { get; set; }
    [Required]
    public string username { get; set; }
    public int point { get; set; }

    public User()
    {
        
    }

    public User(int id, string nom, string prenom, string username,int point)
    {
        this.id = id;
        this.nom = nom;
        this.prenom = prenom;
        this.username = username;
        this.point = point;
    }
    public User(int point)
    {
        this.id = 0;
        this.nom = "TOTAL";
        this.prenom = "TOTAL";
        this.username = "";
        this.point = point;
    }
}