using CRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace CRM.Application.Common.Interfaces
{
    public interface IdbContext
    {
        DbSet<User> User { get; set; }

        DbSet<UserShippingAddress> UserShippingAddresses { get; set; }

        DbSet<Product> Product { get; set; }

        DbSet<Invoice> Invoices { get; set; }

        DbSet<InvoiceItem> InvoiceItem { get; set; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }

}
