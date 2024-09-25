using Avalonia.Media.Imaging;
using System;
using System.Collections.Generic;

namespace Probnik.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public string? ProductDescription { get; set; }

    public int? ManufacturesId { get; set; }

    public int? Price { get; set; }

    public int? Sale { get; set; }

    public string? Images { get; set; }

    public virtual Manufacture? Manufactures { get; set; }
    // Преобразуем идентификаторы производителей в их наименования
    public string Manufacture => ManufacturesId == 1 ? "EcoFerm" : "Tech";
    // Преобразуем картинки из формата строки в Bitmap
    public Bitmap? Picture => Images != null ? new Bitmap($@"Assets\\{Images}") : null;
}
