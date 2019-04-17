using AceleraPizza.Dominio.Model;
using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Interface.Repositorio
{
    public interface IClienteRepositorio
    {
        void Inserir(Cliente cliente);
        void Atualizar(Cliente cliente);
        void Excluir(Guid id);
        Cliente BuscarPorId(Guid id);
        List<Cliente> BuscarTodos();
    }
}
