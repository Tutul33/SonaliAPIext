using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class RfidReader
{
    public long Id { get; set; }

    public int? Rfid { get; set; }

    public int? NUserId { get; set; }

    public long? NDateTime { get; set; }

    public DateTime? LocalTime { get; set; }
}
