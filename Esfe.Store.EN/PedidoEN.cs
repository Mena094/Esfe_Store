using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.Store.EN
{
    public class PedidoEN
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaPedido { get; set; }
        public byte Estado { get; set; }
        public decimal Total { get; set; }
    }
}
