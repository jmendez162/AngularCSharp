using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA.Entity.General
{
    public class CReservas
    {
        public int CODIGO { get; set; }

        public int USUARIO { get; set; }
        public virtual CUsuario CUsuario {get;set;}
        public int RESTAURANTE { get; set; }
        public virtual CRestaurante CRestaurante { get; set; }
        public DateTime FEC_RES { get; set; }
        public DateTime FEC_TRA { get; set; }        
    }
}
