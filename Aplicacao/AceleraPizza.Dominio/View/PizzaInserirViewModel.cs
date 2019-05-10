using AceleraPizza.Dominio.Dto;
using AceleraPizza.Dominio.Enum;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.View
{
    public class PizzaInserirViewModel
    {
        public List<IngredienteDto> Ingredientes { get; set; } = new List<IngredienteDto>();
        public EnumTamanho Tamanho { get; set; }
        public EnumBorda Borda { get; set; }
    }
}
