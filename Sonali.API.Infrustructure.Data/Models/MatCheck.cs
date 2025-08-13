using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class MatCheck
{
    public int Id { get; set; }

    public int? Fprid { get; set; }

    public double? Tpa { get; set; }

    public DateTime CreateDate { get; set; }
}
