using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA.Entity
{
    [Table("Provincia")]
    public class CProvincia
    {
        [Column("CODIGO")]
        [DisplayName("Código")]
        public int CODIGO { get; set; }
        [Column("DESCRIPCION")]
        [DisplayName("Provincia")]
        public string DESCRIPCION { get; set; }
    }
}
