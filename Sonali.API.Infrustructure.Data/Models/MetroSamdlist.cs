using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class MetroSamdlist
{
    public int Id { get; set; }

    public int? AgentId { get; set; }

    public string? AgentName { get; set; }
}
