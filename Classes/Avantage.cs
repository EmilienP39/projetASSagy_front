using System.ComponentModel.DataAnnotations;

namespace projetASSagy_front1.Classes;

public class Avantage
{
    public int id { get; set; }
    [Required]
    public string libelle { get; set; }
    [Required]
    public int points { get; set; }
    [Required]
    public int categorie { get; set; } //0 les deux  1 sénior  2 jeune

    public Avantage()
    {
        
    }
    
    public Avantage(int id_, string libelle_, int points_, int categorie_)
    {
        this.id = id_;
        this.libelle = libelle_;
        this.points = points_;
        this.categorie = categorie_;
    }
    
    public Avantage(string libelle_, int points_, int categorie_)
    {
        this.id = 0;
        this.libelle = libelle_;
        this.points = points_;
        this.categorie = categorie_;
    }
}