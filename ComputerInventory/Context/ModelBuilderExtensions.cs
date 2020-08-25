using ComputerInventory.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerInventory.Context
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //MachineType
            modelBuilder.Entity<MachineType>()
                .HasData(
                   new MachineType { Description = "Machine Server", MachineTypeId = 2 },
                   new MachineType { Description = "Personal Machine", MachineTypeId = 3 },
                   new MachineType { Description = "Backup Server", MachineTypeId = 5 }
            );
        }
    }
}
