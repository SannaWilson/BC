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

        public string LAAKENIMIFiltet { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public PaginatedList<Tuote> Tuote { get; set; }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, int? pageIndex)
        {
            CurrentSort = sortOrder;

            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            IQueryable<Tuote> tuoteIQ = from s in _context.Tuote
                                        select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                tuoteIQ = tuoteIQ.Where(s => s.LAAKENIMI.Contains(searchString));
            }

            Tuote = await PaginatedList<Tuote>.CreateAsync(tuoteIQ.AsNoTracking(), pageIndex ?? 1);
        }
        

    }
}
