using System;
using System.Collections.Generic;

namespace medical_record_users_api.DataModel;

public partial class RipsAf
{
    public DateTime? FechaAtencion { get; set; }

    public string? CodigoPrestador { get; set; }

    public string? RazonSocial { get; set; }

    public string? TipoIdentifi { get; set; }

    public string? Nit { get; set; }

    public int? NumeroFactura { get; set; }

    public string? ExpedFactura { get; set; }

    public string? FecIniFactura { get; set; }

    public string? FecFinFactura { get; set; }

    public string? CodigoEps { get; set; }

    public string? NombreEps { get; set; }

    public string NumContrato { get; set; } = null!;

    public string PlanBeneficios { get; set; } = null!;

    public string NumPoliza { get; set; } = null!;

    public string ValorCopago { get; set; } = null!;

    public string ValorComision { get; set; } = null!;

    public string ValorDescuento { get; set; } = null!;

    public string ValorNetoPagar { get; set; } = null!;
}
