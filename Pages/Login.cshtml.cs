using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using A_DOT_NET.models;
using Microsoft.AspNetCore.Identity;


namespace A_DOT_NET.Pages;

public class LoginModel : PageModel
{
    private readonly ILogger<PrivacyModel>? _logger;
     public IList<Person> personList {get;set;} = default!;
    [BindProperty]
    public Person NewPerson { get; set; } = default!;
     private readonly SignInManager<IdentityUser> signInManager;

        public LoginModel(SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;
        }
        public async Task<IActionResult> OnPostLogout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }


        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostLogin(Person? model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                            new IdentityUser { UserName = model.Email }, // Assuming email is the username
                            model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("index", "home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }

            return RedirectToAction("Get");;
        }
}