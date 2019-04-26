using AceleraPizza.Dominio.Dto;
using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.View
{
    public class PedidoInserirViewModel
    {
        public Guid IdClienteDto { get; set; }
        public List<PizzaDto> PizzasDto { get; set; }
    }
}
