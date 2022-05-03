using System;
using System.Threading;
using System.Threading.Tasks;
using Adni.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Adni.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Company> Companies{get;set;}
        DbSet<CompaniesList> companiesLists{get;set;}
        DbSet<Employee> Employees {get;set;}

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}