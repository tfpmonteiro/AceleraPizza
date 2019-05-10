using AceleraPizza.Dominio.Model;
using Dapper.FluentMap.Dommel.Mapping;

namespace AceleraPizza.Repositorio.Map
{
    public class PedidoMap : DommelEntityMap<Pedido>
    {
        public PedidoMap()
        {
            ToTable("Pedido");
            Map(col => col.Id).ToColumn("IdPedido").IsKey();
            Map(col => col.Cliente.Id).ToColumn("IdCliente");
            Map(col => col.DataPedido).ToColumn("DataPedido");
            Map(col => col.ValorPedido).ToColumn("ValorPedido");
        }
    }
}
