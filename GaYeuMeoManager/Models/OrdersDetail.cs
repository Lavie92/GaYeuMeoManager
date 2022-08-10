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
       
        [Key, Column(Order = 0)]
        public int OrdersId { get; set; }
        [ForeignKey("OrdersId")]
        public Orders Orders { get; set; }
        [Key, Column(Order = 1)]
        public int SubscriptionId { get; set; }
        [ForeignKey("SubscriptionId")]
        public GymSubscription GymSubscription { get; set; }

        public int Quantity { get; set; }
        public int TotalOrdersDetail { get; set; }
    }
}
