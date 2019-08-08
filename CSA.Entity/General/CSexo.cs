using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA.Entity
{
    [Table("SEXO")]
    public class CSexo
    {
        [Column("CODIGO")]
        [Key]
        public int CODIGO { get; set; }

        [Column("DESCRIPCION")]
        [MaxLength(9)]
        public string DESCRIPCION { get; set; }
    }
}
