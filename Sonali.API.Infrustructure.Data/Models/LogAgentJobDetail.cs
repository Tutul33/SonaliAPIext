using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class LogAgentJobDetail
{
    public int LogAgentId { get; set; }

    public string? LogField { get; set; }

    public DateTime? LogDate { get; set; }

    public string? LogBy { get; set; }
}
