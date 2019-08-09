using CSA.Entity.ComBeb;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA.Entity.ComBeb
{

    public class CComBeb
    {
        [Key]
        [Column("CODIGO")]
        public int CODIGO { get; set; }

        [Column("NOMBRE")]
        public string NOMBRE { get; set; }

        [Column("TIPO")]
        public int TIPO { get; set; }

        [ForeignKey("TIPO")]
        public virtual CTipoComBeb CTipoComBeb { get; set; }

        [Column("PRECIO")]
        public double PRECIO { get; set; }

        [Column("RATING")]
        public double RATING { get; set; }

        [MaxLength(240)]
        [Column("DESCRIPCION")]
        public string DESCRIPCION { get; set; }
    }
}
