using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class BankAcc
{
    public int Id { get; set; }

    public decimal? ActCode { get; set; }

    public string? AccNo { get; set; }

    public string? AccType { get; set; }

    public string? AccHolder { get; set; }

    public int? BankId { get; set; }

    public string? Branch { get; set; }
}
