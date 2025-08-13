using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.DomainService.Base
{
    public static class StoredProcedures
    {
        public const string sp_GetUserList = "sp_GetUserList";
        public const string sp_GetVoucherApprovalList = "sp_GetVoucherApprovalList";
        public const string sp_GetVoucherDetailsByVoucherNo = "sp_GetVoucherDetailsByVoucherNo";
        public const string sp_GetChartOfAccounts = "sp_GetChartOfAccounts";
        public const string sp_GetFinanceAndAccountUsers = "sp_GetFinanceAndAccountUsers";
        public const string sp_GetUsersRoleMap = "sp_GetUsersRoleMap";
    }
}
