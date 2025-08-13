using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class AccExpense
{
    public int Sl { get; set; }

    public string? HeadId { get; set; }

    public string? HeadName { get; set; }

    public string? HeadType { get; set; }
}
