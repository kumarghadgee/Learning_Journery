using System;
using System.Collections.Generic;

namespace _01_DemoEntityFramework.Pocos;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string SubjectTitle { get; set; } = null!;
}
