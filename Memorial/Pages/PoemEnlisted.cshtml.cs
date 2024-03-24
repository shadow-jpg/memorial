using Memorial.Models;
using Memorial.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Memorial.Pages
{
    public class PoemEnlistedModel : PageModel
    {
        private readonly PoemService _poemService;

        public Poem Poem { get; set; }

        public PoemEnlistedModel(PoemService poemService)
        {
            _poemService = poemService;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Poem = await _poemService.GetToREADPoemWithIdAsync(id);

            if (Poem == null)
            {
                return NotFound();
            }

            await _poemService.IncrementViewsAsync(id);

            return Page();
        }
    }
}
