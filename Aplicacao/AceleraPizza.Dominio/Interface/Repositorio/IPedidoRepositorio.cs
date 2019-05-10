using AceleraPizza.Dominio.Model;
using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Interface.Repositorio
{
    public interface IPedidoRepositorio
    {
        void Inserir(Pedido pedido);
        void Atualizar(Pedido pedido);
        void Excluir(Guid id);
        Pedido BuscarPorId(Guid id);
        List<Pedido> BuscarPorCliente(Cliente cliente);
        List<Pedido> BuscarTodos()
    }
}
