using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class AccDemo
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreateDate { get; set; }
}
