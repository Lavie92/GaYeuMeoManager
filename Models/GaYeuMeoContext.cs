using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Models
{
    internal class GaYeuMeoContext : DbContext
    {
        GaYeuMeoContext () : base("name=GymContext") { }
    }
}
