using AceleraPizza.Dominio.Dto;
using AceleraPizza.Dominio.Interface.Repositorio;
using AceleraPizza.Dominio.Interface.Service;
using AceleraPizza.Dominio.Model;
using AceleraPizza.Dominio.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceleraPizza.Service
{
    public class IngredienteService : IIngredienteService
    {
        private IIngredienteRepositorio _repositorio;

        public IngredienteService(IIngredienteRepositorio ingrediente)
        {
            _repositorio = ingrediente;
        }

        public IngredienteDtoReturn Atualizar(IngredienteAtualizarViewModel ingredienteViewModel)
        {
            var ingrediente = _repositorio.BuscarPorId(ingredienteViewModel.Id);

            if(ingrediente == null)
            {
                var erros = new List<string>();
                erros.Add("Ingrediente não cadastrado.");
                return new IngredienteDtoReturn(erros);
            }

            ingrediente.Valor = ingredienteViewModel.Valor;

            _repositorio.Atualizar(ingrediente);

            return new IngredienteDtoReturn(BuscarPorId(ingrediente.Id));
        }

        public IngredienteDto BuscarPorId(Guid id)
        {
            Ingrediente ingrediente = _repositorio.BuscarPorId(id);

            if (ingrediente == null)
                return null;

            return new IngredienteDto
            {
                Id = ingrediente.Id,
                Descricao = ingrediente.Descricao,
                Valor = ingrediente.Valor
            };
        }

        public List<IngredienteSearchDto> BuscarTodos()
        {
            List<Ingrediente> ingredientes = _repositorio.BuscarTodos();
            List<IngredienteSearchDto> retorno = new List<IngredienteSearchDto>();

            foreach (var ingrediente in ingredientes)
            {
                retorno.Add(new IngredienteSearchDto
                {
                    Id = ingrediente.Id,
                    Descricao = ingrediente.Descricao,
                    Valor = ingrediente.Valor
                });
            }

            return retorno;
        }

        public void Excluir(Guid id)
        {
            _repositorio.Excluir(id);
        }

        public IngredienteDtoReturn Inserir(IngredienteInserirViewModel ingredienteViewModel)
        {
            var ingrediente = new Ingrediente(ingredienteViewModel.Descricao, ingredienteViewModel.Valor);

            if (!ingrediente.Valido())
                return new IngredienteDtoReturn(ingrediente.GetErros());

            ingrediente.GerarId();
            _repositorio.Inserir(ingrediente);

            return new IngredienteDtoReturn(BuscarPorId(ingrediente.Id));
        }
    }
}
