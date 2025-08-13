﻿using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class AgentYearlyTarget
{
    public int TargetId { get; set; }

    public int? AgentId { get; set; }

    public string? AgentType { get; set; }

    public int? TargetYear { get; set; }

    public double? TargetAmount { get; set; }

    public double? AchievedAmount { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
