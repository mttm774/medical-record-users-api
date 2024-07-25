using System;
using System.Collections.Generic;

namespace medical_record_users_api.DataModel;

public partial class HistoriaProcedimiento
{
    public decimal Id { get; set; }

    public string CodigoCups { get; set; } = null!;

    public decimal IdHistoria { get; set; }

    public string? Finalidad { get; set; }

    public virtual HistoriaGeneral IdHistoriaNavigation { get; set; } = null!;
}
