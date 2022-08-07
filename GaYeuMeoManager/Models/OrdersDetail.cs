using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaYeuMeoManager.Models
{
    public class OrdersDetail
    {
        [Key]
        public int OrdersId { get; set; }
        [ForeignKey("OrdersId")]
        public Orders Orders { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public int SubscriptionId { get; set; }
        [ForeignKey("SubscriptionId")]
        public GymSubscription GymSubscription { get; set; }
    }
}
