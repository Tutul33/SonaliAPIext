using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Sonali.API.Utilities.ReportManagement;
using System.Data;
using System.Text.Json;

namespace Sonali.API.Controllers.Reports
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly IRdlcService _rdlcService;

        public ReportsController(IRdlcService rdlcService)
        {
            _rdlcService = rdlcService;
        }

        [HttpPost("ShowReports1")]
        public async Task<object> ShowReports1([FromBody] JsonElement data)
        {
            JObject jObject = JObject.Parse(data.ToString());

            string reportType = jObject["reportType"]?.ToString() ?? "";
            string reportName = jObject["reportName"]?.ToString() ?? "";
            string dataJson = jObject["data"]?.ToString() ?? "";
            string parametersJson = jObject["params"]?.ToString() ?? "";
            string dataSetName = jObject["dataSetName"]?.ToString() ?? "";

            // Convert dataJson to DataTable
            DataTable dataTable = new DataTable();
            if (!string.IsNullOrEmpty(dataJson))
            {
                try
                {
                    dataTable = JsonConvert.DeserializeObject<DataTable>(dataJson);
                    dataTable.TableName = dataSetName; // important for RDLC binding
                }
                catch (Exception ex)
                {
                    return BadRequest($"Invalid data format for DataTable: {ex.Message}");
                }
            }

            // Convert paramsJson to Dictionary<string, object>
            var paramsObj = new Dictionary<string, object>();

            if (!string.IsNullOrEmpty(parametersJson))
            {
                try
                {
                    JArray paramArray = JArray.Parse(parametersJson);
                    foreach (JObject obj in paramArray)
                    {
                        var key = obj["key"]?.ToString();
                        var value = obj["value"]?.ToString();

                        if (!string.IsNullOrEmpty(key))
                        {
                            paramsObj[key] = value ?? string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    return BadRequest($"Invalid params format: {ex.Message}");
                }
            }

            // Build Report Path (use reportName if dynamic)
            string reportPath = Path.Combine(Directory.GetCurrentDirectory(), "Reports", "RDLC",
                                             string.IsNullOrEmpty(reportName) ? "Sample.rdlc" : reportName);

            if (!System.IO.File.Exists(reportPath))
                return NotFound($"Report file not found: {reportPath}");

            //  Export RDLC
            var fileContent = _rdlcService.ExportReport(reportPath, dataTable, reportType, dataSetName, paramsObj);

            //  Save PDF file
            string saveFolder = Path.Combine(Directory.GetCurrentDirectory(), "Reports", "Pdf");
            if (!Directory.Exists(saveFolder))
                Directory.CreateDirectory(saveFolder);

            string fileName = $"Report_{DateTime.Now:yyyyMMddHHmmss}.pdf";
            string fullPath = Path.Combine(saveFolder, fileName);

            System.IO.File.WriteAllBytes(fullPath, fileContent);

            // Return only PDF file name
            return Ok(new { fileName });
        }

        [HttpPost("ShowReports")]
        public async Task<IActionResult> ShowReports([FromBody] JsonElement data)
        {
            JObject jObject = JObject.Parse(data.ToString());

            string reportType = jObject["reportType"]?.ToString()?.ToLower() ?? "pdf";
            string reportName = jObject["reportName"]?.ToString() ?? "";
            string dataJson = jObject["data"]?.ToString() ?? "";
            string parametersJson = jObject["params"]?.ToString() ?? "";
            string dataSetName = jObject["dataSetName"]?.ToString() ?? "";

            // Convert dataJson to DataTable
            DataTable dataTable = new DataTable();
            if (!string.IsNullOrEmpty(dataJson))
            {
                try
                {
                    dataTable = JsonConvert.DeserializeObject<DataTable>(dataJson);
                    dataTable.TableName = dataSetName;
                }
                catch (Exception ex)
                {
                    return BadRequest($"Invalid data format for DataTable: {ex.Message}");
                }
            }

            // Convert paramsJson to Dictionary<string, object>
            var paramsObj = new Dictionary<string, object>();
            if (!string.IsNullOrEmpty(parametersJson))
            {
                try
                {
                    JArray paramArray = JArray.Parse(parametersJson);
                    foreach (JObject obj in paramArray)
                    {
                        var key = obj["key"]?.ToString();
                        var value = obj["value"]?.ToString();

                        if (!string.IsNullOrEmpty(key))
                        {
                            paramsObj[key] = value ?? string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    return BadRequest($"Invalid params format: {ex.Message}");
                }
            }

            // Build Report Path
            string reportPath = Path.Combine(Directory.GetCurrentDirectory(), "Reports", "RDLC",
                                             string.IsNullOrEmpty(reportName) ? "Sample.rdlc" : reportName);

            if (!System.IO.File.Exists(reportPath))
                return NotFound($"Report file not found: {reportPath}");

            string renderFormat = reportType.ToLower() switch
            {
                "pdf" => "PDF",
                "excel" => "EXCELOPENXML",
                "word" => "WORDOPENXML",
                "image" => "IMAGE",
                _ => "PDF"
            };

            // Export RDLC
            var fileContent = _rdlcService.ExportReport(reportPath, dataTable, renderFormat, dataSetName, paramsObj);

            // Decide folder & extension by report type
            string extension = reportType switch
            {
                "pdf" => "pdf",
                "excel" => "xlsx",
                "word" => "docx",
                "image" => "png",
                _ => "bin"
            };

            string saveFolder = Path.Combine(Directory.GetCurrentDirectory(), "Reports", extension.ToUpperInvariant());
            if (!Directory.Exists(saveFolder))
                Directory.CreateDirectory(saveFolder);

            string fileName = $"Report_{DateTime.Now:yyyyMMddHHmmss}.{extension}";
            string fullPath = Path.Combine(saveFolder, fileName);

            System.IO.File.WriteAllBytes(fullPath, fileContent);

            // Return JSON with file name and type
            return Ok(new { fileName, reportType = extension });
        }

    }
}
