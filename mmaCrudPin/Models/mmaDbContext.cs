using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mmaCrudPin.Models
{
    public class mmaDbContext: DbContext
    {
        public mmaDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<mmaFighter> mmaFighters { get; set; }
    }
}
