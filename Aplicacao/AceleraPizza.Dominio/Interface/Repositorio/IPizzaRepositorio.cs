using AceleraPizza.Dominio.Model;
using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Interface.Repositorio
{
    public interface IPizzaRepositorio
    {
        void Inserir(Pizza pizza);
        void Atualizar(Pizza pizza);
        void Excluir(Guid id);
        Pizza BuscarPorId(Guid id);
        List<Pizza> BuscarTodos();
    }
}
