using CSA.Entity.ComBeb;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA.Entity.General
{
    public class CComentarioComida : CComentario
    {
        [Column("TICKET_COMIDA")]
        public int TICKET_RESTAURANT { get; set; }
        [ForeignKey("TICKET_COMIDA")]
        public virtual CComBeb Ticket { get; set; }
    }
}
