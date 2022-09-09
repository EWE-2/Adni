using Microsoft.EntityFrameworkCore;
using Adni.Domain.Entities;
using System.Threading.Tasks;
using Adni.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;
using System.Threading;
using System.Data;
using System.Reflection;

namespace Adni.Data.Contexts
{
    public class ApplicationDbContext : DbContext , IApplicationDbContext
    {
        private readonly IDateTime _dateTime;
        private IDbContextTransaction _currentTransaction;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        //public DbSet<Company> Companies { get; set; }
        public DbSet<CompaniesList> companiesLists { get; set; }
        public DbSet<Employee> employees { get ; set; }
        public DbSet<EmployeesList> employeesLists { get; set; }
        public DbSet<Company> companies { get; set; }
        public DbSet<Prospection> prospections { get ; set; }
        public DbSet<ProspectionsList> prospectionsList { get ; set; }
        public DbSet<Field> fields { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<AlmUser> almUsers { get ; set; }
        public DbSet<Attribution> attributions { get; set; }
        //public DbSet<InternshipPlacement> internshipPlacements { get; set; }
        public DbSet<Internship> internships { get; set; }
        public DbSet<InternshipReport> internshipReports { get; set; }
        public DbSet<PlacesDisponibles> placesDisponibles { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IDateTime dateTime): base(options)
        {
            _dateTime = dateTime;
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return base.SaveChangesAsync(cancellationToken);
        }

        public async Task beginTransactionAsync()
        {
            if (_currentTransaction != null)
                return;

            _currentTransaction = await base.Database.BeginTransactionAsync(IsolationLevel.ReadCommitted).ConfigureAwait(false);
        }

        public async Task CommitTransactionAsync()
        {
            try
            {
                await SaveChangesAsync().ConfigureAwait(false);
                _currentTransaction?.Commit();
            }
            catch
            {
                RollbackTransaction();
                throw;
            }
            finally
            {
                if(_currentTransaction != null)
                {
                    _currentTransaction.Dispose();
                    _currentTransaction = null;
                }
            }
        }
        public void RollbackTransaction()
        {
            try
            {
                _currentTransaction?.Rollback();
                _currentTransaction = null;
            }
            finally
            {
                if(_currentTransaction != null)
                {
                    _currentTransaction.Dispose();
                    _currentTransaction = null;
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //configuration de la relation Prospection et Field sans cle etrangere chez Field
            //et une navigation simple sur Prospection
            
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
