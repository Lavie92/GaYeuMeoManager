using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaYeuMeoManager.Models
{
    public class Permission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PermissionId { get; set; }
        public string PermissionName { get; set; }
        public ICollection<AccountPermission> accountPermissions { get; set; }
    }
}
