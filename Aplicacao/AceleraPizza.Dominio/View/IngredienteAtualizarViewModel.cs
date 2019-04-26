using System;

namespace AceleraPizza.Dominio.View
{
    public class IngredienteAtualizarViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Descricao { get; set; } = "";
        public double Valor { get; set; } = 0;
    }
}
