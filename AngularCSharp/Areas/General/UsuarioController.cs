using System.Web.Http;
using ACS.BusinessLogic.General;
using CSA.Entity;

namespace AngularCSharp.Areas.General
{
    [RoutePrefix("api/General/Usuarios")]
    public class UsuarioController : ApiController
    {
        private readonly ServiceUsuario service;
     
        [Route("AgregarUsuario")]
        [HttpPost]
        public bool AgregarUsuario(CUsuario usuario)
        {
            return service.AgregarUsuario(usuario);
        }
    }
}