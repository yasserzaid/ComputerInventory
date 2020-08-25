using ComputerInventory.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerInventory.Configuration
{
    public class OperatingSysConfiguration : IEntityTypeConfiguration<OperatingSys>
    {
        public void Configure(EntityTypeBuilder<OperatingSys> builder)
        {
            builder.Property(e => e.OperatingSysId)
                .HasColumnName("OperatingSysID");

            builder.Property(e => e.Name)
               .IsRequired()
               .HasMaxLength(35)
               .IsUnicode(true);

            // Not Used
            //builder.HasMany(d => d.Machine)
            //    .WithOne(p => p.OperatingSys)
            //    .HasForeignKey(d => d.MachineId)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK_Machine");
        }
    }
}
