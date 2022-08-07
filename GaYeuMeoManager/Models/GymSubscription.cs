using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaYeuMeoManager.Models
{
    public class GymSubscription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubscriptionId { get; set; }
        public string SubscriptionName { get; set; }
        public int Price { get; set; }
        public ICollection<OrdersDetail> OrdersDetails { get; set; }
    }
}
