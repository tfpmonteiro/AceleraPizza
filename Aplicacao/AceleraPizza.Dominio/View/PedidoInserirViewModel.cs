using AceleraPizza.Dominio.Dto;
using AceleraPizza.Dominio.Model;
using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.View
{
    public class PedidoInserirViewModel
    {
        public Guid IdClienteDto { get; set; }
        public List<Pizza> PizzasDto { get; set; }
    }
}
