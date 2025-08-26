using Microsoft.Extensions.Logging;
using Sonali.API.Domain.DTOs;
using Sonali.API.Domain.Entities;
using Sonali.API.DomainService.Base;
using Sonali.API.DomainService.DataService;
using Sonali.API.DomainService.Interface;
using Sonali.API.Utilities.Helper;
using System.Data;

namespace Sonali.API.DomainService.Repository
{
    public class AccountingDomainService : IAccountingDomainService
    {
        private readonly IGenericFactoryMSSQL<Voucher> _voucherRepo;
        private readonly IGenericFactoryMSSQL<VoucherDtl> _voucherDtlRepo;
        private readonly IGenericFactoryMSSQL<ChartOfAccounts> _coaRepo;
        private readonly IGenericFactoryMSSQL<FinanceAndBankingUser> _fabUserRepo;
        private readonly ILogger<AccountingDomainService> _logger;

        public AccountingDomainService(
            IGenericFactoryMSSQL<Voucher> voucherRepo,
            IGenericFactoryMSSQL<VoucherDtl> voucherDtlRepo,
            IGenericFactoryMSSQL<ChartOfAccounts> coaRepo,
            IGenericFactoryMSSQL<FinanceAndBankingUser> fabUserRepo,
            ILogger<AccountingDomainService> logger)
        {
            _voucherRepo = voucherRepo;
            _voucherDtlRepo = voucherDtlRepo;
            _coaRepo = coaRepo;
            _fabUserRepo = fabUserRepo;
            _logger = logger;
        }

        public async Task<object> GetVoucherList(VoucherSearchDTO param)
        {
            try
            {
                var parameters = new Dictionary<string, object?>
                {
                    { "PageIndex", param.PageNumber },
                    { "PageSize", param.PageSize },
                    { "Status", param.Status },
                    { "UserIds", param.UserIds },
                    { "VoucherNos", param.VoucherNos },
                    { "FromDate", param.FromDate },
                    { "ToDate", param.ToDate },
                    { "VoucherType", param.VoucherType },
                    { "Search", param.Search }
                };

                var vouchers = await _voucherRepo.ExecuteCommandListAsync(
                    StoredProcedures.sp_GetVoucherApprovalList,
                    parameters,
                    StaticInfos.MsSqlConnectionString
                ) ?? new List<Voucher>();

                return new { list = vouchers };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching voucher list");
                throw;
            }
        }

        public async Task<object> GetVoucherDetailsByVoucherNo(string voucherNo)
        {
            try
            {
                var parameters = new Dictionary<string, object?>
                {
                    { "VoucherNo", voucherNo }
                };

                var voucherDetails = await _voucherDtlRepo.ExecuteCommandListAsync(
                    StoredProcedures.sp_GetVoucherDetailsByVoucherNo,
                    parameters,
                    StaticInfos.MsSqlConnectionString
                ) ?? new List<VoucherDtl>();
               
                DataTable dataTable = DataTableHelper.ToDataTable(voucherDetails);
                DataView view = new DataView(dataTable);

                DataTable _voucherData = view.ToTable(
                    true,
                    "Id", "VoucherNo", "CodeAndName", "ActCode", "ActName", "FromActCode", "ToActCode",
                    "DAmount", "CAmount", "Amt", "AccStatement", "Descrp", "ModOfPay", "ChkNo", "ChkDt",
                    "OpeningBalance", "ShopId", "UserId", "EntryDate", "DelDate", "DelUser", "MainCode",
                    "SubGroupCat", "Transfered", "CreateDate", "CheckedBy", "ApprovedBy", "AuthStatus",
                    "CheckedDate", "ApprovedDate"
                    );
                DataTable _referData = view.ToTable(
                    true,
                    "ReferralId", "RefBy", "RefTo", "RefType", "Comments", "ReferDate", "IsActive"
                    );
                var voucherList = DataTableHelper.DataTableToList<VoucherDtl>(_voucherData);
                var referralList = DataTableHelper.DataTableToList<VoucherReferralDTO>(_referData);
                return new
                {
                    voucherList = voucherList.Count>0 ? voucherList : new List<VoucherDtl>(),
                    referralList = referralList.Count>0 ? referralList : new List<VoucherReferralDTO>()
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error fetching voucher details for {voucherNo}");
                throw;
            }
        }

        public async Task<object> GetChartOfAccounts()
        {
            try
            {
                var coaList = await _coaRepo.ExecuteCommandListAsync(
                    StoredProcedures.sp_GetChartOfAccounts,
                    new Dictionary<string, object?>(),
                    StaticInfos.MsSqlConnectionString
                ) ?? new List<ChartOfAccounts>();

                return new { list = coaList };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching chart of accounts");
                throw;
            }
        }

        public async Task<object> GetFinanceAndAccountUsers()
        {
            try
            {
                var users = await _fabUserRepo.ExecuteCommandListAsync(
                    StoredProcedures.sp_GetFinanceAndAccountUsers,
                    new Dictionary<string, object?>(),
                    StaticInfos.MsSqlConnectionString
                ) ?? new List<FinanceAndBankingUser>();

                return new { list = users };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching finance and banking users");
                throw;
            }
        }

        
    }
}
