using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Model
{
    public class Pedido: EntidadeDominio
    {
        public Cliente Cliente { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public double ValorPedido { get; set; }
        public DateTime DataPedido{ get; }

        public Pedido(Cliente cliente, List<Pizza> pizzas)
        {
            Cliente = cliente;
            Pizzas = pizzas;
            DataPedido = DateTime.Now;
            ValorPedido = CalcularPedido(pizzas);
        }

        private double CalcularPedido(List<Pizza> pizzas)
        {
            double valor = 0;
            foreach (var pizza in pizzas)
            {
                valor = valor + pizza.ValorPizza;
            }

            return valor;
        }
    }
}
