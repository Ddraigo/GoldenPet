using System;
using System.Collections.Generic;

namespace GoldenPet.Models;

public partial class TbMenu
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Link { get; set; }

    public string? Meta { get; set; }

    public bool? Hide { get; set; }

    public int? Order { get; set; }

    public DateTime? Datebegin { get; set; }
}
