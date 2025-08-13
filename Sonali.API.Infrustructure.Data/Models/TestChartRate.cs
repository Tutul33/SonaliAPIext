﻿using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class TestChartRate
{
    public int Id { get; set; }

    public double? PlanId { get; set; }

    public double? TermOfYear { get; set; }

    public double? AllowableExpenseAgency { get; set; }

    public double? AllowableExpenseMgmt { get; set; }

    public double? TotalAllowableExpense { get; set; }

    public double? AllowableAtActual { get; set; }

    public string? Remarks { get; set; }
}
