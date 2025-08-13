using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class PolicyAdvisor
{
    public int Id { get; set; }

    public string? AdvisorTitleBan { get; set; }

    public string? AdvisorTitleEng { get; set; }

    public int? AdvisorGroupId { get; set; }

    public int? ProductId { get; set; }

    public string? TitleType { get; set; }
}
