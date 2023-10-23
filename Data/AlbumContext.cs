using Microsoft.EntityFrameworkCore;

namespace A_DOT_NET.Data
{
    public class AlbumContext : DbContext
    {
        public AlbumContext(DbContextOptions<AlbumContext> options)
            : base(options)
        {
        }
        public DbSet<A_DOT_NET.models.Album_cd>? Albums { get; set; }
    }


}