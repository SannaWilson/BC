using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SQLharj.Models;

namespace SQLharj.Pages.Tuotteet
{
    public class CreateModel : PageModel
    {
        private readonly SQLharj.Models.TuoteContext _context;

        public CreateModel(SQLharj.Models.TuoteContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Tuote Tuote { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Tuote.Add(Tuote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}