﻿using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class PaymentLog2021
{
    public int Sl { get; set; }

    public string? PolicyId { get; set; }

    public string? PolicyHoldersName { get; set; }

    public string? MobileNo { get; set; }

    public int? InstallmentNo { get; set; }

    public string? TranId { get; set; }

    public double? Amount { get; set; }

    public string? TranCase { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? DocumentId { get; set; }
}
