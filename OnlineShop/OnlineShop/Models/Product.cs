using System;
using System.Collections.Generic;

namespace OnlineShop.Models;

public partial class Product
{
    public int No { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Brand { get; set; }

    public string? Summary { get; set; }

    public string? InfoHtml { get; set; }

    public double? Price { get; set; }

    public string? Models { get; set; }

    public string? Tags { get; set; }

    public int? Active { get; set; }

    public int? Selling { get; set; }

    public string? Category { get; set; }
}
