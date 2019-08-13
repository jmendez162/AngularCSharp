using CSA.BusinessLogic.Interface.General;
using System.Web.Http;
using CSA.Entity;

namespace AngularCSharp.Areas.General
{
    [RoutePrefix("api/General/Usuarios")]
    public class UsuarioController : ApiController
    {
        private readonly IServiceUsuario service;
        public UsuarioController(IServiceUsuario service)
        {
            this.service = service;
        }
      
        [Route("AgregarUsuario")]
        [HttpPost]
        public bool AgregarUsuario(CUsuario usuario)
        {
            return service.AgregarUsuario(usuario);
        }
    }
}