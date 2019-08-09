using CSA.BusinessLogic.Interface.General;
using System.Web.Http;
using CSA.Entity;

namespace AngularCSharp.Areas.General
{
    [System.Web.Http.RoutePrefix("api/General/Usuarios")]
    public class UsuarioController : ApiController
    {
        private readonly IServiceUsuario service;
        public UsuarioController(IServiceUsuario service) : base()
        {
            this.service = service;
        }
        public bool AgregarUsuario(CUsuario usuario)
        {
            return service.AgregarUsuario(usuario);
        }
    }
}