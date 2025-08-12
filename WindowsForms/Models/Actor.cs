using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Models
{
    public class Actor
    {
        public int Id { get; set; } = 0;
        public string Nombre { get; set; } = string.Empty;
        public int? PaisId { get; set; }
        public Pais Pais { get; set; }
        public bool Eliminado { get; set; } = false;
        public override string ToString()
        {
            return Nombre;
        }
    }
}
