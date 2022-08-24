using System;
using System.Threading;
using System.Threading.Tasks;
using Adni.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Adni.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Company> companies{get;set;}
        DbSet<CompaniesList> companiesLists{get;set;}
        DbSet<Employee> employees {get;set;}
        DbSet<EmployeesList> employeesLists{get;set;}
        DbSet<Prospection> prospections {get;set;}
        DbSet<ProspectionsList> prospectionsList { get; set; }
        DbSet<Domain.Entities.Field> fields {get;set;}
        DbSet<Domain.Entities.Department> departments { get; set; }
        DbSet<Domain.Entities.Student> students {get;set;}

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}