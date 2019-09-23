using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SQLharj.Models
{
    public class TuoteContext : DbContext
    {
        public TuoteContext (DbContextOptions<TuoteContext> options)
            : base(options)
        {
        }

        public DbSet<SQLharj.Models.Tuote> Tuote { get; set; }
    }
}
