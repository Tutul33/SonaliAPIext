using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sonali.API.Domain.DTOs;
using Sonali.API.Domain.DTOs.DemoDTO;
using Sonali.API.Domain.Interface;
using Sonali.API.Infrustructure.Data.Data;
using Sonali.API.Utilities.FileManagement;

namespace Sonali.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IDemoRepository _demoRepo;

        public DemoController( IDemoRepository demoRepo)
        {
            _demoRepo = demoRepo;
        }

        [Authorize]
        [HttpPost]
        [Route("Save")]
        public async Task<DemoDTO> Save([FromBody] DemoDTO demo, [FromForm] List<IFormFile> files)
        {
            try
            {
                return await _demoRepo.Save(demo,files);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
