using System;
using System.Collections.Generic;

namespace medical_record_users_api.DataModel;

public partial class EventTracking
{
    public int Id { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Evento { get; set; }

    public decimal? Userid { get; set; }

    public string? Ipaddress { get; set; }

    public string? Username { get; set; }
}
