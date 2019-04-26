using AceleraPizza.Dominio.Model;
using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Interface.Repositorio
{
    public interface IIngredienteRepositorio
    {
        void Inserir(Ingrediente ingrediente);
        void Atualizar(Ingrediente ingrediente);
        void Excluir(Guid id);
        Ingrediente BuscarPorId(Guid id);
        List<Ingrediente> BuscarTodos();
    }
}
