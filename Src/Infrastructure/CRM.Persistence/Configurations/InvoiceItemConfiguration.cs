using CRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Persistence.Configurations
{
    class InvoiceItemConfiguration : IEntityTypeConfiguration<InvoiceItem>
    {
        public void Configure(EntityTypeBuilder<InvoiceItem> builder)
        {
            builder.Property(e => e.InvoiceId)
                .IsRequired();

            builder.Property(e => e.ProductId)
                .IsRequired();

            builder.Property(e => e.PurchasePrice)
                .IsRequired();

            builder.Property(e => e.Qty)
                .IsRequired();
        }
    }
}
