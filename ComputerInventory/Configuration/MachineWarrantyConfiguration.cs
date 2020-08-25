using ComputerInventory.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerInventory.Configuration
{
    public class MachineWarrantyConfiguration : IEntityTypeConfiguration<MachineWarranty>
    {
        public void Configure(EntityTypeBuilder<MachineWarranty> builder)
        {
            builder.Property(e => e.MachineWarrantyId)
                .HasColumnName("MachineWarrantyID");

            builder.Property(e => e.MachineId)
                .HasColumnName("MachineID");

            builder.Property(e => e.ServiceTag)
               .IsRequired()
               .HasMaxLength(20)
               .IsUnicode(true);

            builder.Property(e => e.WarrantyExpiration)
                .HasColumnType("date");

            builder.Property(e => e.WarrantyProviderId)
                .HasColumnName("WarrantyProviderID");

            builder.HasOne(d => d.WarrantyProvider)
               .WithMany(p => p.MachineWarranty)
               .HasForeignKey(d => d.WarrantyProviderId)
               .OnDelete(DeleteBehavior.ClientSetNull)
               .HasConstraintName("FK_WarrantyProvider");
        }
    }
}
