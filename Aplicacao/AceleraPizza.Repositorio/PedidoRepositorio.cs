using AceleraPizza.Dominio.Interface.Repositorio;
using AceleraPizza.Dominio.Model;
using Dommel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceleraPizza.Repositorio
{
    public class PedidoRepositorio : BaseRepositorio, IPedidoRepositorio
    {
        public void Atualizar(Pedido pedido)
        {
            try
            {
                Conexao.Open();
                Conexao.Insert(pedido);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public List<Pedido> BuscarPorCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Pedido BuscarPorId(Guid id)
        {
            try
            {
                Conexao.Open();
                return Conexao.Get<Pedido>(id);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public List<Pedido> BuscarTodos()
        {
            try
            {
                Conexao.Open();
                return Conexao.GetAll<Pedido>().ToList();
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void Excluir(Guid id)
        {
            try
            {
                Conexao.Open();
                Conexao.Delete<Pedido>(new Pedido() { Id = id });
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void Inserir(Pedido pedido)
        {
            try
            {
                Conexao.Open();
                Conexao.Insert(pedido);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
