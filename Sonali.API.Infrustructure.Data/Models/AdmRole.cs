using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class AdmRole
{
    public int Id { get; set; }

    public string? RoleName { get; set; }

    public bool? IsActive { get; set; }
}
