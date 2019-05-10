using AceleraPizza.Dominio.Interface.Repositorio;
using AceleraPizza.Dominio.Model;
using Dommel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AceleraPizza.Repositorio
{
    public class PizzaRepositorio : BaseRepositorio, IPizzaRepositorio
    {
        public void Atualizar(Pizza pizza)
        {
            try
            {
                Conexao.Open();
                Conexao.Update(pizza);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public Pizza BuscarPorId(Guid id)
        {
            try
            {
                Conexao.Open();
                return Conexao.Get<Pizza>(id);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public List<Pizza> BuscarTodos()
        {
            try
            {
                Conexao.Open();
                return Conexao.GetAll<Pizza>().ToList();
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
                Conexao.Delete(new Pizza() { Id = id });
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void Inserir(Pizza pizza)
        {
            try
            {
                Conexao.Open();
                Conexao.Insert(pizza);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
