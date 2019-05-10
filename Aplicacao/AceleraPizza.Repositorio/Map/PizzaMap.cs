using AceleraPizza.Dominio.Model;
using Dapper.FluentMap.Dommel.Mapping;

namespace AceleraPizza.Repositorio.Map
{
    public class PizzaMap : DommelEntityMap<Pizza>
    {
        public PizzaMap()
        {
            ToTable("Pizza");
            Map(col => col.Id).ToColumn("IdPizza").IsKey();
            Map(col => col.ValorPizza).ToColumn("ValorPizza");
            Map(col => col.Ingredientes).Ignore();
        }
    }
}
