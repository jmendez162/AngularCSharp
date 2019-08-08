﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA.Entity
{
    [Table("COMENTARIO")]
    public class CComentario
    {
        [Key]
        [Column("CODIGO")]
        public int CODIGO { get; set; }
        [Column("CONTENIDO")]
        [MaxLength(240)]
        public string CONTENIDO { get; set; }
        [Column("USUARIO")]
        [MaxLength(40)]
        public string USUARIO { get; set; }
        [Column("FEC_PUBLICADO")]
        public DateTime FEC_PUBLICADO { get; set; }
        [Column("TICKET_RESTAURANT")]
        public int TICKET_RESTAURANT{ get; set; }
        [ForeignKey("TICKET_RESTAURANT")]
        public virtual CRestaurante Ticket { get; set; }
    }
}