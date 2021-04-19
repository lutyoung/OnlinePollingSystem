
using Microsoft.EntityFrameworkCore;
using OnlinePollingSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OnlinePollingSystem.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyAllConfigurations<ApplicationDbContext>();
            modelBuilder.ConfigureDeletableEntities();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            UpdateSoftDeleteStatuses();
            this.AddAuditInfo();
            return base.SaveChangesAsync(cancellationToken);
        }

        private const string IsDeletedProperty = "IsDeleted";
       
        private void UpdateSoftDeleteStatuses()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.CurrentValues[IsDeletedProperty] = false;
                        break;
                    case EntityState.Modified:
                        entry.CurrentValues[IsDeletedProperty] = false;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified;
                        entry.CurrentValues[IsDeletedProperty] = true;
                        break;
                }
            }
        }


        public DbSet<Admin> Admins { get; set; }

        public DbSet<Contestant> Contestants { get; set; }

        public DbSet<Person> People{ get; set; }

        public DbSet<Poll> Polls { get; set; }

        public DbSet<ContestantPoll> ContestantPolls { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Vote> Votes { get; set; }

        public DbSet<Voter> Voters { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }
    }
}
