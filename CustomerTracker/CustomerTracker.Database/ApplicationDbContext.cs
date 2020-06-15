using CustomerTracker.Application.Common;
using CustomerTracker.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerTracker.Database
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<CustomerNote> CustomerNotes { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public Task<int> SaveChangesAsync()
        {
            return SaveChangesAsync(new CancellationToken());
        }
    }
}
