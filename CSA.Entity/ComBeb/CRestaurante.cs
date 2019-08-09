using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA.Entity.ComBeb
{
    [Table("RESTAURANTE")]
    public class CRestaurante
    {
        [Key]
        [Column("CODIGO")]
        public int CODIGO { get; set; }

        [Column("NOMBRE")]
        public string NOMBRE { get; set; }

        [Column("DIRECCION")]
        public string DIRECCION { get; set; }

        [Column("PROVINCIA")]
        public int PROVINCIA { get; set; }

        [ForeignKey("PROVINCIA")]
        public virtual CProvincia CProvincia { get; set; }

        [Column("RATING")]
        public double RATING { get; set; }




    }
}
