using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SQLharj.Models;

namespace SQLharj.Pages.Tuotteet
{
    public class DeleteModel : PageModel
    {
        private readonly SQLharj.Models.TuoteContext _context;

        public DeleteModel(SQLharj.Models.TuoteContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Tuote Tuote { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tuote = await _context.Tuote.FirstOrDefaultAsync(m => m.ID == id);

            if (Tuote == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tuote = await _context.Tuote.FindAsync(id);

            if (Tuote != null)
            {
                _context.Tuote.Remove(Tuote);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
