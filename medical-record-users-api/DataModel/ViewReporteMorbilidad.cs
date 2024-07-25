using System;
using System.Collections.Generic;

namespace medical_record_users_api.DataModel;

public partial class ViewReporteMorbilidad
{
    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public string? Sexo { get; set; }

    public string NumeroDocumento { get; set; } = null!;

    public DateTime? FechaNacimiento { get; set; }

    public string? TipoHistoriaEspecialidad { get; set; }

    public DateTime? FechaAtencion { get; set; }
}
