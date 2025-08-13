﻿using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class TmpBkash
{
    public DateTime? DateTime { get; set; }

    public string? FromAccountNumber { get; set; }

    public string? ToAccountNumber { get; set; }

    public double? TransactionAmount { get; set; }

    public string? CouponAmount { get; set; }

    public double? TotalTransactioAmount { get; set; }

    public string? TransactionId { get; set; }

    public string? TransactionReference { get; set; }

    public DateTime? PostedOn { get; set; }
}
