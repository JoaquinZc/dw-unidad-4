using System;
using System.Collections.Generic;

namespace Unidad4.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string IdCategoria { get; set; } = null!;

    public int Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? Estado { get; set; }
}
