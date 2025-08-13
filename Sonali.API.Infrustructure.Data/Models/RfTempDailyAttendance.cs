using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class RfTempDailyAttendance
{
    public long Sl { get; set; }

    public long? Rfid { get; set; }

    public string? UserType { get; set; }

    public int? UserId { get; set; }

    public int? BranchId { get; set; }

    public DateTime? LogTime { get; set; }
}
