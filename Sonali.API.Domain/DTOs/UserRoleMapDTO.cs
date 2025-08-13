using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Domain.DTOs
{
    public class UserRoleMapDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = "";
        public int EmpId { get; set; }
        public string EmpName { get; set; } = "";
        public int RoleId { get; set; }
        public string RoleName { get; set; }= "";
        public bool IsActive { get; set; }
    }
}
