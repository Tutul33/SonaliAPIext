﻿using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class TmpPolicyApplicantsFamilyHistory
{
    public int FamilyHistoryId { get; set; }

    public int ApplicantId { get; set; }

    public string? Relation { get; set; }

    public string? LifeStatus { get; set; }

    public string? Age { get; set; }

    public string? CurrentPhysicalStatus { get; set; }

    public string? AgeDuringDeath { get; set; }

    public string? DeathReason { get; set; }

    public string? DurationOfLastIllness { get; set; }

    public string? YearOfDeath { get; set; }

    public virtual PolicyApplicantsPersonalInfo Applicant { get; set; } = null!;
}
