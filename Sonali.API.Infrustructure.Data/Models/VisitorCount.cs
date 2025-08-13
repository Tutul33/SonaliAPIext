using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class VisitorCount
{
    public decimal Sl { get; set; }

    public string? Ip { get; set; }

    public DateOnly? VisitDate { get; set; }
}
