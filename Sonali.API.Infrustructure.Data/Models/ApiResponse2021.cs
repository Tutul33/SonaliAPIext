﻿using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class ApiResponse2021
{
    public int Id { get; set; }

    public string? Company { get; set; }

    public string? Response { get; set; }

    public DateTime? CreateDate { get; set; }
}
