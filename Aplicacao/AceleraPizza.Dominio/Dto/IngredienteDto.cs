using System.Collections.Generic;

namespace AceleraPizza.Dominio.Dto
{
    public class IngredienteDto : EntidadeDto
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }
    }

    public class IngredienteDtoReturn
    {
        public IngredienteDto Ingrediente { get; set; }
        public List<string> Erros { get; set; }

        public IngredienteDtoReturn(IngredienteDto ingredienteDto)
        {
            Ingrediente = ingredienteDto;
            Erros = new List<string>();
        }

        public IngredienteDtoReturn(List<string> erros)
        {
            Erros = erros;
        }
    }
}
