using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class RecurringJournalC
{
    public int Id { get; set; }

    public int? RecuId { get; set; }

    public int? ActCode { get; set; }

    public decimal? Dr { get; set; }

    public decimal? Cr { get; set; }

    public string? Memo { get; set; }
}
