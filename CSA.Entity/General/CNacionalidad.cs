using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA.Entity
{
    [Table("NACIONALIDADES")]
    public class CNacionalidad
    {
        [Key]
        [Column("CODIGO")]
        public int CODIGO { get; set; }
        [Column("DESCRIPCION")]        
        [MaxLength(80)]
        public string DESCRIPCION { get; set; }
    }
}
