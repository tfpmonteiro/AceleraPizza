using AceleraPizza.Dominio.Enum;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Dto
{
    public class PizzaDto
    {
        public List<IngredienteDto> Ingredientes { get; set; }
        public EnumTamanho Tamanho { get; set; }
        public EnumBorda Borda { get; set; }
        public double ValorPizza { get; set; }
    }
}
