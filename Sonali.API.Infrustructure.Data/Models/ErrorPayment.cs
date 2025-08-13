using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class ErrorPayment
{
    public int? PrBmNoChar { get; set; }

    public int? ApplicantPolicy { get; set; }

    public double? TotalDeposit { get; set; }

    public string? Type { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
