using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public partial class Usertable
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public DateOnly Birthday { get; set; }
}
