using AceleraPizza.Dominio.Base;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Model
{
    public class Pedido: EntidadeBase
    {
        public Cliente Cliente { get; set; }
        public List<Ingredientes> Ingredientes { get; set; }
        public int Tamanho { get; set; }
        public double Valor { get; set; }
    }
}
