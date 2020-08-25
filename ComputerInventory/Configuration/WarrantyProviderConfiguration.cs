using ComputerInventory.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerInventory.Configuration
{
    public class WarrantyProviderConfiguration : IEntityTypeConfiguration<WarrantyProvider>
    {
        public void Configure(EntityTypeBuilder<WarrantyProvider> builder)
        {
            builder.Property(e => e.WarrantyProviderId)
                .HasColumnName("WarrantyProviderID");

            builder.Property(e => e.ProviderName)
               .IsRequired()
               .HasMaxLength(50)
               .IsUnicode(true);

            builder.Property(e => e.SupportNumber)
               .IsRequired()
               .HasMaxLength(10)
               .IsUnicode(true);
        }
    }
}
