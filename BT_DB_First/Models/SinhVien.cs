using System;
using System.Collections.Generic;

namespace BT_DB_First.Models;

public partial class SinhVien
{
    public int Id { get; set; }

    public string? Ten { get; set; }

    public int? Tuoi { get; set; }

    public string? DiaChi { get; set; }
}
