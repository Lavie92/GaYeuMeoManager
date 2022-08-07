using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaYeuMeoManager.Models
{
    public class AccountPermission
    {
        [Key, Column(Order = 0)]
        public int AccountId { get; set; }
        [ForeignKey("AccountId")]
        public Account Account { get; set; }
        [Key, Column(Order =1)]
        public int PermissionId { get; set; }
        [ForeignKey("PermissionId")]
        public Permission Permission { get; set; }
    }
}
