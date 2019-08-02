using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PortfolioAplication.Models
{
    public class WorkContext:DbContext
    {
        public DbSet<Work> Works { get; set; }
        public WorkContext(DbContextOptions<WorkContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
