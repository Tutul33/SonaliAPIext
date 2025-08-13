using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class StoreItem
{
    public int ItemId { get; set; }

    public string? ItemName { get; set; }

    public int? ItemsCategory { get; set; }

    public double? ItemPrice { get; set; }

    public int ReorderLabel { get; set; }
}
