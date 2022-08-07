using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GaYeuMeoManager.Models
{
    public class Staff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
