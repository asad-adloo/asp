using CRM.Application.Common.Interfaces;
using CRM.Common;
using CRM.Domain.Common;
using CRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CRM.Persistence
{
    public class CRMDbContext : DbContext, IdbContext
    {

        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        public CRMDbContext(DbContextOptions<CRMDbContext> options)
            : base(options)
        {
        }


        public CRMDbContext(
          DbContextOptions<CRMDbContext> options,
          ICurrentUserService currentUserService,
          IDateTime dateTime)
          : base(options)
        {
            _currentUserService = currentUserService;
            _dateTime = dateTime;
        }

        public DbSet<User> User { get; set; }
        public DbSet<UserShippingAddress> UserShippingAddresses { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceItem> InvoiceItem { get; set; }



        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _currentUserService.UserId;
                        entry.Entity.Created = _dateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = _currentUserService.UserId;
                        entry.Entity.LastModified = _dateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CRMDbContext).Assembly);
        }
    }
}
