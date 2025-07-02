using System;
using System.Collections.Generic;

namespace NvkLesson10.Models;

public partial class NvkPost
{
    public int NvkId { get; set; }

    public string? NvkTitle { get; set; }

    public string? NvkImage { get; set; }

    public string? NvkContent { get; set; }

    public bool? NvkStatus { get; set; }
}
