using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Sonali.API.Domain.DTOs;
using Sonali.API.Domain.DTOs.DemoDTO;
using Sonali.API.Domain.Entities.Demo;
using Sonali.API.Domain.Interface;
using Sonali.API.DomainService.Interface;
using Sonali.API.Infrustructure.Data.Data;
using Sonali.API.Utilities.FileManagement;

namespace Sonali.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IDemoRepository _demoRepo;
        private readonly IDemoDomainService _iDataService;

        public DemoController( IDemoRepository demoRepo, IDemoDomainService dataService)
        {
            _demoRepo = demoRepo;
            _iDataService = dataService;
        }

        [Authorize]
        [HttpPost]
        [Route("Save")]
        public async Task<DemoDTO> Save([FromForm] string demo, [FromForm] List<IFormFile> files)
        {
            try
            {
                // Deserialize the JSON string
                var demoDto = JsonConvert.DeserializeObject<DemoDTO>(demo);

                return await _demoRepo.Save(demoDto, files);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [Authorize]
        [HttpGet]
        [Route("getDemoList")]
        public async Task<object?> getDemoList()
        {
            object? data = null;
            try
            {
                data = await _iDataService.GetDemoList();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return data;
        }

        //[Authorize]
        [HttpGet]
        [Route("getDemoById")]
        public async Task<object?> getDemoById([FromQuery] int id)
        {
            object? data = null;
            try
            {
                data = await _iDataService.GetDemoById(id);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return data;
        }

    }
}
