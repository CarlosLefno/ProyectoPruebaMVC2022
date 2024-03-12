using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace CRUDCORE.Models
{
    public class UsuarioModels
    {
        public int id { get; set; }
        public string? rut { get; set; }
        public string? nom { get; set; }
        public string? apepat { get; set; }
        public string? apemat { get; set; }
        public string? direccion { get; set; }
        public string? telefono { get; set; }
        public string? email { get; set; }
        public string? clave { get; set; }
        public int estado { get; set; }

    }
}
