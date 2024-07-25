using System;
using System.Collections.Generic;

namespace medical_record_users_api.DataModel;

public partial class RipsAc
{
    public string? Numerofactura { get; set; }

    public string? CodigoPrestador { get; set; }

    public string TipoDoc { get; set; } = null!;

    public string NumDoc { get; set; } = null!;

    public string? FechaCons { get; set; }

    public string NumAutoriz { get; set; } = null!;

    public string? Cups { get; set; }

    public string? Finalidad { get; set; }

    public string? CausaExt { get; set; }

    public string? DxPpal { get; set; }

    public string? DxRel1 { get; set; }

    public string? DxRel2 { get; set; }

    public string? DxRel3 { get; set; }

    public string? TipoDxPpal { get; set; }

    public string ValorConsulta { get; set; } = null!;

    public string CuotaModera { get; set; } = null!;

    public string ValorNetoPagar { get; set; } = null!;

    public DateTime? FechaAtencion { get; set; }
}
