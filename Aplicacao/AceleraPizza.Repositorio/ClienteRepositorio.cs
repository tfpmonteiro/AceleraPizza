using AceleraPizza.Dominio.Interface.Repositorio;
using AceleraPizza.Dominio.Model;
using Dommel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AceleraPizza.Repositorio
{
    public class ClienteRepositorio : BaseRepositorio, IClienteRepositorio
    {
        public void Atualizar(Cliente cliente)
        {
            try
            {
                Conexao.Open();
                Conexao.Update(cliente);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void Inserir(Cliente cliente)
        {
            try
            {
                Conexao.Open();
                Conexao.Insert(cliente);
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
                Conexao.Delete(new Cliente() { Id = id });
            }
            finally
            {
                Conexao.Close();
            }
        }

        public Cliente BuscarPorId(Guid id)
        {
            try
            {
                Conexao.Open();
                return Conexao.Get<Cliente>(id);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public List<Cliente> BuscarTodos()
        {
            try
            {
                Conexao.Open();
                return Conexao.GetAll<Cliente>().ToList();
            }
            finally
            {
                Conexao.Close();
            }
        }

    }
}