using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class AccRcpsetting
{
    public decimal Id { get; set; }

    public string? ActCode { get; set; }

    public string? GroupName { get; set; }

    public int Applied { get; set; }
}
