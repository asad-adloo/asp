using CRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Persistence.Configurations
{
    class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.Property(e => e.CustomerId)
                .IsRequired();

            builder.Property(e => e.RegisterdByUserId)
                .IsRequired();


            builder.Property(e => e.SalerId)
                .IsRequired();

        }
    }
}
