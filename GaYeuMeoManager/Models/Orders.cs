using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaYeuMeoManager.Models;

namespace GaYeuMeoManager.Models
{
    public class Orders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrdersId { get; set; }
        public DateTime DateCreate { get; set; }
        public int Total { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }  
        public int StaffId { get; set; }
        [ForeignKey("StaffId")]
        public Staff Staff { get; set; }
        public ICollection <OrdersDetail> OrdersDetails { get; set; }
    }
}
