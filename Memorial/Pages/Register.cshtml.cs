using FluentValidation;
using Memorial.Data;
using Memorial.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Memorial.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public RegisterDto Input { get; set; }
        private readonly IValidator<RegisterDto> _validator;
        private AppDbContext _context;

        public RegisterModel( IValidator<RegisterDto> validator, AppDbContext context, RegisterDto model)
        {
            _validator = validator;
            _context = context;
            Input = model;
        }


        public async Task<IActionResult> OnPostAsync()
        {
            var validationResult = await _validator.ValidateAsync(Input);
            if (!validationResult.IsValid)
            {
                //foreach (var error in validationResult.Errors)
                //    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                return RedirectToPage("/Error", validationResult.Errors);
            }

            string hashedPassword = Input.Password;//  BCrypt.HashPassword(Input.Password, BCrypt.GenerateSalt());
            var user = new User { Email = Input.Email, Password = hashedPassword };
            _context.Users.Add(user); 
            await _context.SaveChangesAsync();
            return RedirectToPage("/Index");
        }



    }
}
