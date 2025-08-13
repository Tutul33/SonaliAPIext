using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class WrongEntry
{
    public int Id { get; set; }

    public string? TrnNo { get; set; }

    public DateTime? Edate { get; set; }
}
