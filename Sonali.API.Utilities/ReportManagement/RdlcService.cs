using Microsoft.Reporting.NETCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Utilities.ReportManagement
{
    public interface IRdlcService
    {
        byte[] ExportReport(string reportPath, DataTable data, string format, string dataSetName, Dictionary<string, object>? parameters = null);
    }

    public class RdlcService : IRdlcService
    {
        public byte[] ExportReport(string reportPath, DataTable data, string format, string dataSetName, Dictionary<string, object>? parameters = null)
        {
            try
            {
                using var localReport = new LocalReport();
                localReport.ReportPath = reportPath;

                // Add DataSource
                localReport.DataSources.Add(new ReportDataSource("DataSet1", data));

                // Add parameters if any
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        localReport.SetParameters(new ReportParameter(param.Key, param.Value.ToString()));
                    }
                }

                string mimeType, encoding, fileNameExtension;
                string[] streams;
                Warning[] warnings;

                var renderedBytes = localReport.Render(
                    format: format,          // "PDF", "Excel", "Word"
                    deviceInfo: null,
                    out mimeType,
                    out encoding,
                    out fileNameExtension,
                    out streams,
                    out warnings
                );

                return renderedBytes;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
