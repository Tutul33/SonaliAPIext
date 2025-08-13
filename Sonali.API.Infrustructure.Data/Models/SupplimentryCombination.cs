using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class SupplimentryCombination
{
    public int Id { get; set; }

    public int? SuppMasterId { get; set; }

    public int? SuppChildId { get; set; }
}
