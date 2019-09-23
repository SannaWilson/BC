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
    public class IndexModel : PageModel
    {
        private readonly SQLharj.Models.TuoteContext _context;

        public IndexModel(SQLharj.Models.TuoteContext context)
        {
            _context = context;
        }

        public IList<Tuote> Tuote { get;set; }

        public async Task OnGetAsync()
        {
            Tuote = await _context.Tuote.ToListAsync();
        }
    }
}
