using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class DispatchOption
{
    public int Sl { get; set; }

    public int? PurposeSl { get; set; }

    public string? OptionName { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
