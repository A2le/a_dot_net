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
        [BindProperty]
        public Album_cd NewAlbum { get; set; } = default!;
        public AlbumListModel(AlbumCDService service){
            _service = service;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid || NewAlbum == null)
            {
                return Page();
            }

            _service.AddAlbum(NewAlbum);

            return RedirectToAction("Get");
        }
        public void OnGet()
        {
            AlbumList = _service.GetAlbums();
        }
        public IActionResult OnPostDelete(int id)
        {
            _service.DeleteAlbum(id);

            return RedirectToAction("Get");
        }
    }
}
