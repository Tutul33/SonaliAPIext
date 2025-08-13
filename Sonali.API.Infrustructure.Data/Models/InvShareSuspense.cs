using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class InvShareSuspense
{
    public decimal Id { get; set; }

    public decimal? Amt { get; set; }

    public DateOnly? Dt { get; set; }
}
