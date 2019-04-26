using System;

namespace AceleraPizza.Dominio.Dto
{
    public class IngredienteSearchDto
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
    }
}
