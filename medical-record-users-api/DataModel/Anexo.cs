using System;
using System.Collections.Generic;

namespace medical_record_users_api.DataModel;

public partial class Anexo
{
    public decimal Id { get; set; }

    public string? TipoAnexo { get; set; }

    public byte[]? Anexo1 { get; set; }

    public string? NombreArchivo { get; set; }

    public string? Observaciones { get; set; }

    public decimal IdAtencion { get; set; }

    public virtual Atencion IdAtencionNavigation { get; set; } = null!;
}
