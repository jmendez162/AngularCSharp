using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA.Entity
{
    [Table("USUARIO")]
    public class CUsuario
    {
        [Column("CODIGO")]
        [Key]
        public int CODIGO { get; set; }

        [Column("NOMBRE")]
        public string NOMBRE { get; set; }
        [Column("CEDULA")]
        public string CEDULA { get; set; }
        [Column("FECHA_NACIMIENTO")]
        public DateTime FECHA_NACIMIENTO { get; set; }
        [Column("USERNAME")]
        public string USERNAME { get; set; }
        [Column("PASSWD")]
        public string PASSWD { get; set; }
        [Column("CORREO")]
        public string CORREO { get; set; }
        [Column("NUM_TELEFONO")]
        public string NUM_TELEFONO { get; set; }
        [Column("PROVINCIA")]
        public int PROVINCIA { get; set; }

        [ForeignKey("PROVINCIA")]
        public virtual CProvincia Provincia { get; set; }

        [Column("SEXO")]
        public int SEXO { get; set; }
        public virtual CSexo Sexo { get; set; }
    }
}
