using CSA.BusinessLogic.Interface.General;
using CSA.DataAccess.Interface.General;
using CSA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACS.BusinessLogic.General
{
    public class ServiceUsuario : IServiceUsuario
    {
        private readonly IDataUsuario data;
        public ServiceUsuario(IDataUsuario data)
        {
            this.data = data;
        }


        public bool AgregarUsuario(CUsuario usuario)
        {
            return data.AgregarUsuario(usuario);
        }
    }
}
