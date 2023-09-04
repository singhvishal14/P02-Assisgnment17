using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assisgnment17.Model;

namespace Assisgnment17.Data
{
    public class Assisgnment17DbContext : DbContext
    {
        public Assisgnment17DbContext (DbContextOptions<Assisgnment17DbContext> options)
            : base(options)
        {
        }

        public DbSet<Assisgnment17.Model.Movie> Movie { get; set; } = default!;
    }
}
