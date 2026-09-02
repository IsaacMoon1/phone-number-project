using Microsoft.EntityFrameworkCore;
using PhoneReceiverApi.Models;

namespace PhoneReceiverApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<PhoneRecord> PhoneRecords => Set<PhoneRecord>();
    }
}