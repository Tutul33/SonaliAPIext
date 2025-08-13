using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class TestQueue
{
    public int Id { get; set; }

    public string? TestVal { get; set; }

    public DateTime Dt { get; set; }
}
