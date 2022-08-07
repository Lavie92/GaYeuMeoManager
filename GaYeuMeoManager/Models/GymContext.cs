using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaYeuMeoManager.Models;
using Models;

namespace GaYeuMeoManager.Models
{
    public class GymContext : DbContext
    {
        public GymContext () : base ("name = GymContext") { }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrdersDetail> OrdersDetails { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet <Permission> Permissions { get; set; }

        public virtual DbSet<AccountPermission> AccountPermissions { get; set; }
        public virtual DbSet<GymSubscription> GymSubscriptions { get; set; }
    }
}
