using CSA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA.DataAccess.Interface.General
{
    public interface IDataUsuario
    {
        bool AgregarUsuario(CProvincia usuario);
    }
}
