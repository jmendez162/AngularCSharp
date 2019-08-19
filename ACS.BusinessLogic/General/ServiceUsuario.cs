using CSA.DataAccess.General;
using CSA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACS.BusinessLogic.General
{
    public class ServiceUsuario
    {
        DataUsuario data = new DataUsuario(); 
    
        public bool AgregarUsuario(CUsuario usuario)
        {
            return data.AgregarUsuario(usuario);
        }
    }
}
