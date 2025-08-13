﻿using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class RecurringScheduleC
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Memo { get; set; }

    public string? Frequency { get; set; }

    public DateOnly? ActionDate { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? EntryBy { get; set; }

    public string? IsEnabled { get; set; }

    public DateOnly? EntryDate { get; set; }
}
