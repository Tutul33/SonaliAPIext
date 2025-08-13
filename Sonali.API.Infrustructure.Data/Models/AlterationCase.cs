using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class AlterationCase
{
    public string CaseId { get; set; } = null!;

    public string? CaseName { get; set; }
}
