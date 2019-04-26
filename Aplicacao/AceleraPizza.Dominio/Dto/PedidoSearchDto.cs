using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Dto
{
    public class PedidoSearchDto
    {
        public ClienteDto ClienteDto { get; set; }
        public List<PizzaDto> PizzasDto { get; set; }
        public double ValorPedido { get; set; }
        public DateTime DataPedido { get; }
    }
}
