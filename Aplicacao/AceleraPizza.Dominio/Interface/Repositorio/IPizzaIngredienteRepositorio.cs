using AceleraPizza.Dominio.Model;
using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Interface.Repositorio
{
    public interface IPizzaIngredienteRepositorio
    {
        void Inserir(PizzaIngrediente pizzaIngrediente);
        void Atualizar(PizzaIngrediente pizzaIngrediente);
        void Excluir(Guid id);
        PizzaIngrediente BuscarPorId(Guid id);
        List<PizzaIngrediente> BuscarTodos();
    }
}
