using Sonali.API.Domain.DTOs;
using Sonali.API.Domain.DTOs.DemoDTO;
using Sonali.API.Domain.Entities;
using Sonali.API.DomainService.Base;
using Sonali.API.DomainService.DataService;
using Sonali.API.DomainService.Interface;
using Sonali.API.Utilities.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.DomainService.Repository
{
    public class DemoDomainService : IDemoDomainService
    {
        private readonly IGenericFactoryMSSQL<DemoDTORequest> _demoRepo;
        public DemoDomainService(IGenericFactoryMSSQL<DemoDTORequest> demoRepo)
        {
            _demoRepo = demoRepo;
        }

        public async Task<object> GetDemoList()
        {
            try
            {
                var users = await _demoRepo.ExecuteCommandListAsync(
                   StoredProcedures.sp_GetDemoList,
                   new Dictionary<string, object?>(),
                   StaticInfos.MsSqlConnectionString
               ) ?? new List<DemoDTORequest>();

                return new { list = users };
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<object> GetDemoById(int id)
        {
            try
            {
                var parameters = new Dictionary<string, object?>
        {
            { "id", id }
        };

                var demoData = await _demoRepo.ExecuteCommandListAsync(
                       StoredProcedures.sp_GetDemoById,
                       parameters,
                       StaticInfos.MsSqlConnectionString
                   ) ?? new List<DemoDTORequest>();

                if(demoData.Count == 0)
                {
                    return demoData;
                }
                // Convert flat list to DataTable
                DataTable dataTable = DataTableHelper.ToDataTable(demoData);
                DataView view = new DataView(dataTable);

                DataTable _demoData = view.ToTable(
                    true,
                    "Id", "Name", "CreateDate", "IsActive"
                );

                DataTable _demoItemData = view.ToTable(
                    true,
                    "DemoItemId", "Id", "DemoItemName", "RefTo", "DemoItemTitle", "DemoItemDescription", "DemoItemActive"
                );

                DataTable _demoItemAttchData = view.ToTable(
                    true,
                    "DAtacchmentId", "DemoItemId", "FileName", "DAttachmentActive"
                );
                
                // 🔑 Now build hierarchy from existing DataTables
                var result = _demoData.AsEnumerable().Select(demo => new
                {
                    Id = demo["Id"],
                    Name = demo["Name"],
                    CreateDate = demo["CreateDate"],
                    IsActive = demo["IsActive"],

                    DemoItems = _demoItemData.AsEnumerable()
                        .Where(di => di["Id"].ToString() == demo["Id"].ToString())
                        .Select(di => new
                        {
                            Id = di["DemoItemId"],
                            DemoId= demo["Id"],
                            Name = di["DemoItemName"],
                            RefTo = di["RefTo"],
                            Title = di["DemoItemTitle"],
                            Description = di["DemoItemDescription"],
                            IsActive = di["DemoItemActive"],

                            DemoItemFileAttachments = _demoItemAttchData.AsEnumerable()
                                .Where(att => att["DemoItemId"].ToString() == di["DemoItemId"].ToString() && att["DAtacchmentId"].ToString()!="0")
                                .Select(att => new
                                {
                                    Id = att["DAtacchmentId"],
                                    DemoItemId = di["DemoItemId"],
                                    FileName = att["FileName"],
                                    IsActive = att["DAttachmentActive"]
                                }).ToList()
                        }).ToList()
                }).ToList();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
