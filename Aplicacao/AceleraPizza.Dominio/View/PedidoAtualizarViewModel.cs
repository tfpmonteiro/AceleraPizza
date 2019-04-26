using AceleraPizza.Dominio.Dto;
using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.View
{
    public class PedidoAtualizarViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid IdClienteDto { get; set; } = Guid.NewGuid();
        public List<PizzaDto> PizzasDto { get; set; } = new List<PizzaDto>();
    }
}
