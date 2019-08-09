using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA.Entity.General
{
    [Table("ROL")]
    public class CRol
    {
        [Column("CODIGO")]
        public int CODIGO { get; set; }

        [Column("DESCRIPCION")]
        public string DESCRIPCION { get; set; }
    }
}
