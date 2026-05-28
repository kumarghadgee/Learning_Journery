using System;
using System.Collections.Generic;

namespace _01_DemoEntityFramework.Pocos;

public partial class Emp
{
    public int No { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;
}
