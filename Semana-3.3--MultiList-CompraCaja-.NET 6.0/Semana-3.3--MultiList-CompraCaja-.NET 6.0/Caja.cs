using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_3._3__MultiList_CompraCaja_.NET_6._0
{
    internal class Caja
    {
        public Caja() { }

        public String Codigo { get; set; }

        public String NombreCajero { get; set; }

        public String Fecha { get; set; }

        public List<Compra> Compras { get; set; }
    }
}
