using AceleraPizza.Dominio.Interface.Repositorio;
using AceleraPizza.Dominio.Model;
using Dommel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AceleraPizza.Repositorio
{
    public class PizzaIngredienteRepositorio : BaseRepositorio, IPizzaIngredienteRepositorio
    {
        public void Atualizar(PizzaIngrediente pizzaIngrediente)
        {
            try
            {
                Conexao.Open();
                Conexao.Update(pizzaIngrediente);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void Inserir(PizzaIngrediente pizzaIngrediente)
        {
            try
            {
                Conexao.Open();
                Conexao.Insert(pizzaIngrediente);
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
                Conexao.Delete(new PizzaIngrediente() { Id = id });
            }
            finally
            {
                Conexao.Close();
            }
        }

        public PizzaIngrediente BuscarPorId(Guid id)
        {
            try
            {
                Conexao.Open();
                return Conexao.Get<PizzaIngrediente>(id);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public List<PizzaIngrediente> BuscarTodos()
        {
            try
            {
                Conexao.Open();
                return Conexao.GetAll<PizzaIngrediente>().ToList();
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
