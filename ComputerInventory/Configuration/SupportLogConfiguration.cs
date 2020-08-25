using ComputerInventory.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerInventory.Configuration
{
    public class SupportLogConfiguration : IEntityTypeConfiguration<SupportLog>
    {
        public void Configure(EntityTypeBuilder<SupportLog> builder)
        {
            builder.Property(e => e.SupportLogId)
                .HasColumnName("SupportLogID");

            builder.Property(e => e.SupportLogEntry)
               .IsRequired()
               .IsUnicode(true);

            builder.Property(e => e.SupportLogEntryDate)
                .HasColumnType("date");

            builder.Property(e => e.SupportLogUpdatedBy)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(true);

            builder.Property(e => e.SupportTicketId)
                .HasColumnName("SupportTicketID");

            builder.HasOne(d => d.SupportTicket)
               .WithMany(p => p.SupportLog)
               .HasForeignKey(d => d.SupportTicketId)
               .OnDelete(DeleteBehavior.ClientSetNull)
               .HasConstraintName("FK_SupportTicket");
        }
    }
}
