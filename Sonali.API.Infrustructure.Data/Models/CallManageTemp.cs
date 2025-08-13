using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class CallManageTemp
{
    public int Id { get; set; }

    public int? FprId { get; set; }

    public string? CallCategory { get; set; }

    public string? CallUser { get; set; }

    public string? Comments { get; set; }
}
