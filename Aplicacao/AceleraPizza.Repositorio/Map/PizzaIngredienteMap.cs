using AceleraPizza.Dominio.Model;
using Dapper.FluentMap.Dommel.Mapping;

namespace AceleraPizza.Repositorio.Map
{
    public class PizzaIngredienteMap : DommelEntityMap<PizzaIngrediente>
    {
        public PizzaIngredienteMap()
        {
            ToTable("PizzaIngrediente");
            Map(col => col.Id).ToColumn("IdPizIng").IsKey();
            Map(col => col.Pizza.Id).ToColumn("IdPizza");
            Map(col => col.Quantidade).ToColumn("QtdIng");
        }
    }
}
