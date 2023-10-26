using System.ComponentModel.DataAnnotations;

namespace A_DOT_NET.models;

public class Album_cd
{
    [Key]
    public int Album_id { get; set; }

    [Required]
    public string? Album_name { get; set; }
    [Required]
    public String? Artist_name { get; set; }
    public AlbumGenre Genre { get; set; }
    
    

    [Range(0.01, 9999.99)]
    public decimal Price { get ; set; }
}

public enum AlbumGenre { Pop, Gospel, HipHop }