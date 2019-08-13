using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CSA.Entity.ComBeb;

namespace CSA.Entity.DataBase
{
    public class CSAEntities : DbContext
    {
        public CSAEntities() : base("CSAContext") { }

        public DbSet<CComentario> Comentario { get; set; }
        public DbSet<CUsuario> Usuarios { get; set; }
        public DbSet<CProvincia> Provincias { get; set; }
        public DbSet<CNacionalidad> Nacionalidades { get; set; }
        public DbSet<CSexo> Sexos { get; set; }
        public DbSet<CRestaurante> Restaurantes { get; set; }
        public DbSet<CComBeb> Comidas { get; set; }
    }
}
