using System;
using System.Collections.Generic;

namespace ProjectBookStore.Models;

public partial class ThamGium
{
    public int MaSach { get; set; }

    public int MaTacGia { get; set; }

    public string? VaiTro { get; set; }

    public string? ViTri { get; set; }

    public virtual Sach MaSachNavigation { get; set; } = null!;

    public virtual TacGium MaTacGiaNavigation { get; set; } = null!;
}
