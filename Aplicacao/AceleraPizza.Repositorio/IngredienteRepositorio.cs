using System;
using System.Collections.Generic;
using System.Linq;
using AceleraPizza.Dominio.Interface.Repositorio;
using AceleraPizza.Dominio.Model;
using Dommel;

namespace AceleraPizza.Repositorio
{
    public class IngredienteRepositorio : BaseRepositorio, IIngredienteRepositorio
    {
        public void Atualizar(Ingrediente ingrediente)
        {
            try
            {
                Conexao.Open();
                Conexao.Update(ingrediente);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public Ingrediente BuscarPorId(Guid id)
        {
            try
            {
                Conexao.Open();
                return Conexao.Get<Ingrediente>(id);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public List<Ingrediente> BuscarTodos()
        {
            try
            {
                Conexao.Open();
                return Conexao.GetAll<Ingrediente>().ToList();
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
                Conexao.Delete(new Ingrediente() { Id = id });
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void Inserir(Ingrediente ingrediente)
        {
            try
            {
                Conexao.Open();
                Conexao.Insert(ingrediente);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
