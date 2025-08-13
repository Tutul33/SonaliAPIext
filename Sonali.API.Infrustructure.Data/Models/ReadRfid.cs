using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class ReadRfid
{
    public long Rfid { get; set; }

    public DateTime? CreateDate { get; set; }
}
