using GaYeuMeoManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
