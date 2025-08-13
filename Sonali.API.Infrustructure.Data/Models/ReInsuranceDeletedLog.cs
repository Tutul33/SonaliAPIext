using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class ReInsuranceDeletedLog
{
    public int DeletedId { get; set; }

    public int? SummaryId { get; set; }

    public int? SlNo { get; set; }

    public string? Rowdata { get; set; }

    public DateTime? PosytedOn { get; set; }
}
