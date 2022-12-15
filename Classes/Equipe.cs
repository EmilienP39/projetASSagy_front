using System.ComponentModel.DataAnnotations;

namespace projetASSagy_front1.Classes;

public class Equipe
{
    public int id { get; set; }
    
    [Required]
    public Boolean isSenior { get; set; }
    [Required]
    public string nom { get; set; }
    [Required]
    public double cotisationBase { get; set; }
    
    public List<User> users { get; set; }

    public Equipe()
    {
        
    }
    
    public Equipe(int id, Boolean isSenior,string nom, double cotisationBase)
    {
        this.id = id;
        this.isSenior = isSenior;
        this.nom = nom;
        this.cotisationBase = cotisationBase;
        this.users = new List<User>();
    }
    
    public Equipe(Boolean isSenior,string nom, double cotisationBase)
    {
        this.id = 0;
        this.isSenior = isSenior;
        this.nom = nom;
        this.cotisationBase = cotisationBase;
        this.users = new List<User>();
    }
}