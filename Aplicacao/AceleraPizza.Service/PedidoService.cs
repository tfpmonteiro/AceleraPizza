using AceleraPizza.Dominio.Dto;
using AceleraPizza.Dominio.Interface.Repositorio;
using AceleraPizza.Dominio.Model;
using AceleraPizza.Dominio.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceleraPizza.Service
{
    public class PedidoService
    {
        private IPizzaRepositorio _pizza;
        private IIngredienteRepositorio _ingrediente;
        private IPizzaIngredienteRepositorio _pizzaIngrediente;
        private IClienteRepositorio _cliente;

        public PedidoService(IPizzaRepositorio pizza, IIngredienteRepositorio ingrediente, IPizzaIngredienteRepositorio pizzaIngrediente, 
            IClienteRepositorio cliente)
        {
            pizza = _pizza;
            ingrediente = _ingrediente;
            pizzaIngrediente = _pizzaIngrediente;
            cliente = _cliente;
        }

        public PedidoDtoReturn Inserir(PedidoInserirViewModel pedidoViewModel)
        {
            var cliente = _cliente.BuscarPorId(pedidoViewModel.IdClienteDto);
            var pedido = new Pedido(cliente);
            
            foreach(var pizzaPedido in pedidoViewModel.PizzasDto)
            {
                _pizza.Inserir(pizzaPedido);

               foreach(var ingredientePizza in pizzaPedido.Ingredientes)
                {
                    var pizzaIngrediente = new PizzaIngrediente(ingredientePizza, pizzaPedido);
                    _pizzaIngrediente.Inserir(ingredientePizza);
                }
            }
        }

    }
}
