using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class InvLand
{
    public int Id { get; set; }

    public string? ActCode { get; set; }

    public string? ProjectName { get; set; }

    public DateOnly? Dt { get; set; }

    public string? Location { get; set; }
}
