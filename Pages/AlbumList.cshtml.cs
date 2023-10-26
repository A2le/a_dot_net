using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using A_DOT_NET.models;
using A_DOT_NET.Services;
namespace A_DOT_NET.Pages
{
    public class AlbumListModel : PageModel
    {
        private readonly AlbumCDService _service;
        public IList<Album_cd> AlbumList {get;set;} = default!;

        public AlbumListModel(AlbumCDService service){
            _service = service;
        }
        public void OnGet()
        {
            AlbumList = _service.GetAlbums();
        }
    }
}
