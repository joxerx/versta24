using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using versta24.Models;

namespace versta24.Data
{
    public class versta24Context : DbContext
    {
        public versta24Context (DbContextOptions<versta24Context> options)
            : base(options)
        {
        }

        public DbSet<versta24.Models.Order> Order { get; set; } = default!;
    }
}
