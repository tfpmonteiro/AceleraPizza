using AceleraPizza.Dominio.Base;

namespace AceleraPizza.Dominio.Model
{
    public class Ingredientes: EntidadeBase
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}