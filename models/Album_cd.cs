using System.ComponentModel.DataAnnotations;

namespace A_DOT_NET.models;

public class Album_cd
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }
    public String? Artist { get; set; }
    public albumGenre Genre { get; set; }
    

    [Range(0.01, 9999.99)]
    public decimal Price { get ; set; }
}

public enum albumGenre { Pop, Gospel, HipHop }