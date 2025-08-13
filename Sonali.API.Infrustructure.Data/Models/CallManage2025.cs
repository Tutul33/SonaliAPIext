﻿using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class CallManage2025
{
    public int Id { get; set; }

    public int? FprId { get; set; }

    public string? CallCategory { get; set; }

    public string? StatusFlag { get; set; }

    public string? Comments { get; set; }

    public string? CallUser { get; set; }

    public DateTime? CallStart { get; set; }

    public DateTime? CallEnd { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? AgentCall { get; set; }
}
