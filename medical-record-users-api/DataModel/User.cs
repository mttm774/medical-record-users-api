using System;
using System.Collections.Generic;

namespace medical_record_users_api.DataModel;

public partial class User
{
    public decimal Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public decimal? Intentos { get; set; }

    public string? Firma { get; set; }

    public virtual ICollection<Medico> Medicos { get; set; } = new List<Medico>();
}
