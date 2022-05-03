using System;
using Micricosoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Adni.Domain.Entities;

namespace Adni.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Company> Companies{get;set;}

        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
    }
}