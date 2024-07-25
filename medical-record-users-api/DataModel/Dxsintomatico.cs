using System;
using System.Collections.Generic;

namespace medical_record_users_api.DataModel;

public partial class Dxsintomatico
{
    public decimal Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Descwithoutaccents { get; set; }

    public string Valor { get; set; } = null!;

    public string? Auxiliar1 { get; set; }

    public string? Auxiliar2 { get; set; }

    public string? Auxiliar3 { get; set; }

    public string? Auxiliar4 { get; set; }

    public decimal? Orden { get; set; }
}
