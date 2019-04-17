using AceleraPizza.Dominio.Interface.Repositorio;
using AceleraPizza.Repositorio;
using Unity;
using Unity.Lifetime;

namespace AceleraPizza.InjecaoDependencia
{
    public class RepositorioRegister
    {
        public static void Register(IUnityContainer container)
        {
            container.RegisterType<IClienteRepositorio, ClienteRepositorio>(new ContainerControlledLifetimeManager());
        }
    }
}