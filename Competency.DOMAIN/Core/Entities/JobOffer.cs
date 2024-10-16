using System;
using System.Collections.Generic;

namespace Competency.DOMAIN.Core.Entities;

public partial class JobOffer
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public float? Salary { get; set; }

    public string? Location { get; set; }
}
