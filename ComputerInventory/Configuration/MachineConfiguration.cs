using ComputerInventory.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerInventory.Configuration
{
    public class MachineConfiguration : IEntityTypeConfiguration<Machine>
    {
        public void Configure(EntityTypeBuilder<Machine> builder)
        {
            builder.HasKey(e => e.MachineId);

            builder.Property(e => e.MachineId)
                .HasColumnName("MachineID")
                .HasComment("Machine ID");

            builder.Property(e => e.GeneralRole)
               .IsRequired()
               .HasMaxLength(25)
               .IsUnicode(true);

            builder.Property(e => e.InstalledRoles)
               .IsRequired()
               .HasMaxLength(50)
               .IsUnicode(true);

            builder.Property(e => e.MachineTypeId)
                .HasColumnName("MachineTypeID");

            builder.Property(e => e.Name)
               .IsRequired()
               .HasMaxLength(25)
               .IsUnicode(true);

            builder.Property(e => e.OperatingSysId)
                .HasColumnName("OperatingSysID");

            builder.HasOne(d => d.MachineType)
               .WithMany(p => p.Machine)
               .HasForeignKey(d => d.MachineTypeId)
               .OnDelete(DeleteBehavior.ClientSetNull)
               .HasConstraintName("FK_MachineType");

            builder.HasOne(d => d.OperatingSys)
               .WithMany(p => p.Machine)
               .HasForeignKey(d => d.OperatingSysId)
               .OnDelete(DeleteBehavior.ClientSetNull)
               .HasConstraintName("FK_OperatingSys");
        }
    }
}
