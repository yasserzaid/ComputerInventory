using ComputerInventory.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerInventory.Configuration
{
    public class MachineTypeConfiguration : IEntityTypeConfiguration<MachineType>
    {
        public void Configure(EntityTypeBuilder<MachineType> builder)
        {
            builder.Property(e => e.MachineTypeId)
                .HasColumnName("MachineTypeID");

            builder.Property(e => e.Description)
               .HasMaxLength(15)
               .IsUnicode(true);
        }
    }
}
