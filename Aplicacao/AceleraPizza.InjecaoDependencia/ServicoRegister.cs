using Unity;
using AceleraPizza.Dominio.Interface.Service;
using Unity.Lifetime;
using AceleraPizza.Service;

namespace AceleraPizza.InjecaoDependencia
{
    public class ServicoRegister
    {
        public static void Register(IUnityContainer container)
        {
            container.RegisterType<IClienteService, ClienteService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IIngredienteService, IngredienteService>(new ContainerControlledLifetimeManager());
        }
    }
}
