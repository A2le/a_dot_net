using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A_DOT_NET.Pages;

public class LoginModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public LoginModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}