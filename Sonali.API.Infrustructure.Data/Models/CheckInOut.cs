using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class CheckInOut
{
    public int Sl { get; set; }

    public int? UserId { get; set; }

    public DateTime? CheckTime { get; set; }
}
