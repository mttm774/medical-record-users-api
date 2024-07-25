using System;
using System.Collections.Generic;

namespace medical_record_users_api.DataModel;

public partial class DetalleHistorium
{
    public decimal Id { get; set; }

    public string? Valor { get; set; }

    public decimal IdCampo { get; set; }

    public decimal IdHistoria { get; set; }

    public virtual CampoHistorium IdCampoNavigation { get; set; } = null!;

    public virtual HistoriaGeneral IdHistoriaNavigation { get; set; } = null!;
}
