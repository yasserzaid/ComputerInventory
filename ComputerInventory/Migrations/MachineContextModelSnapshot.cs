﻿// <auto-generated />
using System;
using ComputerInventory.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ComputerInventory.Migrations
{
    [DbContext(typeof(MachineContext))]
    partial class MachineContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ComputerInventory.Models.Machine", b =>
                {
                    b.Property<int>("MachineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MachineID")
                        .HasColumnType("int")
                        .HasComment("Machine ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GeneralRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(true);

                    b.Property<string>("InstalledRoles")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<int>("MachineTypeId")
                        .HasColumnName("MachineTypeID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(true);

                    b.Property<int>("OperatingSysId")
                        .IsConcurrencyToken()
                        .HasColumnName("OperatingSysID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnName("MachinePrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("MachineId");

                    b.HasIndex("MachineTypeId");

                    b.HasIndex("OperatingSysId");

                    b.ToTable("Machine");
                });

            modelBuilder.Entity("ComputerInventory.Models.MachineType", b =>
                {
                    b.Property<int>("MachineTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MachineTypeID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(true);

                    b.HasKey("MachineTypeId");

                    b.ToTable("MachineType");
                });

            modelBuilder.Entity("ComputerInventory.Models.MachineWarranty", b =>
                {
                    b.Property<int>("MachineWarrantyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MachineWarrantyID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MachineId")
                        .HasColumnName("MachineID")
                        .HasColumnType("int");

                    b.Property<string>("ServiceTag")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(true);

                    b.Property<DateTime>("WarrantyExpiration")
                        .HasColumnType("date");

                    b.Property<int>("WarrantyProviderId")
                        .HasColumnName("WarrantyProviderID")
                        .HasColumnType("int");

                    b.HasKey("MachineWarrantyId");

                    b.HasIndex("WarrantyProviderId");

                    b.ToTable("MachineWarranty");
                });

            modelBuilder.Entity("ComputerInventory.Models.OperatingSys", b =>
                {
                    b.Property<int>("OperatingSysId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OperatingSysID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(35)")
                        .HasMaxLength(35)
                        .IsUnicode(true);

                    b.Property<bool>("StillSupported")
                        .HasColumnType("bit");

                    b.HasKey("OperatingSysId");

                    b.ToTable("OperatingSys");
                });

            modelBuilder.Entity("ComputerInventory.Models.SupportLog", b =>
                {
                    b.Property<int>("SupportLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SupportLogID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SupportLogEntry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .IsUnicode(true);

                    b.Property<DateTime>("SupportLogEntryDate")
                        .HasColumnType("datetime");

                    b.Property<string>("SupportLogUpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<int>("SupportTicketId")
                        .HasColumnName("SupportTicketID")
                        .HasColumnType("int");

                    b.HasKey("SupportLogId");

                    b.HasIndex("SupportTicketId");

                    b.ToTable("SupportLog");
                });

            modelBuilder.Entity("ComputerInventory.Models.SupportTicket", b =>
                {
                    b.Property<int>("SupportTicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SupportTicketID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateReported")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateResolved")
                        .HasColumnType("date");

                    b.Property<string>("IssueDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(true);

                    b.Property<string>("IssueDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .IsUnicode(true);

                    b.Property<int>("MachineId")
                        .HasColumnName("MachineID")
                        .HasColumnType("int");

                    b.Property<string>("TicketOpenedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.HasKey("SupportTicketId");

                    b.HasIndex("MachineId");

                    b.ToTable("SupportTicket");
                });

            modelBuilder.Entity("ComputerInventory.Models.WarrantyProvider", b =>
                {
                    b.Property<int>("WarrantyProviderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("WarrantyProviderID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProviderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<int?>("SupportExtension")
                        .HasColumnType("int");

                    b.Property<string>("SupportNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(true);

                    b.HasKey("WarrantyProviderId");

                    b.ToTable("WarrantyProvider");
                });

            modelBuilder.Entity("ComputerInventory.Models.Machine", b =>
                {
                    b.HasOne("ComputerInventory.Models.MachineType", "MachineType")
                        .WithMany("Machine")
                        .HasForeignKey("MachineTypeId")
                        .HasConstraintName("FK_MachineType")
                        .IsRequired();

                    b.HasOne("ComputerInventory.Models.OperatingSys", "OperatingSys")
                        .WithMany("Machine")
                        .HasForeignKey("OperatingSysId")
                        .HasConstraintName("FK_OperatingSys")
                        .IsRequired();
                });

            modelBuilder.Entity("ComputerInventory.Models.MachineWarranty", b =>
                {
                    b.HasOne("ComputerInventory.Models.WarrantyProvider", "WarrantyProvider")
                        .WithMany("MachineWarranty")
                        .HasForeignKey("WarrantyProviderId")
                        .HasConstraintName("FK_WarrantyProvider")
                        .IsRequired();
                });

            modelBuilder.Entity("ComputerInventory.Models.SupportLog", b =>
                {
                    b.HasOne("ComputerInventory.Models.SupportTicket", "SupportTicket")
                        .WithMany("SupportLog")
                        .HasForeignKey("SupportTicketId")
                        .HasConstraintName("FK_SupportTicket")
                        .IsRequired();
                });

            modelBuilder.Entity("ComputerInventory.Models.SupportTicket", b =>
                {
                    b.HasOne("ComputerInventory.Models.Machine", "Machine")
                        .WithMany("SupportTicket")
                        .HasForeignKey("MachineId")
                        .HasConstraintName("FK_Machine")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
