using System;
using System.Collections.Generic;

namespace OnlineShop.Models;

public partial class ProductImage
{
    public int? Id { get; set; }

    public int? ProductId { get; set; }

    public byte[]? Image { get; set; }

    public int? Cover { get; set; }
}
