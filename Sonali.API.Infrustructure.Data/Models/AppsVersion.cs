using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class AppsVersion
{
    public int Id { get; set; }

    public string? AppName { get; set; }

    public int? VersionNo { get; set; }

    public string? Msg { get; set; }
}
