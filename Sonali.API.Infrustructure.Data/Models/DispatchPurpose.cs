using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class DispatchPurpose
{
    public int Sl { get; set; }

    public string? Purpose { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
