using System;
using System.Collections.Generic;
using System.Text;

namespace TiposDTO
{
    public abstract class Auditoria
    {
        public string UsuarioInc { get; set; }
        public string UsuarioAlt { get; set; }
        public DateTime DataHoraInc { get; set; }
        public DateTime DataHoraAlt { get; set; }
    }
}
