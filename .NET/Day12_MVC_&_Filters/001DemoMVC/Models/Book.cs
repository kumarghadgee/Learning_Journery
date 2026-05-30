using System;
using System.Collections.Generic;

namespace _001DemoMVC.Models;

public class Book
{
    public int ISBN { get; set; }

    public string Title { get; set; } = null!;

    public string Author { get; set; } = null!;
}
