﻿using System;
using System.Collections.Generic;

namespace OnlineShop.Models;

public partial class User
{
    public int? Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }
}
