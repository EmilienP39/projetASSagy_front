using System.ComponentModel.DataAnnotations;

namespace projetASSagy_front1.Classes;

public class Equipe
{
    public Equipe()
    {
    }

    public Equipe(int id, bool isSenior, string nom, double cotisationBase)
    {
        this.id = id;
        this.isSenior = isSenior;
        this.nom = nom;
        this.cotisationBase = cotisationBase;
        users = new List<User>();
    }

    public Equipe(bool isSenior, string nom, double cotisationBase)
    {
        id = 0;
        this.isSenior = isSenior;
        this.nom = nom;
        this.cotisationBase = cotisationBase;
        users = new List<User>();
    }

    public int id { get; set; }

    [Required] public bool isSenior { get; set; }

    [Required] public string nom { get; set; }

    [Required]
    [Range(20, 150, ErrorMessage = "La cotisation doit être comprise entre 20 et 150 euros")]
    public double cotisationBase { get; set; }

    public List<User> users { get; set; }
}