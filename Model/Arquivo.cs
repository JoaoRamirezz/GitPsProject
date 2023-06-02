using System;
using System.Collections.Generic;

namespace GitPsProject.Model;

public partial class Arquivo
{
    public int Id { get; set; }

    public string? Diretorio { get; set; }

    public DateTime? DataEnvio { get; set; }
}
