using Dapper.FluentMap.Dommel.Mapping;
using AceleraPizza.Dominio.Model;

namespace AceleraPizza.Repositorio.Map
{
    public class ClienteMap : DommelEntityMap<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");
            Map(col => col.Id).ToColumn("IdCliente").IsKey();
        }
    }
}
