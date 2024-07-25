using System;
using System.Collections.Generic;

namespace medical_record_users_api.DataModel;

public partial class ViewReportAttention
{
    public string TipoDocumento { get; set; } = null!;

    public string NumeroDocumento { get; set; } = null!;

    public string? CodigoCie10 { get; set; }

    public string DiagnosticoPrincipal { get; set; } = null!;

    public string? DiagnosticoSintomatico { get; set; }

    public string Especialidad { get; set; } = null!;

    public string Medico { get; set; } = null!;

    public DateTime? Fecha { get; set; }
}
