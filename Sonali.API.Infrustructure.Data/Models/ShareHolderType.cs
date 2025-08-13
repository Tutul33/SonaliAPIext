﻿using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class ShareHolderType
{
    public decimal Id { get; set; }

    public string? Type { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
