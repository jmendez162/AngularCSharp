using ACS.BusinessLogic.General;
using CSA.BusinessLogic.Interface.General;
using CSA.DataAccess.General;
using CSA.DataAccess.Interface.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace CSA.GeneralConfiguration.DependencyInjection
{
    public static class InjectionGeneral
    {
        public static IUnityContainer unityContainer { get; set; }
        public static void Run(IUnityContainer container)
        {
            #region DataAccess
            container.RegisterType<IDataComentario, DataComentario>();
            container.RegisterType<IDataNacionalidad, DataNacionalidad>();
            container.RegisterType<IDataSexo, DataSexo>();
            container.RegisterType<IDataProvincia, DataProvincia>();
            container.RegisterType<IDataUsuario, DataUsuario>();
            #endregion
            #region Services
            container.RegisterType<IServiceUsuario, ServiceUsuario>();
            container.RegisterType<IServiceComentario, ServiceComentario>();
            #endregion
        }
    }
}
