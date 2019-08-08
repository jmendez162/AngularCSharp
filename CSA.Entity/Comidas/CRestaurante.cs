using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA.Entity
{
    [Table("RESTAURANTE")]
    public class CRestaurante
    {
        [Key]
        [Column("CODIGO")]
        public int CODIGO { get; set; }
    }
}
