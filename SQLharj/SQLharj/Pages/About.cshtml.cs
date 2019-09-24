using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SQLharj.Models.ProductViewModels;
using SQLharj.Models;


namespace SQLharj.Pages
{
    public class AboutModel : PageModel
    {
        private readonly TuoteContext _context;

        public AboutModel(TuoteContext context)
        {
            _context = context;
        }

        public IList<ATCGroup> Tuote { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<ATCGroup> data =
                from tuote in _context.Tuote
                group tuote by tuote.ATCKOODI into textGroup
                select new ATCGroup()
                {
                    Tuote = textGroup.Key,
                    TuoteCount = textGroup.Count()
                };

            Tuote = await data.AsNoTracking().ToListAsync();
        }
    }
}