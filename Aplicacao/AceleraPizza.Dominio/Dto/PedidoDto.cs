using System.Collections.Generic;

namespace AceleraPizza.Dominio.Dto
{
    public class PedidoDto
    {
        public ClienteDto ClienteDto { get; set; }
        public List<PizzaDto> PizzasDto { get; set; }
        public double ValorPedido { get; set; }
    }
}
