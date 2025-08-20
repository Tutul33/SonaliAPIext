using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class DemoItemFileAttachment
{
    public int Id { get; set; }

    public int? DemoItemId { get; set; }

    public string? FileName { get; set; }

    public bool? IsActive { get; set; }
}
