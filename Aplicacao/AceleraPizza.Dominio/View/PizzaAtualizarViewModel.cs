using AceleraPizza.Dominio.Dto;
using AceleraPizza.Dominio.Enum;
using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.View
{
    public class PizzaAtualizarViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public List<IngredienteDto> Ingredientes { get; set; } = new List<IngredienteDto>();
        public EnumTamanho Tamanho { get; set; }
        public EnumBorda Borda { get; set; }
    }
}
