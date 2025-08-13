using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class EmpAbsent
{
    public int Sl { get; set; }

    public int EmpId { get; set; }

    public long? Rfid { get; set; }

    public DateOnly? AbsentDate { get; set; }
}
