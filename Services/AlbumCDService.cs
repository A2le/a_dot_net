using A_DOT_NET.Data;
using A_DOT_NET.models;

namespace A_DOT_NET.Services
{
    public class AlbumCDService
    {
        private readonly AlbumContext _context = default!;

        public AlbumCDService(AlbumContext context) 
        {
            _context = context;
        }
        
        public IList<Album_cd> GetAlbums()
        {
            if(_context.Albums != null)
            {
                return _context.Albums.ToList();
            }
            return new List<Album_cd>();
        }

        public void AddAlbum(Album_cd album)
        {
            if (_context.Albums != null)
            {
                _context.Albums.Add(album);
                _context.SaveChanges();
            }
        }

        public void DeleteAlbum(int id)
        {
            if (_context.Albums != null)
            {
                var pizza = _context.Albums.Find(id);
                if (pizza != null)
                {
                    _context.Albums.Remove(pizza);
                    _context.SaveChanges();
                }
            }            
        } 
    }
}
