using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouHungry.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int PratoId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Datahora { get; set; }
        public Usuario Usuario { get; set; }
        public Prato Prato { get; set; }
    }
}
