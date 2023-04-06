﻿using System;
using System.Collections.Generic;

namespace ProjectBookStore.Models;

public partial class ChuDe
{
    public int MaChuDe { get; set; }

    public string? TenChuDe { get; set; }

    public virtual ICollection<Sach> Saches { get; } = new List<Sach>();
}
