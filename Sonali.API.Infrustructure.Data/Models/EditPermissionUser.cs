using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class EditPermissionUser
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? PagePermission { get; set; }
}
