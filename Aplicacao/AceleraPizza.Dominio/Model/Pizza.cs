using AceleraPizza.Dominio.Enum;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Model
{
    public class Pizza : EntidadeDominio
    {
        public List<Ingrediente> Ingredientes { get; set; }
        public EnumTamanho Tamanho { get; set; }
        public EnumBorda Borda { get; set; }
        public double ValorPizza { get; set; }

        public Pizza(List<Ingrediente> ingredientes, EnumTamanho tamanho, EnumBorda borda)
        {
            Ingredientes = ingredientes;
            Tamanho = tamanho;
            Borda = borda;
            ValorPizza = CalcularPizza(ingredientes, borda, tamanho);
        }

        public double CalcularPizza(List<Ingrediente> ingredientes, EnumBorda borda, EnumTamanho tamanho)
        {
            double valorPizza = 0;

            foreach(var ingrediente in ingredientes)
            {
                valorPizza = valorPizza + ingrediente.Valor;
            }

            var valorBorda = CalcularBorda(borda);
            var valorTamanho = CalcularTamanho(tamanho);

            return valorPizza + valorBorda + valorTamanho;
        }

        private double CalcularBorda(EnumBorda borda)
        {
            double valor = 0;
            switch (borda)
            {
                case EnumBorda.Catupíry:
                    return valor += 5;

                case EnumBorda.Cheddar:
                    return valor += 4.5;

                default:
                    return valor;
            }
        }

        private double CalcularTamanho(EnumTamanho tamanho)
        {
            double valor = 0;

            switch (tamanho)
            {
                case EnumTamanho.Pequena:
                    return valor += 10;

                case EnumTamanho.Media:
                    return valor += 15;

                default:
                    return valor + 20;
            }
        }
    }
}
