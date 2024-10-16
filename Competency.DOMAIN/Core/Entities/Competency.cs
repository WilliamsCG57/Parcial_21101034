using System;
using System.Collections.Generic;

namespace Competency.DOMAIN.Core.Entities;

public partial class Competency
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Level { get; set; }
}
