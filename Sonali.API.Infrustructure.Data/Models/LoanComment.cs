using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class LoanComment
{
    public int Id { get; set; }

    public int? LoanId { get; set; }

    public string? Comments { get; set; }
}
