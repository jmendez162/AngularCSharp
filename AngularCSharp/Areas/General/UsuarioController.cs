using CSA.BusinessLogic.Interface.General;
using CSA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

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