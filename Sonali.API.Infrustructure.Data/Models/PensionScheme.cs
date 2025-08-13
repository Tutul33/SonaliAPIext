using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class PensionScheme
{
    public int PensionId { get; set; }

    public int? EmpId { get; set; }

    public int? BranchId { get; set; }

    public double? PensionAmount { get; set; }
}
