using System.ComponentModel.DataAnnotations;

namespace A_DOT_NET.models;

public class Album_cd
{
    [Key]
    public int Album_id { get; set; }

    [Required]
    public string? Album_name { get; set; }
    [Required]
    public string? Artist_name { get; set; }
    public AlbumGenre Genre { get; set; }
    public int IsAvailableForRent { get; set; }
    public int IsAvailableForPurchase { get; set; }
    
    public int Year { get; set; }
    [Range(0.01, 9999.99)]
    public decimal Price { get ; set; }

     public void RentAlbum()
    {
        if (IsAvailableForRent==1)
        {
            // Logic to handle the rental process
            IsAvailableForRent = 0;
            Console.WriteLine($"Album '{Album_name}' rented successfully.");
        }
        else
        {
            Console.WriteLine($"Album '{Album_name}' is not available for rent.");
        }
    }

    public void PurchaseAlbum()
    {
        if (IsAvailableForPurchase==1)
        {
            // Logic to handle the purchase process
            IsAvailableForPurchase = 0
            ;
            Console.WriteLine($"Album '{Album_name}' purchased successfully.");
        }
        else
        {
            Console.WriteLine($"Album '{Album_name}' is not available for purchase.");
        }
    }
}

public enum AlbumGenre { Pop, Gospel, HipHop ,AfroBeats}