using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Dto
{
    public class PedidoDto
    {
        public ClienteDto ClienteDto { get; set; }
        public List<PizzaDto> PizzasDto { get; set; }
        public double ValorPedido { get; set; }
        public DateTime DataPedido { get; }
    }

    public class PedidoDtoReturn
    {
        public PedidoDto Pedido { get; set; }
        public List<string> Erros { get; set; }

        public PedidoDtoReturn(PedidoDto pedido)
        {
            Pedido = pedido;
            Erros = new List<string>();
        }

        public PedidoDtoReturn(List<string> erros)
        {
            Erros = erros;
        }
    }
}
