using System;
using System.Collections.Generic;

namespace medical_record_users_api.DataModel;

public partial class ResumenHistorium
{
    public decimal Id { get; set; }

    public string Titulo { get; set; } = null!;

    public string Valor { get; set; } = null!;

    public string SeccionPpal { get; set; } = null!;

    public decimal? Orden { get; set; }

    public decimal IdAtencion { get; set; }
}
