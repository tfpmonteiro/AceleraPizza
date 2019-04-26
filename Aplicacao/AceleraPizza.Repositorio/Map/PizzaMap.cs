using AceleraPizza.Dominio.Model;
using Dapper.FluentMap.Dommel.Mapping;

namespace AceleraPizza.Repositorio.Map
{
    public class PizzaMap : DommelEntityMap<Pizza>
    {
        public PizzaMap()
        {
            ToTable("Pizza");
            Map(col => col.Id).ToColumn("IdPedido").IsKey();
            Map(col => col.Ingredientes).Ignore();
            Map(col => col.ValorPizza).Ignore();
        }
    }
}
