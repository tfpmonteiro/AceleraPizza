using AceleraPizza.Dominio.Model;
using Dapper.FluentMap.Dommel.Mapping;

namespace AceleraPizza.Repositorio.Map
{
    public class IngredienteMap : DommelEntityMap<Ingrediente>
    {
        public IngredienteMap()
        {
            ToTable("Ingrediente");
            Map(col => col.Id).ToColumn("IdIngrediente").IsKey();
            Map(col => col.Valor).ToColumn("ValorIngrediente");
        }
    }
}
