using CSA.DataAccess.Interface.General;
using CSA.Entity;
using CSA.Entity.DataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA.DataAccess.General
{
    public class DataUsuario : IDataUsuario
    {
        public DataUsuario()
        {
        }

        public bool AgregarUsuario(CUsuario usuario)
        {
            using(CSAEntities cSA = new CSAEntities())
            {
                cSA.Usuarios.Add(usuario);
                cSA.SaveChanges();
            }
            return true;
        }
    }
}
