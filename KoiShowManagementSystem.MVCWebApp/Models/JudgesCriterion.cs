﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace KoiShowManagementSystem.MVCWebApp.Models;

public partial class JudgesCriterion
{
    public int CriteriaId { get; set; }

    public int? Point { get; set; }

    public string Expertise { get; set; }

    public string Description { get; set; }

    public string Species { get; set; }

    public int? ContestId { get; set; }

    public double? Weight { get; set; }

    public double? Size { get; set; }

    public string Color { get; set; }

    public int? Age { get; set; }

    public virtual Contest Contest { get; set; }

    public virtual ICollection<Judge> Judges { get; set; } = new List<Judge>();
}