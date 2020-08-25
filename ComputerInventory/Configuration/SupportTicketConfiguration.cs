using ComputerInventory.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerInventory.Configuration
{
    public class SupportTicketConfiguration : IEntityTypeConfiguration<SupportTicket>
    {
        public void Configure(EntityTypeBuilder<SupportTicket> builder)
        {
            builder.Property(e => e.SupportTicketId)
                .HasColumnName("SupportTicketID");

            builder.Property(e => e.DateReported)
                .HasColumnType("date");

            builder.Property(e => e.DateResolved)
                .HasColumnType("date");

            builder.Property(e => e.IssueDescription)
               .IsRequired()
               .HasMaxLength(150)
               .IsUnicode(true);

            builder.Property(e => e.IssueDetail)
                .IsUnicode(true);

            builder.Property(e => e.MachineId)
                .HasColumnName("MachineID");

            builder.Property(e => e.TicketOpenedBy)
               .IsRequired()
               .HasMaxLength(50)
               .IsUnicode(true);

            builder.HasOne(d => d.Machine)
               .WithMany(p => p.SupportTicket)
               .HasForeignKey(d => d.MachineId)
               .OnDelete(DeleteBehavior.ClientSetNull)
               .HasConstraintName("FK_Machine");
        }
    }
}
