using CSA.BusinessLogic.Interface.General;
using System.Web.Http;
using CSA.Entity;

namespace AngularCSharp.Areas.General
{
    [RoutePrefix("api/General/Usuarios")]
    public class UsuarioController : ApiController
    {
        private readonly IServiceUsuario service;
      
        [Route("AgregarUsuario")]
        [HttpPost]
        public bool AgregarUsuario(CProvincia usuario)
        {
            return service.AgregarUsuario(usuario);
        }
    }
}