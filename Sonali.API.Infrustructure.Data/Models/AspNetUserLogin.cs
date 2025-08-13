using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class AspNetUserLogin
{
    public string UserId { get; set; } = null!;

    public string LoginProvider { get; set; } = null!;

    public string ProviderKey { get; set; } = null!;
}
