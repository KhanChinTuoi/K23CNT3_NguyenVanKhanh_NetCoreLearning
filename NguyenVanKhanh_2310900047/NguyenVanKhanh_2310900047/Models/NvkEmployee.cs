using System;
using System.Collections.Generic;

namespace NguyenVanKhanh_2310900047.Models;

public partial class NvkEmployee
{
    public int NvkEmpId { get; set; }

    public string? NvkEmpName { get; set; }

    public string? NvkEmpLevel { get; set; }

    public DateOnly? NvkEmpStartDate { get; set; }

    public bool? NvkEmpStatus { get; set; }
}
