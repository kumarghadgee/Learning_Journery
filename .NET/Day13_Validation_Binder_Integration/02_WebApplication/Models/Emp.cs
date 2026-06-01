using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace _02_WebApplication.Models;

public partial class Emp
{
    public int No { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }

    public string Address { get; set; }
}
