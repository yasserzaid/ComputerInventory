using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComputerInventory.Models
{
    public partial class Machine
    {
        public Machine()
        {
            SupportTicket = new HashSet<SupportTicket>();
        }

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Column(name: "MachineID")]
        public int MachineId { get; set; }

        //[Required]
        //[MaxLength(25)]
        public string Name { get; set; }

        [Required]
        [Column("MachinePrice",TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public string GeneralRole { get; set; }

        //[Required]
        //[MaxLength(50)]
        public string InstalledRoles { get; set; }
        
        //[Column("OperatingSysID")]
        [ConcurrencyCheck]
        public int OperatingSysId { get; set; }
        
        public int MachineTypeId { get; set; }

        //[ForeignKey("MachineTypeId")]
        public MachineType MachineType { get; set; }

        //[ForeignKey("OperatingSysId")]
        public OperatingSys OperatingSys { get; set; }
        
        public ICollection<SupportTicket> SupportTicket { get; set; }
    }
}