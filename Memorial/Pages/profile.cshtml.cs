using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Memorial.Data;
using FluentValidation;
using Memorial.Models.Validators;
using Memorial.Models;


namespace Memorial.Pages
{

    public class ProfileModel : PageModel
    {
        private readonly IValidator <UserValidator> _userValidator;

        private readonly AppDbContext _context;

        public ProfileModel(IValidator<UserValidator> userValidator, AppDbContext context)
        {
            _userValidator = userValidator;
            _context =  context;
        }

        [BindProperty]
        public User user { get; set; }


        //public async Task<IActionResult> OnGetAsync()
        //{
        //    var user = await _context.GetUserAsync(User);
        //    if (user == null)
        //    {
        //        return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //    }


        //    return Page();
        //}

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }

        //    var user = await _userManager.GetUserAsync(User);
        //    if (user == null)
        //    {
        //        return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //    }

        //    if (Input.FullName != user.UserName)
        //    {
        //        user.UserName = Input.FullName;
        //    }

        //    if (Input.PhoneNumber != user.PhoneNumber)
        //    {
        //        user.PhoneNumber = Input.PhoneNumber;
        //    }

        //    var result = await _userManager.UpdateAsync(user);
        //    if (!result.Succeeded)
        //    {
        //        foreach (var error in result.Errors)
        //        {
        //            ModelState.AddModelError(string.Empty, error.Description);
        //        }
        //        return Page();
        //    }

        //    return RedirectToPage();
        //}
    }
}


