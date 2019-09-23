using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SQLharj.Models;

namespace SQLharj.Pages.Tuotteet
{
    public class EditModel : PageModel
    {
        private readonly SQLharj.Models.TuoteContext _context;

        public EditModel(SQLharj.Models.TuoteContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Tuote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TuoteExists(Tuote.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TuoteExists(int id)
        {
            return _context.Tuote.Any(e => e.ID == id);
        }
    }
}
