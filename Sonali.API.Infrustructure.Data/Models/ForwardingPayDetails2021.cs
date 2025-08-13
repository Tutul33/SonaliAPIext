﻿using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class ForwardingPayDetails2021
{
    public int Id { get; set; }

    public int? ForwardingId { get; set; }

    public string? PaymentMethod { get; set; }

    public string? AccountCode { get; set; }

    public string? BankName { get; set; }

    public string? RefNo { get; set; }

    public string? ChequeDate { get; set; }

    public string? DocImage { get; set; }

    public int? Amount { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? Year { get; set; }

    public int? Advanced { get; set; }

    public string? Details { get; set; }

    public string? Commence { get; set; }
}
