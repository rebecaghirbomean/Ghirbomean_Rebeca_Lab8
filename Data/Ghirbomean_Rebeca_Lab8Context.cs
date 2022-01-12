using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ghirbomean_Rebeca_Lab8.Models;

namespace Ghirbomean_Rebeca_Lab8.Data
{
    public class Ghirbomean_Rebeca_Lab8Context : DbContext
    {
        public Ghirbomean_Rebeca_Lab8Context (DbContextOptions<Ghirbomean_Rebeca_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Ghirbomean_Rebeca_Lab8.Models.Book> Book { get; set; }

        public DbSet<Ghirbomean_Rebeca_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Ghirbomean_Rebeca_Lab8.Models.Category> Category { get; set; }
    }
}
