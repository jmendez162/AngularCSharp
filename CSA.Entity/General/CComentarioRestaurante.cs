using CSA.Entity.ComBeb;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA.Entity.General
{
    public class CComentarioRestaurante : CComentario
    {
        [Column("TICKET_RESTAURANT")]
        public int TICKET_RESTAURANT { get; set; }
        [ForeignKey("TICKET_RESTAURANT")]
        public virtual CRestaurante Ticket { get; set; }
    }
}
