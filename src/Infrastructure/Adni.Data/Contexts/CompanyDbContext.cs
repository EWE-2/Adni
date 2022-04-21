using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Adni.Domain.Entities;
using Adni.Domain.Interfaces;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adni.Data.Contexts
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options): base(options)
        {
            
        }
        public DbSet<Company> Companies { get; set; }

    }
}
